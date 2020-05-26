using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class TransportadoraMap : DommelEntityMap<Transportadora>
    {
        public TransportadoraMap()
        {
            ToTable("TRANSPORTADOR");
            Map(x => x.Cod_Trans).ToColumn("COD_TRANS").IsKey();
        }
    }
}
