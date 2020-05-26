using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Vendedor : EntidadeBase
    {
        public int Cod_Vendedor { get; set; }
        public int Cod_Empresa { get; set; }
        public string Nome { get; set; }
        public decimal Perc_Comissao { get; set; }
        public decimal Valor_Comissao { get; set; }
    }

    public class VendedorConsulta
    {
        public int Cod_Vendedor { get; set; }
        public string Nome { get; set; }
    }
}
