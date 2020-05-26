using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoEnderecoEntrega
    {
        EnderecoEntrega ObterPorId(int id);
        void Excluir(EnderecoEntrega  enderecoEntrega, string nomeUsuario);
        int Inserir(EnderecoEntrega enderecoEntrega, string nomeUsuario);
        int Alterar(EnderecoEntrega enderecoEntrega, string nomeUsuario);
    }
}
