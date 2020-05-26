using Comercial.Dominio.Entidades;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoConta
    {
        Conta ObterPorId(int id);
        IEnumerable<ContaConsulta> Filtrar(string campo, string valor, int codEmpresa, ContaFiltro contaFiltro, int id = 0);
        void Excluir(Conta conta, string nomeUsuario);
        int Salvar(Conta conta, List<ObsConta> obsContas, string nomeUsuario);
        IEnumerable<Conta> ObterPorPedido(int numPedido, int codEmpresa = 1, int tipoConta = 2);
        void ExcluirParcelas(int numPedido, int codEmpresa = 1, int tipoConta = 2);
        IEnumerable<ContaConsulta> ListarContas(ContaFiltro contaFiltro, TipoFinanceiro tipoFinanceiro, int id = 0);
        Conta ObterContasReceberPorDocumento(int codEmpresa, string documento);
        Conta ObterContasPagarPorDocumento(int codEmpresa, string documento);
    }

    public interface IServicoObsConta
    {
        IEnumerable<ObsConta> ObterPorConta(int IdConta, int codEmpresa);
        ObsConta ObterPorId(int id);
        void Excluir(int id);
        void Salvar(ObsConta obsConta);
        void ExcluirObsDaConta(int codEmpresa, int idConta);
    }
}
