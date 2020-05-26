using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Servicos
{
    public class ServicoCargaVencimento : IServicoCargaVencimento
    {
        private readonly IRepositorioCargaVencimento _repositorioCargaVencimento;
        public ServicoCargaVencimento(IDbConnection conexao, IDbTransaction transaction, IRepositorioCargaVencimento repositorioCargaVencimento)
        {
            _repositorioCargaVencimento = repositorioCargaVencimento;
        }
        public void Inserir(CargaVencimento cargaVencimento)
        {
            Validacao(cargaVencimento);
            _repositorioCargaVencimento.Insert(ref cargaVencimento);
        }

        public void Excluir(CargaVencimento cargaVencimento)
        {
            _repositorioCargaVencimento.Delete(cargaVencimento);
        }

        public void Alterar(CargaVencimento cargaVencimento)
        {
            Validacao(cargaVencimento);
            _repositorioCargaVencimento.Update(cargaVencimento);
        }

        private void Validacao(CargaVencimento cargaVencimento)
        {
            if (cargaVencimento.Vencto == null)
                throw new Exception("A data do vencimento é obrigatório!");
            if (cargaVencimento.Valor <= 0)
                throw new Exception("O valor da parcela é obrigatório!");
        }

        public CargaVencimento ObterPorId(int id)
        {
            return _repositorioCargaVencimento.GetById(id);
        }

        public IEnumerable<CargaVencimento> ListarVencimentosCarga(int idCarga)
        {
            return _repositorioCargaVencimento.GetList(x => x.Carga_Id == idCarga);
        }
    }
}
