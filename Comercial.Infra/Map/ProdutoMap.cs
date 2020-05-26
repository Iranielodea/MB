using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class ProdutoMap : DommelEntityMap<Produto>
    {
        public ProdutoMap()
        {
            ToTable("PRODUTO");
            Map(x => x.Cod_Produto).ToColumn("COD_PRODUTO").IsKey();
        }
    }
}
