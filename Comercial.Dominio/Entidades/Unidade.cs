using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Unidade : EntidadeBase
    {
        public int Id_Unidade { get; set; }
        public int Cod_Empresa { get; set; }
        public string Sigla { get; set; }
        public string Desc_Unidade { get; set; }
        public string Compl_Unidade { get; set; }
        public decimal Fator_Conversao { get; set; }
        public int? Id_Texto { get; set; }

        public virtual UnidadeTexto UnidadeTexto { get; set; }
    }

    public class UnidadeConsulta
    {
        public int Id_Unidade { get; set; }
        public string Sigla { get; set; }
        public string Desc_Unidade { get; set; }
    }
}
