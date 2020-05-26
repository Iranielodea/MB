using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoProduto
    {
        Produto ObterPorId(int id);
        IEnumerable<ProdutoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Produto produto, string nomeUsuario);
        int Salvar(Produto produto, string nomeUsuario);
    }
}
