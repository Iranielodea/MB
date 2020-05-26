using System;
using System.Collections.Generic;

namespace Comercial.Dominio.Entidades
{
    public class Pedido : EntidadeBase
    {
        public Pedido()
        {
            Situacao = "A";
            Data = DateTime.Now.Date;
        }

        public int Num_Pedido { get; set; }
        public DateTime Data { get; set; }
        public decimal Total_Bruto { get; set; }
        public decimal Perc_Desconto { get; set; }
        public decimal Valor_Desconto { get; set; }
        public decimal Total_Liquido { get; set; }
        public string Situacao { get; set; }
        public int Cod_For { get; set; }
        public int Cod_Empresa { get; set; }
        public int Cod_Cliente { get; set; }
        public string Obs { get; set; }
        public int? Cod_Contato { get; set; }
        public decimal Perc_Comissao { get; set; }
        public string Encerrado { get; set; }
        public decimal Total_Venda { get; set; }
        public decimal Total_Lucro { get; set; }
        public decimal Total_Qtde { get; set; }
        public int? Num_Carga { get; set; }
        public decimal Valor_Lucro { get; set; }
        public string Imp_Logo { get; set; }
        public int? Cod_Vendedor { get; set; }
        public decimal Valor_Comissao { get; set; }
        public decimal Total_Comissao { get; set; }
        public int? Cod_Usina { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Contato { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual Fornecedor Usina { get; set; }
        public virtual ICollection<PedidoItem> PedidoItems { get; set; }
    }

    public class PedidoConsulta
    {
        public int Num_Pedido { get; set; }
        public DateTime Data { get; set; }
        public int Cod_Cliente { get; set; }
        public string NomeCliente { get; set; }
        public string Situacao { get; set; }
        public decimal Total_Liquido { get; set; }
    }

    public class PedidoFiltro
    {
        public string DataInicial { get; set; }
        public string DataFinal { get; set; }
        public int CodCliente { get; set; }
        public int CodFornecedor { get; set; }
        public int NumPedido { get; set; }
        public string Situacao { get; set; }
    }
}
