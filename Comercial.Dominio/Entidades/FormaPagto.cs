using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class FormaPagto : EntidadeBase
    {
        public int Cod_Pagto { get; set; }
        public int Cod_Empresa { get; set; }
        public string Desc_Pagto { get; set; }
        public string Sigla { get; set; }
    }

    public class FormaPagtoConsulta
    {
        public int Cod_Pagto { get; set; }
        public string Desc_Pagto { get; set; }
        public string Sigla { get; set; }
    }
}
