using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class CargaVencimento
    {
        public int Id { get; set; }
        public int Carga_Id { get; set; }
        public int? Dias { get; set; }
        public DateTime? Vencto { get; set; }
        public decimal Valor { get; set; }
        public int? FormaPagto_Id { get; set; }

        public virtual Carga Cargas { get; set; }
    }
}
