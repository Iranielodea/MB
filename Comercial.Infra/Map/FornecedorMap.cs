using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class FornecedorMap : DommelEntityMap<Fornecedor>
    {
        public FornecedorMap()
        {
            ToTable("FORNECEDOR");
            Map(x => x.Cod_For).ToColumn("COD_FOR").IsKey();
        }
    }
}
