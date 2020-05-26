using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoFornecedor
    {
        Fornecedor ObterPorId(int id);
        IEnumerable<FornecedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Fornecedor fornecedor, string nomeUsuario);
        int Salvar(Fornecedor fornecedor, string nomeUsuario);
    }
}
