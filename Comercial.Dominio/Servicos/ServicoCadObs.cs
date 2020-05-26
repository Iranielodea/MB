using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;

namespace Comercial.Dominio.Servicos
{
    public class ServicoCadObs : ServicoBase<CadObs>, IServicoCadObs
    {
        private readonly IRepositorioCadObs _cadObsRepositorio;

        public ServicoCadObs(IRepositorioCadObs repositorioCadObs)
            :base(repositorioCadObs)
        {
            //_cadObsRepositorio = new RepositorioCadObs(conexao, transaction);
            _cadObsRepositorio = repositorioCadObs;
        }

        public CadObs ObterPorId(int id)
        {
            return _cadObsRepositorio.GetById(id);
        }

        public IEnumerable<CadObs> ObterPorCodigoCliente(int codigo, int codEmpresa = 1)
        {
            return _cadObsRepositorio.GetList(x => x.CodEmpresa == codEmpresa && x.Codigo == codigo && x.Tipo == "CLI");
        }

        public IEnumerable<CadObs> ObterPorCodigoCarga(int codigo, int codEmpresa = 1)
        {
            return _cadObsRepositorio.GetList(x => x.CodEmpresa == codEmpresa && x.Codigo == codigo && x.Tipo == "CAR");
        }

        public void Excluir(CadObs cadObs)
        {
            _cadObsRepositorio.Delete(cadObs);
        }

        public CadObs ObterUmRegistroCarga(int codigo, int numLinha, int codEmpresa = 1)
        {
            return _cadObsRepositorio.First(x => x.CodEmpresa == codEmpresa && x.Codigo == codigo 
                    && x.Num_Linha == numLinha && x.Tipo == "CAR");
        }

        public CadObs ObterUmRegistroCliente(int codigo, int numLinha, int codEmpresa = 1)
        {
            return _cadObsRepositorio.First(x => x.CodEmpresa == codEmpresa && x.Codigo == codigo 
                    && x.Num_Linha == numLinha && x.Tipo == "CLI");
        }

        private void Validar(CadObs cadObs)
        {
            if (string.IsNullOrWhiteSpace(cadObs.Texto))
                throw new Exception("Texto é obrigtório.");
        }

        public void InserirCliente(CadObs cadObs)
        {
            Validar(cadObs);
            cadObs.Tipo = "CLI";
            _cadObsRepositorio.Insert(ref cadObs);
        }

        public void AlterarCliente(CadObs cadObs)
        {
            Validar(cadObs);
            cadObs.Tipo = "CLI";
            _cadObsRepositorio.Update(cadObs);
        }

        public void InserirCarga(CadObs cadObs)
        {
            Validar(cadObs);
            cadObs.Tipo = "CAR";
            _cadObsRepositorio.Insert(ref cadObs);
        }

        public void AlterarCarga(CadObs cadObs)
        {
            Validar(cadObs);
            cadObs.Tipo = "CAR";
            _cadObsRepositorio.Update(cadObs);
        }
    }
}
