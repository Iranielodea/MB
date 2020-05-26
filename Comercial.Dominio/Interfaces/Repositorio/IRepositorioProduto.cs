using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioProduto : IRepositoryBase<Produto>
    {
    }

    public interface IRepositorioProdutoConsulta
    {
        IEnumerable<ProdutoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
