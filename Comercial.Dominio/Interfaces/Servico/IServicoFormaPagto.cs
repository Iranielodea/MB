using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoFormaPagto
    {
        FormaPagto ObterPorId(int id);
        IEnumerable<FormaPagtoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(FormaPagto formaPagto, string nomeUsuario);
        int Salvar(FormaPagto formaPagto, string nomeUsuario);
    }
}
