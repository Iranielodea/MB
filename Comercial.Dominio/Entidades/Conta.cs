using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Conta : EntidadeBase
    {
        public int Id_Conta { get; set; }
        public int Num_Pedido { get; set; }
        public int? Cod_Cliente { get; set; }
        public int? Cod_For { get; set; }
        public int Cod_Empresa { get; set; }
        public DateTime? Data_Emissao { get; set; }
        public decimal Valor_Pagar { get; set; }
        public DateTime? Data_Vencto { get; set; }
        public int? Dias { get; set; }
        public DateTime? Data_Pago { get; set; }
        public decimal Valor_Pago { get; set; }
        public int? Seq_Conta { get; set; }
        public decimal Valor_Original { get; set; }
        public int Tipo_Conta { get; set; }
        public string Situacao { get; set; }
        public string Documento { get; set; }
        public int? Cod_Pagto { get; set; }
        public int? Cod_Condicao { get; set; }
        public int? Id_ContaBanco { get; set; }
        public int? Id_Pedido { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual ContaBanco ContaBanco { get; set; }
        public virtual Condicao Condicao { get; set; }
        public virtual FormaPagto FormaPagto { get; set; }
    }

    public class ContaConsulta
    {
        public int Id_Conta { get; set; }
        public string Documento { get; set; }
        public int? Dias { get; set; }
        public DateTime? Data_Emissao { get; set; }
        public DateTime? Data_Vencto { get; set; }
        public decimal Valor_Pagar { get; set; }
        public DateTime? Data_Pago { get; set; }
        public decimal Valor_Pago { get; set; }
        public string Situacao { get; set; }
    }

    public class ContaFiltro
    {
        public int CodPessoa { get; set; }
        public string Documento { get; set; }
        public int CodEmpresa { get; set; }
    }

    public class ObsConta
    {
        public int Id_Obs { get; set; }
        public int Cod_Empresa { get; set; }
        public int Id_Conta { get; set; }
        public string Texto { get; set; }
    }
}
