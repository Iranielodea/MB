using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class PessoaCredito
    {
        public int Cod_Cliente { get; set; }
        public DateTime? Data_Credito { get; set; }
        public decimal Qtde_Credito { get; set; }
        public decimal Qtde_Usado { get; set; }
        public decimal Qtde_Saldo { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
