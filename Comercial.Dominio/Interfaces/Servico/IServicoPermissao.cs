using Comercial.Dominio.Entidades;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoPermissao
    {
        Permissao ObterPorId(int id);
        IEnumerable<PermissaoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Permissao permissao);
        int Salvar(Permissao permissao, string nomeUsuario);
        IEnumerable<Permissao> ObterPorUsuario(string nomeUsuario, int codEmpresa);
        bool UsuarioPermissaoAcesso(string tabela, string nomeUsuario);
        IEnumerable<Permissao> RetornarListaPermissoesUsuario(string tabela, string nomeUsuario);
        void Permitir(AcaoUsuario enumerador, string tabela, string nomeUsuario);
    }
}
