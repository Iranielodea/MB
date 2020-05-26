using Comercial.Dominio.Interfaces;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using Comercial.Dominio.Servicos;
using Comercial.Infra.Repositorio;
using FirebirdSql.Data.FirebirdClient;
using StructureMap;
using System.Data;

namespace CrossPlataforma
{
    public static class BootStrapper
    {
        //private static string connection =
        //"User=SYSDBA;" +
        //"Password=masterkey;" +
        //"Database=C:\\Projetos\\MB\\Banco\\Loja.fdb;" +
        //"DataSource=localhost;" +
        //"Port=3050;" +
        //"Dialect=3;" +
        //"Charset=NONE;" +
        //"Role=;" +
        //"Connection lifetime=15;" +
        //"Pooling=true;" +
        //"Packet Size=8192;" +
        //"ServerType=0";

        public static void ConfigureStructerMap()
        {
            ObjectFactory.Initialize(x =>
                {
                    x.For<IDbConnection>().Use<FbConnection>();
                    x.For<IDbTransaction>().Use<FbTransaction>();
                    x.For(typeof(IRepositoryBase<>)).Use(typeof(RepositoryBase<>));
                    x.For<IUnitOfWork>().Use<UnitOfWork>();

                    x.For(typeof(IRepositorioUsuario)).Use(typeof(RepositorioUsuario));
                    x.For(typeof(IRepositorioGrupo)).Use(typeof(RepositorioGrupo));
                    x.For(typeof(IRepositorioPermissao)).Use(typeof(RepositorioPermissao));
                    x.For(typeof(IRepositorioEstado)).Use(typeof(RepositorioEstado));
                    x.For(typeof(IRepositorioCadObs)).Use(typeof(RepositorioCadObs));
                    x.For(typeof(IRepositorioCidade)).Use(typeof(RepositorioCidade));
                    x.For(typeof(IRepositorioEmpresa)).Use(typeof(RepositorioEmpresa));
                    x.For(typeof(IRepositorioFormaPagto)).Use(typeof(RepositorioFormaPagto));
                    x.For(typeof(IRepositorioVendedor)).Use(typeof(RepositorioVendedor));
                    x.For(typeof(IRepositorioFornecedorTipoEmpresa)).Use(typeof(RepositorioFornecedorTipoEmpresa));
                    x.For(typeof(IRepositorioUnidadeTexto)).Use(typeof(RepositorioUnidadeTexto));
                    x.For(typeof(IRepositorioTabCodigo)).Use(typeof(RepositorioTabCodigo));
                    x.For(typeof(IRepositorioUnidade)).Use(typeof(RepositorioUnidade));
                    x.For(typeof(IRepositorioContaBanco)).Use(typeof(RepositorioContaBanco));
                    x.For(typeof(IRepositorioParametro)).Use(typeof(RepositorioParametro));
                    x.For(typeof(IRepositorioCliente)).Use(typeof(RepositorioCliente));
                    x.For(typeof(IRepositorioContato)).Use(typeof(RepositorioContato));
                    x.For(typeof(IRepositorioEnderecoEntrega)).Use(typeof(RepositorioEnderecoEntrega));
                    x.For(typeof(IRepositorioFornecedor)).Use(typeof(RepositorioFornecedor));
                    x.For(typeof(IRepositorioProduto)).Use(typeof(RepositorioProduto));
                    x.For(typeof(IRepositorioTransportadora)).Use(typeof(RepositorioTransportadora));
                    x.For(typeof(IRepositorioMotorista)).Use(typeof(RepositorioMotorista));
                    x.For(typeof(IRepositorioPedido)).Use(typeof(RepositorioPedido));
                    x.For(typeof(IRepositorioCarga)).Use(typeof(RepositorioCarga));
                    x.For(typeof(IRepositorioConta)).Use(typeof(RepositorioConta));
                    x.For(typeof(IRepositorioCargaVencimento)).Use(typeof(RepositorioCargaVencimento));
                    x.For(typeof(IRepositorioPessoaCredito)).Use(typeof(RepositorioPessoaCredito));
                    x.For(typeof(IRepositorioObsConta)).Use(typeof(RepositorioObsConta));
                    x.For(typeof(IRepositorioPedidoItem)).Use(typeof(RepositorioPedidoItem));

                    //x.For<ServicoUsuario>();
                    //x.For<ServicoCidade>();
                    x.For<IServicoUsuario>().Use<ServicoUsuario>();
                    x.For<IServicoGrupo>().Use<ServicoGrupo>();
                    x.For<IServicoPermissao>().Use<ServicoPermissao>();
                    x.For<IServicoEstado>().Use<ServicoEstado>();
                    x.For<IServicoCadObs>().Use<ServicoCadObs>();
                    x.For<IServicoCidade>().Use<ServicoCidade>();
                    x.For<IServicoEmpresa>().Use<ServicoEmpresa>();
                    x.For<IServicoFormaPagto>().Use<ServicoFormaPagto>();
                    x.For<IServicoVendedor>().Use<ServicoVendedor>();
                    x.For<IServicoFornecedorTipoEmpresa>().Use<ServicoFornecedorTipoEmpresa>();
                    x.For<IServicoUnidadeTexto>().Use<ServicoUnidadeTexto>();
                    x.For<IServicoTabCodigo>().Use<ServicoTabCodigo>();
                    x.For<IServicoUnidade>().Use<ServicoUnidade>();
                    x.For<IServicoContaBanco>().Use<ServicoContaBanco>();
                    x.For<IServicoParametro>().Use<ServicoParametro>();
                    x.For<IServicoCliente>().Use<ServicoCliente>();
                    x.For<IServicoContato>().Use<ServicoContato>();
                    x.For<IServicoEnderecoEntrega>().Use<ServicoEnderecoEntrega>();
                    x.For<IServicoFornecedor>().Use<ServicoFornecedor>();
                    x.For<IServicoProduto>().Use<ServicoProduto>();
                    x.For<IServicoTransportadora>().Use<ServicoTransportadora>();
                    x.For<IServicoMotorista>().Use<ServicoMotorista>();
                    x.For<IServicoPedido>().Use<ServicoPedido>();
                    x.For<IServicoCarga>().Use<ServicoCarga>();
                    x.For<IServicoConta>().Use<ServicoConta>();
                    x.For<IServicoCargaVencimento>().Use<ServicoCargaVencimento>();
                    x.For<IServicoPessoaCredito>().Use<ServicoPessoaCredito>();
                    x.For<IServicoObsConta>().Use<ServicoObsConta>();
                    x.For<IServicoPedidoItem>().Use<ServicoPedidoItem>();
                });
        }
    }
}
