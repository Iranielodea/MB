using Comercial.Infra.Map;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace CrossPlataforma
{
    public class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new GrupoMap());
                config.AddMap(new CadObsMap());
                config.AddMap(new UsuarioMap());
                config.AddMap(new PermissaoMap());
                config.AddMap(new EstadoMap());
                config.AddMap(new CidadeMap());
                config.AddMap(new EmpresaMap());
                config.AddMap(new FormaPagtoMap());
                config.AddMap(new VendedorMap());
                config.AddMap(new FornecedorTipoEmpresaMap());
                config.AddMap(new UnidadeTextoMap());
                config.AddMap(new UnidadeMap());
                config.AddMap(new ContaBancoMap());
                config.AddMap(new ParametroMap());
                config.AddMap(new ClienteMap());
                config.AddMap(new ContatoMap());
                config.AddMap(new EnderecoEntregaMap());
                config.AddMap(new FornecedorMap());
                config.AddMap(new ProdutoMap());
                config.AddMap(new TransportadoraMap());
                config.AddMap(new MotoristaMap());
                config.AddMap(new PedidoMap());
                config.AddMap(new CargaMap());
                config.AddMap(new ContaMap());
                config.AddMap(new ObsContaMap());
                config.AddMap(new PedidoItemMap());

                config.ForDommel();
            });
        }
    }
}
