using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{ 
    public interface IRepositorioEmpresa : IRepositoryBase<Empresa>
    {
    }

    public interface IRepositorioEmpresaConsulta
    {
        IEnumerable<EmpresaConsulta> Filtrar(string campo, string valor, int id = 0);
    }
}
