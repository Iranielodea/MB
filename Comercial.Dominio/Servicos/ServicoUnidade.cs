using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoUnidade : ServicoBase<Unidade>, IServicoUnidade
    {
        private readonly string _tabela;
        private readonly IRepositorioUnidade _repositorioUnidade;
        private readonly IRepositorioUnidadeConsulta _repositorioUnidadeConsulta;
        private readonly IServicoPermissao _servicoPermissao;

        public ServicoUnidade(IRepositorioUnidade repositorioUnidade,
            IRepositorioUnidadeConsulta repositorioUnidadeConsulta, IServicoPermissao servicoPermissao)
            :base(repositorioUnidade)
        {
            _repositorioUnidade = repositorioUnidade;
            _repositorioUnidadeConsulta = repositorioUnidadeConsulta;
            _servicoPermissao = servicoPermissao;
            _tabela = "UNIDADE";
        }

        public Unidade ObterPorId(int id)
        {
            return _repositorioUnidade.GetById(id);
        }

        public void Excluir(Unidade unidade, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioUnidade.Delete(unidade);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Unidade unidade, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(unidade.Desc_Unidade))
                throw new Exception("A Descrição é obrigatória!");

            if (string.IsNullOrWhiteSpace(unidade.Sigla))
                throw new Exception("A Sigla é obrigatória!");

            try
            {
                if (unidade.Id_Unidade == 0)
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    unidade.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioUnidade.Insert(ref unidade);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    unidade.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioUnidade.Update(unidade);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return unidade.Id_Unidade;
        }

        public Unidade ObterPorSigla(string sigla, int codEmpresa)
        {
            return _repositorioUnidade.First(x => x.Cod_Empresa == codEmpresa && x.Sigla == sigla);
        }

        public IEnumerable<UnidadeConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioUnidadeConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
