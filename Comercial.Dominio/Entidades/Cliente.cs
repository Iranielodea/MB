using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Cliente : PessoaBase
    {
        public Cliente()
        {
            PessoaCredito = new PessoaCredito();
            Cidade = new Cidade();
            FormaPagto = new FormaPagto();
            Vendedor = new Vendedor();
        }
        public int Cod_Cliente { get; set; }
        public int? Cod_Condicao { get; set; }
        public int? Cod_Pagto { get; set; }
        public string Fantasia { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CNPJ { get; set; }
        public string Insc_Estadual { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Tipo_Pessoa { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Obs { get; set; }
        public DateTime? Data_Cadastro { get; set; }
        public string Email { get; set; }
        public DateTime? Data_Abertura { get; set; }
        public string Comprador { get; set; }
        public int? Num_Func { get; set; }
        public string Nome_Anterior { get; set; }
        public string End_Pagamento { get; set; }
        public string End_Entrega { get; set; }
        public string Predio_Proprio { get; set; }
        public decimal Valor_Aluguel { get; set; }
        public decimal Consumo_Mensal { get; set; }
        public string Segmento { get; set; }
        public string Categoria { get; set; }
        public string Classificacao { get; set; }
        public decimal Qtde_Compra_Semana { get; set; }
        public int Dias_Aprazo { get; set; }
        public decimal Valor_Pedido { get; set; }
        public string Ficha_Cadastral { get; set; }
        public string Cartao_Cadastral { get; set; }
        public string Contrato_Social { get; set; }
        public string Doc_Proprietario { get; set; }
        public string Tipo_Ficha { get; set; }
        public string Marcar { get; set; }
        public int? Cod_Vendedor { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual FormaPagto FormaPagto { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        public virtual Condicao Condicao { get; set; }
        public virtual PessoaCredito PessoaCredito { get; set; }
    }

    public class ClienteConsulta
    {
        public int Cod_Cliente { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string CPF { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
    }

    public class ClienteUltimosPedidos
    {
        public int NumPedido { get; set; }
        public DateTime Data { get; set; }
        public string NomeProduto { get; set; }
        public string Unidade { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorPedido { get; set; }
        public decimal ValorVenda { get; set; }
    }
}
