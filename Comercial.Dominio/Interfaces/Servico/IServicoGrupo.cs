using Comercial.Dominio.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoGrupo
    {
        Grupo ObterPorId(int id);
        IEnumerable<GrupoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Grupo grupo, string nomeUsuario);
        int Salvar(Grupo grupo, string nomeUsuario);
        IEnumerable<GrupoConsulta> GetAll(string descricao);
    }
}
