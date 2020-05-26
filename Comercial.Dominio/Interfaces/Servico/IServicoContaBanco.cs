using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoContaBanco
    {
        ContaBanco ObterPorId(int id);
        IEnumerable<ContaBancoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(ContaBanco contaBanco, string nomeUsuario);
        int Salvar(ContaBanco contaBanco, string nomeUsuario);
    }
}
