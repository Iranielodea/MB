using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoVendedor
    {
        Vendedor ObterPorId(int id);
        IEnumerable<VendedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Vendedor vendedor, string nomeUsuario);
        int Salvar(Vendedor vendedor, string nomeUsuario);
    }
}
