using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoEmpresa
    {
        Empresa ObterPorId(int id);
        IEnumerable<EmpresaConsulta> Filtrar(string campo, string valor, int id = 0);
        void Excluir(int id, string nomeUsuario);
        int Salvar(Empresa empresa, string nomeUsuario);
    }
}
