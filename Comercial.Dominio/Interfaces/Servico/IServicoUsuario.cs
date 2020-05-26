using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoUsuario
    {
        Usuario ObterPorId(int id);
        IEnumerable<UsuarioConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        int Salvar(Usuario usuario, string nomeUsuario);
        Usuario ObterPorUsuarioSenha(string usuario, string senha, int codEmpresa);
        void Excluir(Usuario usuario, string nomeUsuario);
    }
}
