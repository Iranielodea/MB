using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoParametro
    {
        Parametro ObterPorId(int id);
        IEnumerable<ParametroConsulta> Filtrar(string campo, string valor, int id = 0);
        void Excluir(Parametro parametro, string nomeUsuario);
        int Salvar(Parametro parametro, string nomeUsuario);
    }
}
