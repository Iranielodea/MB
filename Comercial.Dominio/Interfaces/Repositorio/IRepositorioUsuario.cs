using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioUsuario : IRepositoryBase<Usuario>
    {
    }

    public interface IRepositorioUsuarioConsulta
    {
        IEnumerable<UsuarioConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
