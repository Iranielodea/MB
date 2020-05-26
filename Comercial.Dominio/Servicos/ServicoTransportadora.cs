﻿using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoTransportadora : ServicoBase<Transportadora>, IServicoTransportadora
    {
        private readonly string _tabela;
        private readonly IRepositorioTransportadora _repositorioTransportadora;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioTransportadoraConsulta _repositorioTransportadoraConsulta;
        private readonly IRepositorioCidade _repositorioCidade;
        private readonly IRepositorioEstado _repositorioEstado;

        public ServicoTransportadora(IRepositorioTransportadora repositorioTransportadora,
            IRepositorioTransportadoraConsulta repositorioTransportadoraConsulta, IServicoPermissao servicoPermissao, IRepositorioCidade repositorioCidade,
            IRepositorioEstado repositorioEstado)
            :base(repositorioTransportadora)
        {
            _repositorioTransportadora = repositorioTransportadora;
            _repositorioTransportadoraConsulta = repositorioTransportadoraConsulta;
            _servicoPermissao = servicoPermissao;
            _repositorioCidade = repositorioCidade;
            _repositorioEstado = repositorioEstado;
            _tabela = "TRANSPORTADOR";
        }

        public Transportadora ObterPorId(int id)
        {
            return _repositorioTransportadora.GetById(id);
        }

        public void Excluir(Transportadora transportadora, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioTransportadora.Delete(transportadora);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Transportadora transportadora, string nomeUsuario)
        {
            try
            {
                if (transportadora.CPF_Transp != null)
                {
                    string documento = Dominio.Geral.Funcao.SomenteNumeros(transportadora.CPF_Transp);
                    if (documento.Length > 0)
                    {
                        if (!Geral.Validacao.ValidarCPF(documento))
                            throw new Exception("CPF inválido!");
                    }
                }

                if (transportadora.CNPJ != null)
                {
                    string documento = Dominio.Geral.Funcao.SomenteNumeros(transportadora.CNPJ);
                    if (documento.Length > 0)
                    {
                        if (!Geral.Validacao.ValidarCnpj(documento))
                            throw new Exception("CNPJ inválido!");
                    }
                }

                if (string.IsNullOrWhiteSpace(transportadora.Nome))
                    throw new Exception("O Nome é obrigatório!");

                if (!string.IsNullOrWhiteSpace(transportadora.Insc_Estadual) && transportadora.Cod_Cidade != null)
                {
                    transportadora.Cidade = _repositorioCidade.GetById(transportadora.Cod_Cidade.Value);
                    if (transportadora.Cidade.Id_Estado > 0)
                    {
                        transportadora.Cidade.Estado = _repositorioEstado.GetById(transportadora.Cidade.Id_Estado);
                        if (!Geral.Validacao.ValidarIE(transportadora.Insc_Estadual, transportadora.Cidade.Estado.Sigla))
                            throw new Exception("Inscrição Estadual Inválida!");
                    }
                }

                if (transportadora.Cod_Trans == 0)
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    transportadora.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioTransportadora.Insert(ref transportadora);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    transportadora.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioTransportadora.Update(transportadora);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return transportadora.Cod_Trans;
        }

        public IEnumerable<TransportadoraConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioTransportadoraConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
