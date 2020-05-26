using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioCliente : IRepositoryBase<Cliente>
    {
        IEnumerable<ClienteUltimosPedidos> UltimosPedidos(int idCliente);
    }

    public interface IRepositorioClienteConsulta
    {
        IEnumerable<ClienteConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }

    public interface IRepositorioPessoaCredito : IRepositoryBase<PessoaCredito>
    {
        PessoaCredito ObterPorCodigo(int codigo);
        void Atualizar(PessoaCredito pessoaCredito);
    }
}
