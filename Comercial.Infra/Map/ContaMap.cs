using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class ContaMap : DommelEntityMap<Conta>
    {
        public ContaMap()
        {
            ToTable("CONTAS");
            Map(x => x.Id_Conta).ToColumn("ID_CONTA").IsKey();
        }
    }

    public class ObsContaMap : DommelEntityMap<ObsConta>
    {
        public ObsContaMap()
        {
            ToTable("OBS_CONTAS");
            Map(x => x.Id_Obs).ToColumn("ID_OBS").IsKey();
        }
    }
}
