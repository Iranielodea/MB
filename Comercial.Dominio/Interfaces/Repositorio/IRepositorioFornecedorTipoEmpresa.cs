using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioFornecedorTipoEmpresa : IRepositoryBase<FornecedorTipoEmpresa>
    {
    }

    public interface IRepositorioFornecedorTipoEmpresaConsulta
    {
        IEnumerable<FornecedorTipoEmpresaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
