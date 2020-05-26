using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class UsuarioMap : DommelEntityMap<Usuario>
    {
        public UsuarioMap()
        {
            ToTable("CAD_USUARIO");
            Map(x => x.Id_Usuario).IsKey();
        }
    }
}
