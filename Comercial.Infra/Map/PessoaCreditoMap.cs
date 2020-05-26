using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class PessoaCreditoMap : DommelEntityMap<PessoaCredito>
    {
        public PessoaCreditoMap()
        {
            ToTable("PESSOA_CREDITO");
            Map(x => x.Cod_Cliente).ToColumn("COD_CLIENTE").IsKey();
        }
    }
}
