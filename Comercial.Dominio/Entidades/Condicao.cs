using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Condicao : EntidadeBase
    {
        public int Cod_Condicao { get; set; }
        public int Cod_Empresa { get; set; }
        public string Desc_Condicao { get; set; }
    }
}
