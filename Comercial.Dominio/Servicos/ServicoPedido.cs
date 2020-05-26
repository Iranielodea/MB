using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoPedido : ServicoBase<Pedido>, IServicoPedido
    {
        private readonly string _tabela;
        private readonly IRepositorioPedido _repositorioPedido;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioPedidoConsulta _repositorioPedidoConsulta;
        private readonly IRepositorioCarga _repositorioCarga;
        private readonly IRepositorioConta _repositorioConta;
        private readonly IRepositorioPedidoItem _repositorioPedidoItem;

        public ServicoPedido(
            IRepositorioPedido repositorioPedido,
            IRepositorioPedidoConsulta repositorioPedidoConsulta,
            IServicoPermissao servicoPermissao,
            IRepositorioConta repositorioConta,
            IRepositorioCarga repositorioCarga,
            IRepositorioPedidoItem repositorioPedidoItem
            ) : base(repositorioPedido)
        {
            _repositorioPedido = repositorioPedido;
            _repositorioPedidoConsulta = repositorioPedidoConsulta;
            _servicoPermissao = servicoPermissao;
            _repositorioCarga = repositorioCarga;
            _repositorioPedidoItem = repositorioPedidoItem;
            _repositorioConta = repositorioConta;
            _tabela = "PEDIDO";
        }

        public Pedido ObterPorId(int codEmpresa, int numPedido)
        {
            return _repositorioPedido.ObterPedido(codEmpresa, numPedido);
        }

        public Pedido ObterPedido(int codEmpresa, int numPedido)
        {
            var pedido = ObterPorId(codEmpresa, numPedido);
            pedido.PedidoItems = _repositorioPedidoItem.GetList(x => x.Cod_Empresa == codEmpresa && x.Num_Pedido == numPedido).ToList();
            return pedido;
        }

        private void AlterarItens(Pedido pedido, string nomeUsuario)
        {
            //var ItensBanco = _servicoPedidoItem.ItensPorPedido(pedido.Cod_Empresa, pedido.Num_Pedido);
            //foreach (var itemBanco in ItensBanco)
            //{
            //    var model = pedido.PedidoItems.FirstOrDefault(x => x.Num_Pedido == itemBanco.Num_Pedido && x.Cod_Produto == itemBanco.Cod_Produto && x.Seq == itemBanco.Seq);
            //    if (model == null)
            //    {
            //        _servicoPedidoItem.Excluir(_servicoPedidoItem.ObterPorId(
            //            pedido.Cod_Empresa, pedido.Num_Pedido, itemBanco.Cod_Produto, itemBanco.Seq));
            //    }
            //    else
            //    {
            //        var alterar = _servicoPedidoItem.ObterPorId(pedido.Cod_Empresa, pedido.Num_Pedido, itemBanco.Cod_Produto, itemBanco.Seq);
            //        _servicoPedidoItem.Salvar(alterar, nomeUsuario);
            //    }
            //}
        }

        private void ExcluirItens(Pedido pedido, string nomeUsuario)
        {
            var pedidoItem = new PedidoItem();
            foreach (var item in pedido.PedidoItems)
            {
                pedidoItem = _repositorioPedidoItem.First(x => x.Cod_Empresa == item.Cod_Empresa &&
                x.Num_Pedido == pedido.Num_Pedido && 
                x.Cod_Produto == item.Cod_Produto &&
                x.Seq == item.Seq);

                _repositorioPedidoItem.Delete(pedidoItem);
            }
        }

        public void Excluir(Pedido pedido, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);

                ExcluirItens(pedido, nomeUsuario);

                _repositorioPedido.Delete(pedido);

                // contas
                var contas = _repositorioConta.ObterPorPedido(pedido.Num_Pedido, pedido.Cod_Empresa, (int)TipoFinanceiro.tfPedido);
                foreach (var conta in contas)
                    _repositorioConta.Delete(conta);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Pedido pedido, string nomeUsuario)
        {
            if (pedido.Cod_Cliente == 0)
                throw new Exception("O cliente é obrigatório!");
            if (pedido.Cod_For == 0)
                throw new Exception("O fornecedor é obrigatório!");

            CalcularTotalPedido(pedido);

            try
            {
                if (pedido.Num_Pedido == 0)
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    pedido.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioPedido.Insert(ref pedido);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    pedido.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioPedido.Update(pedido);
                }

                // trocar cliente contas
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return pedido.Num_Pedido;
        }

        public IEnumerable<PedidoConsulta> Filtrar(string campo, string valor, int codEmpresa, PedidoFiltro pedidoFiltro, int id = 0)
        {
            return _repositorioPedidoConsulta.Filtrar(campo, valor, codEmpresa, pedidoFiltro, id);
        }

        public Pedido ObterPorPedido(int codEmpresa, int idPedido)
        {
            return _repositorioPedido.ObterPedido(codEmpresa, idPedido);
        }

        public void AlterarValorCarga(Pedido pedido, string nomeUsuario)
        {
            // buscar todas as cargas do pedido
            var cargas = _repositorioCarga.ObterCargasDoPedido(pedido.Num_Pedido);
            if (cargas != null)
            {
                foreach (var carga in cargas)
                {
                    // se foi alterado o cliente, trocar o cliente das cargas
                    if (pedido.Cod_Cliente != carga.Cod_Cliente)
                        carga.Cod_Cliente = pedido.Cod_Cliente;

                    // Se fornecedor foi trocado o fornecedor, trocar nas cargas
                    if (pedido.Cod_For != carga.Cod_For)
                        carga.Cod_For = pedido.Cod_For;

                    // Na carga o VALOR_PEDIDO = Pedido.Total_Liquido
                    carga.Valor_Pedido = pedido.Total_Liquido;

                    // Se Pedido.Total_Qtde for diferente do anterior
                    // então carga.Qtde_Pedido = Pedido.Total_Qtde
                    carga.Qtde_Pedido = pedido.Total_Qtde;

                    // Se Pedido.ValorLucro <> do anterior
                    // calcular Lucro
                    _repositorioCarga.CalcularLucro(carga, true);

                    //_repositorioCarga.Salvar(carga, nomeUsuario);

                    // atualizar o Valor_Pagar = carga.valor_carrega das contas onde contas.NumPedido = Id_Carga a Tipo_Conta = 2
                    var contas = _repositorioConta.ObterPorPedido(pedido.Num_Pedido, pedido.Cod_Empresa, (int)TipoFinanceiro.tfReceber);
                    if (contas != null)
                    {
                        foreach (var conta in contas)
                        {
                            conta.Valor_Pagar = carga.Valor_Carrega;
                            _repositorioConta.Salvar(conta, null, nomeUsuario);
                        }
                    }

                    // trocar o cliente do contas a receber tipo conta = 1
                    contas = _repositorioConta.ObterPorPedido(carga.Id_Carga, pedido.Cod_Empresa, (int)TipoFinanceiro.tfPedido);
                    if (contas != null)
                    {
                        foreach (var conta in contas)
                        {
                            if (pedido.Cod_Cliente != conta.Cod_Cliente)
                            {
                                conta.Cod_Cliente = pedido.Cod_Cliente;
                                _repositorioConta.Salvar(conta, null, nomeUsuario);
                            }
                        }
                    }
                }
            }
        }

        private void CalcularTotalPedido(Pedido pedido)
        {
            pedido.Total_Liquido = pedido.PedidoItems.Sum(x => x.Valor);
            pedido.Total_Venda = pedido.PedidoItems.Sum(x => x.Total_Venda);
            pedido.Total_Lucro = pedido.PedidoItems.Sum(x => x.Total_Lucro);
            pedido.Total_Qtde = pedido.PedidoItems.Sum(x => x.Qtde);
            pedido.Valor_Lucro = pedido.PedidoItems.Sum(x => x.Valor_Lucro);

            CalcularComissao(pedido);
        }

        public void CalcularComissao(Pedido pedido)
        {
            pedido.Total_Comissao = (pedido.Total_Qtde * pedido.Valor_Comissao);
        }
    }
}
