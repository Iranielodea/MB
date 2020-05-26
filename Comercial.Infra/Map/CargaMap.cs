using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class CargaMap : DommelEntityMap<Carga>
    {
        public CargaMap()
        {
            ToTable("CARGA");
            Map(x => x.Id_Carga).ToColumn("ID_CARGA").IsKey();
        }
    }

    public class CargaVencimentoMap: DommelEntityMap<CargaVencimento>
    {
        public CargaVencimentoMap()
        {
            ToTable("CARGA_VENCTO");
            Map(x => x.Id).ToColumn("ID").IsKey();
        }
    }
}
