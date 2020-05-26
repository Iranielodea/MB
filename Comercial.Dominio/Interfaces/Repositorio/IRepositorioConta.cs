using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioConta : IRepositoryBase<Conta>
    {
        IEnumerable<Conta> ObterPorPedido(int numPedido, int codEmpresa = 1, int tipoConta = 2);
        Conta ObterContasReceberPorDocumento(int codEmpresa, string documento);
        Conta ObterContasPagarPorDocumento(int codEmpresa, string documento);
        int Salvar(Conta conta, List<ObsConta> obsContas, string nomeUsuario);
    }

    public interface IRepositorioContaConsulta
    {
        IEnumerable<ContaConsulta> Filtrar(string campo, string valor, int codEmpresa, ContaFiltro contaFiltro, int id = 0);
        IEnumerable<ContaConsulta> ObterContasAReceber(ContaFiltro contaFiltro, int id = 0);
        IEnumerable<ContaConsulta> ObterContasAPagar(ContaFiltro contaFiltro, int id = 0);
    }

    public interface IRepositorioObsConta : IRepositoryBase<ObsConta>
    {
        IEnumerable<ObsConta> ObterPorConta(int IdConta, int codEmpresa);
    }
}
