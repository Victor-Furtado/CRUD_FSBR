namespace CRUD_FSBR.Models
{
    public class MunicipioRes
    {
        public string id { get; set; }
        public string nome { get; set; }
    }
    public class Municipio
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Microrregiao microrregiao { get; set; }
        public RegiaoImediata regiaoImediata { get; set; }
    }

    public class Microrregiao
    {
        public int id { get; set; }
        public string nome { get; set; }
        public Mesorregiao mesorregiao { get; set; }
    }

    public class Mesorregiao
    {
        public int id { get; set; }
        public string nome { get; set; }
        public UF UF { get; set; }
    }

    public class RegiaoImediata
    {
        public int id { get; set; }
        public string nome { get; set; }
        public RegiaoIntermediaria regiaoIntermediaria { get; set; }
    }

    public class RegiaoIntermediaria
    {
        public int id { get; set; }
        public string nome { get; set; }
        public UF UF { get; set; }
    }
}