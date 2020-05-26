using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioFornecedor : IRepositoryBase<Fornecedor>
    {
    }

    public interface IRepositorioFornecedorConsulta
    {
        IEnumerable<FornecedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
