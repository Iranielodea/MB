using Comercial.Dominio.Entidades;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoCliente : ServicoBase<Cliente>, IServicoCliente
    {
        private readonly string _tabela;
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioClienteConsulta _repositorioClienteConsulta;
        private readonly IServicoPessoaCredito _servicoPessoaCredito;

        public ServicoCliente(IRepositorioCliente repositorioCliente,
            IRepositorioClienteConsulta repositorioClienteConsulta, IServicoPermissao servicoPermissao,
            IServicoPessoaCredito servicoPessoaCredito)
            :base(repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioClienteConsulta = repositorioClienteConsulta;
            _servicoPermissao = servicoPermissao;
            _servicoPessoaCredito = servicoPessoaCredito;
            _tabela = "CLIENTE";
        }

        public Cliente ObterPorId(int id)
        {
            return _repositorioCliente.GetById(id);
        }

        public void Excluir(Cliente cliente, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioCliente.Delete(cliente);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Cliente cliente, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome))
                throw new Exception("O nome é obrigatória!");

            if (!Validacao.ValidarCnpj(cliente.CNPJ))
                throw new Exception("CNPJ inválido!");

            if (!Validacao.ValidarCPF(cliente.CPF))
                throw new Exception("CPF inválido!");

            try
            {
                if (cliente.Cod_Cliente == 0)
                {
                    cliente.Cod_Empresa = DadosStaticos.IdEmpresa;
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    cliente.Usu_Inc = PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioCliente.Insert(ref cliente);

                    if (cliente.PessoaCredito.Qtde_Credito > 0)
                        _servicoPessoaCredito.Salvar(cliente.PessoaCredito);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    cliente.Usu_Alt = PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioCliente.Update(cliente);

                    _servicoPessoaCredito.Salvar(cliente.PessoaCredito);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return cliente.Cod_Cliente;
        }

        public IEnumerable<ClienteConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioClienteConsulta.Filtrar(campo, valor, codEmpresa, id);
        }

        public IEnumerable<ClienteUltimosPedidos> UltimosPedidos(int idCliente)
        {
            return _repositorioCliente.UltimosPedidos(idCliente);
        }
    }
}
