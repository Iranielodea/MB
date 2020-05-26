using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioVendedor : IRepositoryBase<Vendedor>
    {
    }

    public interface IRepositorioVendedorConsulta
    {
        IEnumerable<VendedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
