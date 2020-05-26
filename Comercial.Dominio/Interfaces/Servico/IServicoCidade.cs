using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoCidade
    {
        Cidade ObterPorId(int id);
        IEnumerable<CidadeConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Cidade cidade, string nomeUsuario);
        int Salvar(Cidade cidade, string nomeUsuario);
    }
}
