using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoCliente
    {
        Cliente ObterPorId(int id);
        IEnumerable<ClienteConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Cliente cliente, string nomeUsuario);
        int Salvar(Cliente cliente, string nomeUsuario);
        IEnumerable<ClienteUltimosPedidos> UltimosPedidos(int idCliente);
    }

    public interface IServicoPessoaCredito
    {
        PessoaCredito ObterPorId(int id);
        void Salvar(PessoaCredito pessoaCredito);
        void Atualizar(PessoaCredito pessoaCredito);
    }
}
