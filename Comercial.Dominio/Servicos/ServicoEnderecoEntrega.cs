﻿using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoEnderecoEntrega : ServicoBase<EnderecoEntrega>, IServicoEnderecoEntrega
    {
        private readonly string _tabela;
        private readonly IRepositorioEnderecoEntrega _repositorioEnderecoEntrega;
        private readonly IServicoPermissao _servicoPermissao;

        public ServicoEnderecoEntrega(IRepositorioEnderecoEntrega repositorioEnderecoEntrega,
            IServicoPermissao servicoPermissao)
            : base(repositorioEnderecoEntrega)
        {
            _repositorioEnderecoEntrega = repositorioEnderecoEntrega;
            _servicoPermissao = servicoPermissao;
            _tabela = "END_ENTREGA";
        }

        public EnderecoEntrega ObterPorId(int id)
        {
            return _repositorioEnderecoEntrega.GetById(id);
        }

        public void Excluir(EnderecoEntrega enderecoEntrega, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioEnderecoEntrega.Delete(enderecoEntrega);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void Salvar(EnderecoEntrega enderecoEntrega)
        {
            if (string.IsNullOrWhiteSpace(enderecoEntrega.Endereco))
                throw new Exception("O endereço é obrigatório!");
        }

        public int Inserir(EnderecoEntrega enderecoEntrega, string nomeUsuario)
        {
            try
            {
                Salvar(enderecoEntrega);
                _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                _repositorioEnderecoEntrega.Insert(ref enderecoEntrega);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return enderecoEntrega.Cod_Cliente;
        }

        public int Alterar(EnderecoEntrega enderecoEntrega, string nomeUsuario)
        {
            try
            {
                Salvar(enderecoEntrega);
                _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                _repositorioEnderecoEntrega.Update(enderecoEntrega);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return enderecoEntrega.Cod_Cliente;
        }
    }
}
