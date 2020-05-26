using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class PedidoItem : EntidadeBase
    {
        public int Cod_Produto { get; set; }
        public int Num_Pedido { get; set; }
        public int Seq { get; set; }
        public decimal Qtde { get; set; }
        public decimal Valor { get; set; }
        public decimal Valor_Total { get; set; }
        public int Id_Unidade { get; set; }
        public int? Cod_Empresa { get; set; }
        public decimal Preco_Venda { get; set; }
        public decimal Valor_Lucro { get; set; }
        public decimal Total_Lucro { get; set; }
        public decimal Total_Venda { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Unidade Unidade { get; set; }

        public virtual string NomeProduto { get; set; }
        public virtual string SiglaUn { get; set; }
    }
}
