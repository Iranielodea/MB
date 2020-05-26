using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class EmpresaMap : DommelEntityMap<Empresa>
    {
        public EmpresaMap()
        {
            ToTable("EMPRESA");
            Map(x => x.Cod_Empresa).ToColumn("COD_EMPRESA").IsKey();
        }
    }
}
