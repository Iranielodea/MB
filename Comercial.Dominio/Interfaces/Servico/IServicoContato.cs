using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoContato
    {
        IEnumerable<ContatoConsulta> Filtrar(string campo, string valor, int codEmpresa);
        void Excluir(Contato contato, string nomeUsuario);
        IEnumerable<ContatoConsulta> ObterPorCodigo(int codEmpresa, int codigo, Enumeradores.Enumerador.EnContato enContato);
        Contato ObterPorId(int codEmpresa, int codigo, int seq, Enumeradores.Enumerador.EnContato enContato);
        int Salvar(Contato contato, string nomeUsuario, Enumeradores.Enumerador.EnContato enContato);
    }
}
