using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioFormaPagto : IRepositoryBase<FormaPagto>
    {
    }

    public interface IRepositorioFormaPagtoConsulta
    {
        IEnumerable<FormaPagtoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
