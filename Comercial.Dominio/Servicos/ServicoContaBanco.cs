using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoContaBanco : ServicoBase<ContaBanco>, IServicoContaBanco
    {
        private readonly string _tabela;
        private readonly IRepositorioContaBanco _repositorioContaBanco;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioContaBancoConsulta _repositorioContaBancoConsulta;

        public ServicoContaBanco(IRepositorioContaBanco repositorioContaBanco,
            IRepositorioContaBancoConsulta repositorioContaBancoConsulta, IServicoPermissao servicoPermissao)
            :base(repositorioContaBanco)
        {
            _repositorioContaBanco = repositorioContaBanco;
            _repositorioContaBancoConsulta = repositorioContaBancoConsulta;
            _servicoPermissao = servicoPermissao;
            _tabela = "CONTABANCO";
        }

        public ContaBanco ObterPorId(int id)
        {
            return _repositorioContaBanco.GetById(id);
        }

        public void Excluir(ContaBanco contaBanco, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioContaBanco.Delete(contaBanco);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(ContaBanco contaBanco, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(contaBanco.Num_Conta))
                throw new Exception("O número da conta é obrigatória!");

            try
            {
                if (contaBanco.Id_ContaBanco == 0)
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    contaBanco.Cod_Empresa = DadosStaticos.IdEmpresa;
                    _repositorioContaBanco.Insert(ref contaBanco);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    _repositorioContaBanco.Update(contaBanco);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return contaBanco.Id_ContaBanco;
        }

        public IEnumerable<ContaBancoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioContaBancoConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
