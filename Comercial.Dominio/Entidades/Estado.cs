using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comercial.Dominio.Entidades
{
    public class Estado : EntidadeBase
    {
        public int Id_Estado { get; set; }
        public int Cod_Empresa { get; set; }
        public string Sigla { get; set; }
        public string Desc_Estado { get; set; }
        public decimal ICMS { get; set; }
    }

    public class EstadoConsulta
    {
        public int Id_Estado { get; set; }
        public string Sigla { get; set; }
        public string Desc_Estado { get; set; }
    }
}
