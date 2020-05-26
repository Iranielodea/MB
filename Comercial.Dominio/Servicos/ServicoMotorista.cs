using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoMotorista : ServicoBase<Motorista>, IServicoMotorista
    {
        private readonly string _tabela;
        private readonly IRepositorioMotorista _repositorioMotorista;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioMotoristaConsulta _repositorioMotoristaConsulta;

        public ServicoMotorista(IRepositorioMotorista repositorioMotorista,
            IRepositorioMotoristaConsulta repositorioMotoristaConsulta, IServicoPermissao servicoPermissao)
            :base(repositorioMotorista)
        {
            _repositorioMotorista = repositorioMotorista;
            _repositorioMotoristaConsulta = repositorioMotoristaConsulta;
            _servicoPermissao = servicoPermissao;
            _tabela = "MOTORISTA";
        }

        public Motorista ObterPorId(int id)
        {
            return _repositorioMotorista.GetById(id);
        }

        public void Excluir(Motorista motorista, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioMotorista.Delete(motorista);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Motorista motorista, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(motorista.Nome))
                throw new Exception("O nome é obrigatório!");

            if (motorista.CPF != null)
            {
                string documento = Dominio.Geral.Funcao.SomenteNumeros(motorista.CPF);
                if (documento.Length > 0)
                {
                    if (!Geral.Validacao.ValidarCPF(documento))
                        throw new Exception("CPF inválido!");
                }
            }

            try
            {
                if (motorista.Cod_Motorista == 0)
                {
                    motorista.Cod_Empresa = DadosStaticos.IdEmpresa;
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    motorista.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioMotorista.Insert(ref motorista);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    motorista.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioMotorista.Update(motorista);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return motorista.Cod_Motorista;
        }

        public IEnumerable<MotoristaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioMotoristaConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
