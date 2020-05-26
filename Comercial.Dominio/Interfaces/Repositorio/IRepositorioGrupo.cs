using Comercial.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioGrupo : IRepositoryBase<Grupo>
    {
    }

    public interface IRepositorioGrupoConsulta
    {
        IEnumerable<GrupoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        IQueryable<GrupoConsulta> GetAll();
    }
}
