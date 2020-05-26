using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class ConfPedido
    {
        public int Num_Pedido { get; set; }
        public string Frete_Pago_Descarga { get; set; }
        public string Com_Manifesto { get; set; }
        public string Com_Descarga { get; set; }
        public string Texto { get; set; }
        public string Vencimento { get; set; }
        public string Prazo { get; set; }
    }
}
