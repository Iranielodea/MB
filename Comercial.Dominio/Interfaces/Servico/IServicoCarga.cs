using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoCarga : IServicoBase<Carga>
    {
        Carga ObterPorId(int id);
        IEnumerable<CargaConsulta> Filtrar(string campo, string valor, int codEmpresa, CargaFiltro cargaFiltro, int id = 0);
        void Excluir(Carga carga, string nomeUsuario);
        int Salvar(Carga carga, string nomeUsuario);
        void BuscarDadosPedido(Carga carga, int idPedido, bool incluindo);
        IEnumerable<Carga> ObterCargasDoPedido(int numPedido);
        decimal CalcularLucro(Carga carga, bool calcularTudo);
        Carga ObterPorPedido(int numPedido);
    }

    public interface IServicoCargaVencimento
    {
        CargaVencimento ObterPorId(int id);
        void Inserir(CargaVencimento cargaVencimento);
        void Alterar(CargaVencimento cargaVencimento);
        void Excluir(CargaVencimento cargaVencimento);
        IEnumerable<CargaVencimento> ListarVencimentosCarga(int idCarga);
    }
}
