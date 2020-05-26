using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoConta : ServicoBase<Conta>, IServicoConta
    {
        private readonly string _tabela;
        private readonly IRepositorioConta _repositorioConta;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioContaConsulta _repositorioContaConsulta;
        private readonly IServicoObsConta _servicoObsConta;
        private readonly IRepositorioCarga _repositorioCarga;

        public ServicoConta(IRepositorioConta repositorioConta,
            IRepositorioContaConsulta repositorioContaConsulta, 
            IServicoPermissao servicoPermissao, IServicoObsConta servicoObsConta,
            IRepositorioCarga repositorioCarga
            )
            :base(repositorioConta)
        {
            _repositorioConta = repositorioConta;
            _repositorioContaConsulta = repositorioContaConsulta;
            _servicoPermissao = servicoPermissao;
            _servicoObsConta = servicoObsConta;
            _repositorioCarga = repositorioCarga;
            _tabela = "CONTAS";
        }

        public Conta ObterPorId(int id)
        {
            return _repositorioConta.GetById(id);
        }

        public void Excluir(Conta conta, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _servicoObsConta.ExcluirObsDaConta(conta.Cod_Empresa, conta.Id_Conta);
                _repositorioConta.Delete(conta);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Conta conta, List<ObsConta> obsContas, string nomeUsuario)
        {
            if (conta.Tipo_Conta == 2)
            {
                if (conta.Cod_Cliente == 0)
                    throw new Exception("O cliente é obrigatório!");
            }

            if (conta.Tipo_Conta == 3)
            {
                if (conta.Cod_For == 0)
                    throw new Exception("O fornecedor é obrigatório!");
            }

            if (conta.Data_Emissao == null)
                throw new Exception("Informe a Data de Emissão!");

            if (conta.Data_Vencto == null)
                throw new Exception("Informe a Data de Vencimento!");

            if (conta.Data_Vencto < conta.Data_Emissao)
                throw new Exception("A Data de Vencimento é Menor que data de Emissão!");

            if (conta.Data_Pago != null)
            {
                if (conta.Data_Pago < conta.Data_Emissao)
                    throw new Exception("A Data de Pagamento é menor que a Data de Emissão!");
            }

            try
            {
                AlterarCarga(conta);

                if (conta.Id_Conta == 0)
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    conta.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioConta.Insert(ref conta);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    conta.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioConta.Update(conta);
                }

                GravarObsConta(conta, obsContas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conta.Id_Conta;
        }

        private void AlterarCarga(Conta conta)
        {
            if (conta.Tipo_Conta == 2)
            {
                var carga = _repositorioCarga.First(x => x.Cod_Empresa == conta.Cod_Empresa 
                    && x.Num_Pedido == conta.Num_Pedido);
                if (carga != null)
                {
                    string situacao = "A";

                    if (conta.Situacao == "P")
                        situacao = "E";

                    carga.Situacao = situacao;
                    carga.Financeiro = situacao;

                    _repositorioCarga.Update(carga);
                }
            }
        }

        private void GravarObsConta(Conta conta, List<ObsConta> obsContas)
        {
            _servicoObsConta.ExcluirObsDaConta(conta.Cod_Empresa, conta.Id_Conta);

            foreach (var item in obsContas)
            {
                item.Id_Conta = conta.Id_Conta;
                _servicoObsConta.Salvar(item);
            }
        }

        public IEnumerable<ContaConsulta> Filtrar(string campo, string valor, int codEmpresa, ContaFiltro contaFiltro, int id = 0)
        {
            return _repositorioContaConsulta.Filtrar(campo, valor, codEmpresa, contaFiltro, id);
        }

        public IEnumerable<Conta> ObterPorPedido(int numPedido)
        {
            return _repositorioConta.ObterPorPedido(numPedido);
        }

        public IEnumerable<Conta> ObterPorPedido(int numPedido, int codEmpresa = 1, int tipoConta = 2)
        {
            return _repositorioConta.ObterPorPedido(numPedido, codEmpresa, tipoConta);
        }

        public Conta ObterContasReceberPorDocumento(int codEmpresa, string documento)
        {
            return _repositorioConta.ObterContasReceberPorDocumento(codEmpresa, documento);
        }

        public Conta ObterContasPagarPorDocumento(int codEmpresa, string documento)
        {
            return _repositorioConta.ObterContasPagarPorDocumento(codEmpresa, documento);
        }

        public void ExcluirParcelas(int numPedido, int codEmpresa = 1, int tipoConta = 2)
        {
            var conta = _repositorioConta.First(x => x.Cod_Empresa == codEmpresa 
                && x.Num_Pedido == numPedido && x.Tipo_Conta == tipoConta);

            if (conta != null)
                _repositorioConta.Delete(conta);
        }

        public IEnumerable<ContaConsulta> ListarContas(ContaFiltro contaFiltro, TipoFinanceiro tipoFinanceiro, int id = 0)
        {
            if (contaFiltro.CodPessoa == 0 && string.IsNullOrWhiteSpace(contaFiltro.Documento))
                contaFiltro.CodPessoa = 99999;

            if (tipoFinanceiro == TipoFinanceiro.tfReceber)
                return _repositorioContaConsulta.ObterContasAReceber(contaFiltro, id);
            else
                return _repositorioContaConsulta.ObterContasAPagar(contaFiltro, id);
        }
    }
}
