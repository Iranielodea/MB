using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class FornecedorTipoEmpresaMap : DommelEntityMap<FornecedorTipoEmpresa>
    {
        public FornecedorTipoEmpresaMap()
        {
            ToTable("FORN_TIPO_EMPRESA");
            Map(x => x.Id_Tipo).ToColumn("ID_TIPO").IsKey();
        }
    }
}
