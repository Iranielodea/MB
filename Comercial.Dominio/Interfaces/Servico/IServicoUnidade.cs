using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoUnidade
    {
        Unidade ObterPorId(int id);
        IEnumerable<UnidadeConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Unidade unidade, string nomeUsuario);
        int Salvar(Unidade unidade, string nomeUsuario);
    }
}
