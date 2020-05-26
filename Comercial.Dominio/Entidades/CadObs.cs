using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comercial.Dominio.Entidades
{
    public class CadObs
    {
        public int CodEmpresa { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public int Num_Linha { get; set; }
        public string Texto { get; set; }
    }
}
