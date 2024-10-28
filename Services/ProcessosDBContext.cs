using CRUD_FSBR.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CRUD_FSBR.Services
{
    public class ProcessosDBContext : DbContext
    {
        public ProcessosDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Processo> Processos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Processo>().Property(b => b.Municipio)
                .HasConversion(
                    v => JsonConvert.SerializeObject(v),
                    v => JsonConvert.DeserializeObject<MunicipioRes>(v));

            // SEED PARA TESTES
            modelBuilder.Entity<Processo>().HasData(
                new Processo { Id = 1, Nome = "Processo Teste 1", Npu = "1234567-89.1234.1.56.7890", CadastradoEm = DateTime.Parse("2023-04-15"), VisualizadoEm = DateTime.Parse("2023-04-18"), UF = "DF", Municipio = new MunicipioRes { id = "5300108", nome = "Brasília" } },
                new Processo { Id = 2, Nome = "Processo Teste 2", Npu = "2345678-10.5678.2.45.1234", CadastradoEm = DateTime.Parse("2023-05-22"), VisualizadoEm = DateTime.Parse("2023-05-23"), UF = "RJ", Municipio = new MunicipioRes { id = "3304557", nome = "Rio de Janeiro" } },
                new Processo { Id = 3, Nome = "Processo Teste 3", Npu = "3456789-12.3456.3.67.4567", CadastradoEm = DateTime.Parse("2023-06-30"), VisualizadoEm = DateTime.Parse("2023-07-02"), UF = "MG", Municipio = new MunicipioRes { id = "3106200", nome = "Belo Horizonte" } },
                new Processo { Id = 4, Nome = "Processo Teste 4", Npu = "4567890-14.6789.4.12.9876", CadastradoEm = DateTime.Parse("2023-07-10"), VisualizadoEm = DateTime.Parse("2023-07-12"), UF = "BA", Municipio = new MunicipioRes { id = "2927408", nome = "Salvador" } },
                new Processo { Id = 5, Nome = "Processo Teste 5", Npu = "5678901-16.2345.5.34.5432", CadastradoEm = DateTime.Parse("2023-08-25"), VisualizadoEm = DateTime.Parse("2023-08-26"), UF = "RS", Municipio = new MunicipioRes { id = "4314902", nome = "Porto Alegre" } },
                new Processo { Id = 6, Nome = "Processo Teste 6", Npu = "6789012-18.5678.6.78.1234", CadastradoEm = DateTime.Parse("2023-09-10"), VisualizadoEm = DateTime.Parse("2023-09-12"), UF = "PR", Municipio = new MunicipioRes { id = "4106902", nome = "Curitiba" } },
                new Processo { Id = 7, Nome = "Processo Teste 7", Npu = "7890123-20.1234.7.89.5678", CadastradoEm = DateTime.Parse("2023-10-05"), VisualizadoEm = DateTime.Parse("2023-10-07"), UF = "SC", Municipio = new MunicipioRes { id = "4205407", nome = "Florianópolis" } },
                new Processo { Id = 8, Nome = "Processo Teste 8", Npu = "8901234-21.3456.8.23.6789", CadastradoEm = DateTime.Parse("2023-11-15"), VisualizadoEm = DateTime.Parse("2023-11-17"), UF = "AM", Municipio = new MunicipioRes { id = "1302603", nome = "Manaus" } },
                new Processo { Id = 9, Nome = "Processo Teste 9", Npu = "9012345-23.6789.9.12.7890", CadastradoEm = DateTime.Parse("2023-12-22"), VisualizadoEm = DateTime.Parse("2023-12-24"), UF = "CE", Municipio = new MunicipioRes { id = "2304400", nome = "Fortaleza" } },
                new Processo { Id = 10, Nome = "Processo Teste 10", Npu = "1234567-25.2345.1.56.1234", CadastradoEm = DateTime.Parse("2024-01-15"), VisualizadoEm = DateTime.Parse("2024-01-16"), UF = "PE", Municipio = new MunicipioRes { id = "2611606", nome = "Recife" } },
                new Processo { Id = 11, Nome = "Processo Teste 11", Npu = "2345678-26.5678.2.45.2345", CadastradoEm = DateTime.Parse("2024-02-10"), VisualizadoEm = DateTime.Parse("2024-02-12"), UF = "GO", Municipio = new MunicipioRes { id = "5208707", nome = "Goiânia" } },
                new Processo { Id = 12, Nome = "Processo Teste 12", Npu = "3456789-28.1234.3.67.4567", CadastradoEm = DateTime.Parse("2024-03-22"), VisualizadoEm = DateTime.Parse("2024-03-24"), UF = "ES", Municipio = new MunicipioRes { id = "3205309", nome = "Vitória" } },
                new Processo { Id = 13, Nome = "Processo Teste 13", Npu = "4567890-30.6789.4.12.6789", CadastradoEm = DateTime.Parse("2024-04-18"), VisualizadoEm = DateTime.Parse("2024-04-20"), UF = "AL", Municipio = new MunicipioRes { id = "2704302", nome = "Maceió" } },
                new Processo { Id = 14, Nome = "Processo Teste 14", Npu = "5678901-32.2345.5.34.7890", CadastradoEm = DateTime.Parse("2024-05-10"), VisualizadoEm = DateTime.Parse("2024-05-12"), UF = "PB", Municipio = new MunicipioRes { id = "2507507", nome = "João Pessoa" } },
                new Processo { Id = 15, Nome = "Processo Teste 15", Npu = "6789012-34.5678.6.78.8901", CadastradoEm = DateTime.Parse("2024-06-30"), VisualizadoEm = DateTime.Parse("2024-07-02"), UF = "RN", Municipio = new MunicipioRes { id = "2408102", nome = "Natal" } },
                new Processo { Id = 16, Nome = "Processo Teste 16", Npu = "7890123-36.1234.7.89.0123", CadastradoEm = DateTime.Parse("2024-07-22"), VisualizadoEm = DateTime.Parse("2024-07-23"), UF = "SE", Municipio = new MunicipioRes { id = "2800308", nome = "Aracaju" } },
                new Processo { Id = 17, Nome = "Processo Teste 17", Npu = "8901234-38.3456.8.23.1234", CadastradoEm = DateTime.Parse("2024-08-10"), VisualizadoEm = DateTime.Parse("2024-08-12"), UF = "DF", Municipio = new MunicipioRes { id = "5300108", nome = "Brasília" } },
                new Processo { Id = 18, Nome = "Processo Teste 18", Npu = "9012345-40.6789.9.12.2345", CadastradoEm = DateTime.Parse("2024-09-15"), VisualizadoEm = DateTime.Parse("2024-09-16"), UF = "MA", Municipio = new MunicipioRes { id = "2111300", nome = "São Luís" } },
                new Processo { Id = 19, Nome = "Processo Teste 19", Npu = "1234567-42.2345.1.56.3456", CadastradoEm = DateTime.Parse("2024-10-10"), VisualizadoEm = DateTime.Parse("2024-10-12"), UF = "PI", Municipio = new MunicipioRes { id = "2211001", nome = "Teresina" } },
                new Processo { Id = 20, Nome = "Processo Teste 20", Npu = "2345678-44.5678.2.45.4567", CadastradoEm = DateTime.Parse("2024-11-20"), VisualizadoEm = DateTime.Parse("2024-11-21"), UF = "PA", Municipio = new MunicipioRes { id = "1501402", nome = "Belém" } },
                new Processo { Id = 21, Nome = "Processo Teste 21", Npu = "3456789-46.1234.3.67.5678", CadastradoEm = DateTime.Parse("2024-12-05"), VisualizadoEm = DateTime.Parse("2024-12-07"), UF = "TO", Municipio = new MunicipioRes { id = "1721000", nome = "Palmas" } },
                new Processo { Id = 22, Nome = "Processo Teste 22", Npu = "4567890-48.6789.4.12.6789", CadastradoEm = DateTime.Parse("2025-01-25"), VisualizadoEm = DateTime.Parse("2025-01-26"), UF = "AC", Municipio = new MunicipioRes { id = "1200401", nome = "Rio Branco" } },
                new Processo { Id = 23, Nome = "Processo Teste 23", Npu = "5678901-50.2345.5.34.7890", CadastradoEm = DateTime.Parse("2025-02-18"), VisualizadoEm = DateTime.Parse("2025-02-20"), UF = "AP", Municipio = new MunicipioRes { id = "1600303", nome = "Macapá" } },
                new Processo { Id = 24, Nome = "Processo Teste 24", Npu = "6789012-52.5678.6.78.8901", CadastradoEm = DateTime.Parse("2025-03-15"), VisualizadoEm = DateTime.Parse("2025-03-16"), UF = "RR", Municipio = new MunicipioRes { id = "1400100", nome = "Boa Vista" } },
                new Processo { Id = 25, Nome = "Processo Teste 25", Npu = "7890123-54.1234.7.89.9012", CadastradoEm = DateTime.Parse("2025-04-22"), VisualizadoEm = DateTime.Parse("2025-04-23"), UF = "AM", Municipio = new MunicipioRes { id = "1302603", nome = "Manaus" } },
                new Processo { Id = 26, Nome = "Processo Teste 26", Npu = "8901234-56.3456.8.23.1234", CadastradoEm = DateTime.Parse("2025-05-30"), VisualizadoEm = DateTime.Parse("2025-06-02"), UF = "RO", Municipio = new MunicipioRes { id = "1100205", nome = "Porto Velho" } },
                new Processo { Id = 27, Nome = "Processo Teste 27", Npu = "9012345-58.6789.9.12.2345", CadastradoEm = DateTime.Parse("2025-06-22"), VisualizadoEm = DateTime.Parse("2025-06-23"), UF = "MT", Municipio = new MunicipioRes { id = "5103403", nome = "Cuiabá" } },
                new Processo { Id = 28, Nome = "Processo Teste 28", Npu = "1234567-60.2345.1.56.3456", CadastradoEm = DateTime.Parse("2025-07-15"), VisualizadoEm = DateTime.Parse("2025-07-16"), UF = "MS", Municipio = new MunicipioRes { id = "5002704", nome = "Campo Grande" } },
                new Processo { Id = 29, Nome = "Processo Teste 29", Npu = "2345678-62.5678.2.45.4567", CadastradoEm = DateTime.Parse("2025-08-10"), VisualizadoEm = DateTime.Parse("2025-08-12"), UF = "MG", Municipio = new MunicipioRes { id = "3106200", nome = "Belo Horizonte" } },
                new Processo { Id = 30, Nome = "Processo Teste 30", Npu = "3456789-64.1234.3.67.5678", CadastradoEm = DateTime.Parse("2025-09-05"), VisualizadoEm = DateTime.Parse("2025-09-07"), UF = "RJ", Municipio = new MunicipioRes { id = "3304557", nome = "Rio de Janeiro" } }
            );
        }
    }
}
