using Comercial.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioCarga : IRepositoryBase<Carga>
    {
        Carga ObterCargasDoMotorista(int codEmpresa, DateTime data, int codMotorista);
        Carga ObterUltimaCargaDaData(int codEmpresa, DateTime data);
        decimal ObterSaldoCarga(int codEmpresa, int idCarga, int numPedido);
        Carga ObterPorPedido(int numPedido);
        IEnumerable<Carga> ObterCargasDoPedido(int numPedido);
        decimal CalcularLucro(Carga carga, bool calcularTudo);
    }

    public interface IRepositorioCargaConsulta
    {
        IEnumerable<CargaConsulta> Filtrar(string campo, string valor, int codEmpresa, CargaFiltro pedidoFiltro, int id = 0);
    }

    public interface IRepositorioCargaVencimento : IRepositoryBase<CargaVencimento>
    {
        
    }
}
