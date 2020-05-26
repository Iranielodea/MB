using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoMotorista
    {
        Motorista ObterPorId(int id);
        IEnumerable<MotoristaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
        void Excluir(Motorista motorista, string nomeUsuario);
        int Salvar(Motorista motorista, string nomeUsuario);
    }
}
