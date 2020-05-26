using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Carga : EntidadeBase
    {
        public int Id_Carga { get; set; }
        public int Cod_Cliente { get; set; }
        public int? Cod_Contato { get; set; }
        public int Num_Pedido { get; set; }
        public int Num_Carga { get; set; }
        public string Letra { get; set; }
        public DateTime Data { get; set; }
        public string Visto { get; set; }
        public decimal Qtde { get; set; }
        public decimal Valor_Pedido { get; set; }
        public decimal Valor_Carrega { get; set; }
        public decimal Valor_Frete { get; set; }
        public int Cod_Empresa { get; set; }
        public int Cod_For { get; set; }
        public int? Cod_Motorista { get; set; }
        public int? Cod_Agencia { get; set; }
        public decimal Qtde_Pedido { get; set; }
        public string Placa { get; set; }
        public string Obs { get; set; }
        public string Situacao { get; set; }
        public string Financeiro { get; set; }
        public string Complemento { get; set; }
        public string Contato_Indicacao { get; set; }
        public decimal Saldo { get; set; }
        public string Armazem { get; set; }
        public string Unidade { get; set; }
        public string ComplUnidade { get; set; }
        public string Obs2 { get; set; }
        public string Num_NF { get; set; }
        public DateTime? Data_NF { get; set; }
        public int? Cod_Manifesto { get; set; }
        public decimal Qtde_Cada { get; set; }
        public int? Id_Unidade { get; set; }
        public int? Id_ContaBanco { get; set; }
        public string CNPJ_CPF { get; set; }
        public string Credito_NF { get; set; }
        public string Num_Nota2 { get; set; }
        public decimal IR { get; set; }
        public decimal Valor_Nota2 { get; set; }
        public int? Cod_Usina { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Cliente Contato { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Motorista Motorista { get; set; }
        public virtual Agenciador Agenciador { get; set; }
        public virtual Unidade Unidades { get; set; }
        public virtual ContaBanco ContaBanco { get; set; }
        public virtual Fornecedor Usina { get; set; }
        public virtual List<CargaVencimento> CargaVencimentos { get; set; }
        public virtual List<CadObs> Observacoes { get; set; }
    }

    public class CargaConsulta
    {
        public int Num_Carga { get; set; }
        public string Letra { get; set; }
        public int Num_Pedido { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public decimal Qtde_Pedido { get; set; }
        public decimal Qtde { get; set; }
        public decimal Valor_Pedido { get; set; }
        public decimal Valor_Frete { get; set; }
        public int Id_Carga { get; set; }
    }

    public class CargaFiltro
    {
        public string DataInicial { get; set; }
        public string DataFinal { get; set; }
        public int CodCliente { get; set; }
        public int CodFornecedor { get; set; }
        public int NumCarga { get; set; }
    }
}
