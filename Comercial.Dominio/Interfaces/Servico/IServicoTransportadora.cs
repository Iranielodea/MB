using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoTransportadora
    {
        Transportadora ObterPorId(int id);
        IEnumerable<TransportadoraConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Transportadora transportadora, string nomeUsuario);
        int Salvar(Transportadora transportadora, string nomeUsuario);
    }
}
