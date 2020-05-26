namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioTabCodigo
    {
        void AtualizaCidade(int codigo);
        void AtualizaCliente(int codigo);
        void AtualizaCondicaoPagto(int codigo);
        void AtualizaEmpresa(int codigo);
        void AtualizaEstado(int codigo);
        void AtualizaFormaPagto(int codigo);
        void AtualizaPermissao(int codigo);
        void AtualizaFornecedor(int codigo);
        void AtualizaGrupo(int codigo);
        void AtualizaPedido(int codigo);
        void AtualizaProduto(int codigo);
        void AtualizaUnidade(int codigo);
        void AtualizaUsuario(int codigo);
        void AtualizaVendedor(int codigo);
        void AtualizaTipoFornecedor(int codigo);
        int RetornarUltimoSequencial(string generator);
    }
}
