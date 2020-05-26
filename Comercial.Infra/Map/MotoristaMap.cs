using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class MotoristaMap : DommelEntityMap<Motorista>
    {
        public MotoristaMap()
        {
            ToTable("MOTORISTA");
            Map(x => x.Cod_Motorista).ToColumn("COD_MOTORISTA").IsKey();
        }
    }
}
