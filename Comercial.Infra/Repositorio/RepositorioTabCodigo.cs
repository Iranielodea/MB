using Comercial.Dominio.Interfaces.Repositorio;
using Dapper;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioTabCodigo : IRepositorioTabCodigo
    {
        private IDbConnection _conexao;

        public RepositorioTabCodigo(IDbConnection conexao)
        {
            _conexao = conexao;
        }

        public void AtualizaCidade(int codigo)
        {
            ExecutarComando("GEN_CIDADE", codigo);
        }

        public void AtualizaCliente(int codigo)
        {
            ExecutarComando("GEN_CLIENTE", codigo);
        }

        public void AtualizaCondicaoPagto(int codigo)
        {
            ExecutarComando("GEN_CONDICAO", codigo);
        }

        public void AtualizaEmpresa(int codigo)
        {
            ExecutarComando("GEN_EMPRESA", codigo);
        }

        public void AtualizaEstado(int codigo)
        {
            ExecutarComando("GEN_ESTADO", codigo);
        }

        public void AtualizaFormaPagto(int codigo)
        {
            ExecutarComando("GEN_FORMAPAGTO", codigo);
        }

        public void AtualizaFornecedor(int codigo)
        {
            ExecutarComando("GEN_FORNECEDOR", codigo);
        }

        public void AtualizaGrupo(int codigo)
        {
            ExecutarComando("GEN_GRUPO", codigo);
        }

        public void AtualizaPedido(int codigo)
        {
            ExecutarComando("GEN_PEDIDO", codigo);
        }

        public void AtualizaPermissao(int codigo)
        {
            ExecutarComando("GEN_PERMISSAO", codigo);
        }

        public void AtualizaProduto(int codigo)
        {
            ExecutarComando("GEN_PRODUTO", codigo);
        }

        public void AtualizaTipoFornecedor(int codigo)
        {
            ExecutarComando("GEN_FORN_TIPO_EMPRESA", codigo);
        }

        public void AtualizaUnidade(int codigo)
        {
            ExecutarComando("GEN_UNIDADE", codigo);
        }

        public void AtualizaUsuario(int codigo)
        {
            ExecutarComando("GEN_USUARIO", codigo);
        }

        public void AtualizaVendedor(int codigo)
        {
            ExecutarComando("GEN_VENDEDOR", codigo);
        }

        private void ExecutarComando(string generator, int codigo)
        {
            _conexao.Execute("SET GENERATOR " + generator + " TO " + codigo);
        }

        public int RetornarUltimoSequencial(string generator)
        {
            return _conexao.Query<int>("SELECT GEN_ID(" + generator + ", 0) FROM RDB$DATABASE").FirstOrDefault();
        }
    }
}
