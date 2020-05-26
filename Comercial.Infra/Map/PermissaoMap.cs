using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class PermissaoMap : DommelEntityMap<Permissao>
    {
        public PermissaoMap()
        {
            ToTable("PERMISSAO");
            Map(x => x.Id_Per).ToColumn("ID_PER").IsKey();
        }
    }
}
