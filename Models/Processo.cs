using System.ComponentModel.DataAnnotations;

namespace CRUD_FSBR.Models
{
    public class Processo
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [RegularExpression("^\\d{7}-\\d{2}\\.\\d{4}\\.\\d\\.\\d{2}\\.\\d{4}$")]
        public string Npu { get; set; }

        public DateTime CadastradoEm { get; set; }

        public DateTime VisualizadoEm { get; set; }

        [MaxLength(2)]
        public string UF { get; set; }

        public MunicipioRes Municipio { get; set; }
    }

    public class ProcessoDTO
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required, RegularExpression("^\\d{7}-\\d{2}\\.\\d{4}\\.\\d\\.\\d{2}\\.\\d{4}$", ErrorMessage = "Formatação incorreta")]
        public string Npu { get; set; } = "";

        [MaxLength(2)]
        public string UF { get; set; }

        [Required]
        public string Municipio { get; set; }
    }
}
