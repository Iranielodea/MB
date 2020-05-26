using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoEstado
    {
        Estado ObterPorId(int id);
        IEnumerable<EstadoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        int Salvar(Estado estado, string nomeUsuario);
        Estado ObterPorSigla(string sigla, int codEmpresa);
        void Excluir(Estado estado, string nomeUsuario);
    }
}
