using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoUnidadeTexto
    {
        UnidadeTexto ObterPorId(int id);
        IEnumerable<UnidadeTextoConsulta> Filtrar(string campo, string valor, int id = 0);
        void Excluir(UnidadeTexto unidadeTexto, string nomeUsuario);
        int Salvar(UnidadeTexto unidadeTexto, string nomeUsuario);
    }
}
