using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class EnderecoEntregaMap : DommelEntityMap<EnderecoEntrega>
    {
        public EnderecoEntregaMap()
        {
            ToTable("END_ENTREGA");
            Map(x => x.Cod_Cliente).ToColumn("COD_CLIENTE").IsKey();
            Map(x => x.Cidade).Ignore();
        }
    }
}
