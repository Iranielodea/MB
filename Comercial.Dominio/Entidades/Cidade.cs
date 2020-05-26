using System.ComponentModel.DataAnnotations;

namespace Comercial.Dominio.Entidades
{
    public class Cidade : EntidadeBase
    {
        public int Cod_Cidade { get; set; }
        public string Desc_Cidade { get; set; }
        public string CEP { get; set; }
        public int Cod_Empresa { get; set; }
        public int Id_Estado { get; set; }
        public virtual Estado Estado { get; set; }        
    }

    public class CidadeConsulta
    {
        public int Cod_Cidade { get; set; }
        public string Sigla { get; set; }
        public string Desc_Cidade { get; set; }
    }
}
