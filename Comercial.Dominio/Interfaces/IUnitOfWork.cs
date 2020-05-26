using Comercial.Dominio.Interfaces.Servico;
using System;

namespace Comercial.Dominio.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void RollBack();

        IServicoUsuario ServicoUsuario { get; }
        IServicoPermissao ServicoPermissao { get; }
        IServicoGrupo ServicoGrupo { get; }
        IServicoEstado ServicoEstado { get; }
        IServicoCadObs ServicoCadObs { get; }
        IServicoCidade ServicoCidade { get; }
        IServicoEmpresa ServicoEmpresa { get; }
        IServicoFormaPagto ServicoFormaPagto { get; }
        IServicoVendedor ServicoVendedor { get; }
        IServicoFornecedorTipoEmpresa ServicoFornecedorTipoEmpresa { get; }
        IServicoUnidadeTexto ServicoUnidadeTexto { get; }
        IServicoTabCodigo ServicoTabCodigo { get; }
        IServicoUnidade ServicoUnidade { get; }
        IServicoContaBanco ServicoContaBanco { get; }
        IServicoParametro ServicoParametro { get; }
        IServicoCliente ServicoCliente { get; }
        IServicoContato ServicoContato { get; }
        IServicoEnderecoEntrega ServicoEnderecoEntrega { get; }
        IServicoFornecedor ServicoFornecedor { get; }
        IServicoProduto ServicoProduto { get; }
        IServicoTransportadora ServicoTransportadora { get; }
        IServicoMotorista ServicoMotorista { get; }
        IServicoPedido ServicoPedido { get; }
        IServicoCarga ServicoCarga { get; }
        IServicoConta ServicoConta { get; }
        IServicoCargaVencimento ServicoCargaVencimento { get; }
        IServicoPessoaCredito ServicoPessoaCredito { get; }
        IServicoObsConta ServicoObsConta { get; }
        IServicoPedidoItem ServicoPedidoItem { get; }
    }
}
