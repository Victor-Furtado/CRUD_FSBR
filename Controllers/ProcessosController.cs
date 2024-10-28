using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_FSBR.Models;
using CRUD_FSBR.Services;
using System.Text.Json;

namespace CRUD_FSBR.Controllers
{
    public class ProcessosController : Controller
    {
        private readonly ProcessosDBContext _context;

        public ProcessosController(ProcessosDBContext context)
        {
            _context = context;
        }

        // GET: Processos
        public async Task<IActionResult> Index(int page = 1, int pageSize = 10)
        {
            var totalItems = await _context.Processos.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var processos = await _context.Processos
                .OrderBy(x => x.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return View(processos);
        }

        // GET: Processos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // GET: Processos/UpdateVizualizadoEm/5
        public async Task<IActionResult> UpdateVizualizadoEm(int id)
        {
            try
            {
                await _context.Processos
                    .Where(p => p.Id == id)
                    .ExecuteUpdateAsync(a => a.SetProperty(
                        p => p.VisualizadoEm, DateTime.Now
                    ));
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProcessoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Json(new { success = true, visualizadoEm = DateTime.Now });
        }

        // GET: Processos/Create
        public async Task<IActionResult> Create()
        {
            using (var client = new HttpClient())
            {
                var apiUrl = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var UFList = JsonSerializer.Deserialize<List<UF>>(content) ?? new List<UF> { new UF { sigla = "ERRO" } };
                ViewBag.UFList = UFList.OrderBy(q => q.sigla);
            }
            return View();
        }

        // GET: Processos/GetMunicipios/SP
        public async Task<IActionResult> GetMunicipios(string uf)
        {
            using (var client = new HttpClient())
            {
                var apiUrl = $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{uf}/municipios";
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var municipios = JsonSerializer.Deserialize<List<Municipio>>(content) ?? new List<Municipio> { new Municipio { nome = "ERRO" } };
                return Json(municipios.OrderBy(q => q.nome));
            }
        }

        // POST: Processos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Npu,UF,Municipio")] ProcessoDTO processodto)
        {
            if (ModelState.IsValid)
            {
                string[] municipio = processodto.Municipio.Split("_");
                var processo = new Processo()
                {
                    CadastradoEm = DateTime.Now,
                    VisualizadoEm = DateTime.Now,
                    Nome = processodto.Nome,
                    Npu = processodto.Npu,
                    Municipio = new MunicipioRes { id = municipio.First(), nome = municipio.Last() },
                    UF = processodto.UF,
                };
                _context.Add(processo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(processodto);
        }

        // GET: Processos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos.FindAsync(id);
            if (processo == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                var apiUrl = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var UFList = JsonSerializer.Deserialize<List<UF>>(content) ?? new List<UF> { new UF { sigla = "ERRO" } };
                ViewBag.UFList = UFList.OrderBy(q => q.sigla);
            }

            using (var client = new HttpClient())
            {
                var apiUrl = $"https://servicodados.ibge.gov.br/api/v1/localidades/estados/{processo.UF}/municipios"; ;
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsStringAsync();
                var MunicipioList = JsonSerializer.Deserialize<List<Municipio>>(content) ?? new List<Municipio> { new Municipio { id = 0, nome = "ERRO" } };
                ViewBag.MunicipioList = MunicipioList.OrderBy(q => q.nome);
            }

            var processoDto = new ProcessoDTO()
            {
                Nome = processo.Nome,
                Municipio = $"{processo.Municipio.id}_{processo.Municipio.nome}",
                Npu = processo.Npu,
                UF = processo.UF
            };

            return View(processoDto);
        }

        // POST: Processos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nome,Npu,UF,Municipio")] ProcessoDTO processodto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string[] municipio = processodto.Municipio.Split("_");
                    await _context.Processos
                        .Where(p => p.Id == id)
                        .ExecuteUpdateAsync(a => a
                            .SetProperty(p => p.Nome, processodto.Nome)
                            .SetProperty(p => p.Npu, processodto.Npu)
                            .SetProperty(p => p.Municipio, new MunicipioRes { id = municipio.First(), nome = municipio.Last() })
                            .SetProperty(p => p.UF, processodto.UF)
                        );
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProcessoExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(processodto);
        }

        // GET: Processos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var processo = await _context.Processos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (processo == null)
            {
                return NotFound();
            }

            return View(processo);
        }

        // POST: Processos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var processo = await _context.Processos.FindAsync(id);
            if (processo != null)
            {
                _context.Processos.Remove(processo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProcessoExists(int id)
        {
            return _context.Processos.Any(e => e.Id == id);
        }
    }
}