using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoGrupo : ServicoBase<Grupo>, IServicoGrupo
    {
        private readonly IRepositorioGrupo _repositorioGrupo;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioGrupoConsulta _repositorioGrupoConsulta;
        private readonly string _tabela;

        public ServicoGrupo(IRepositorioGrupo repositorioGrupo,
            IServicoPermissao servicoPermissao, IRepositorioGrupoConsulta repositorioGrupoConsulta) : base(repositorioGrupo)
        {
            _repositorioGrupo = repositorioGrupo;
            _servicoPermissao = servicoPermissao;
            _repositorioGrupoConsulta = repositorioGrupoConsulta;
            _tabela = "GRUPO";
        }

        public void Excluir(Grupo grupo, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioGrupo.Delete(grupo);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<GrupoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioGrupoConsulta.Filtrar(campo, valor, codEmpresa, id);
        }

        public IEnumerable<GrupoConsulta> GetAll(string descricao)
        {
            return _repositorioGrupoConsulta.GetAll().Where(x => x.Cod_Grupo > 0).OrderBy(x => x.Desc_Grupo).ToList();
        }

        public Grupo ObterPorId(int id)
        {
            return _repositorioGrupo.GetById(id);
        }

        public int Salvar(Grupo grupo, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(grupo.Desc_Grupo))
                throw new Exception("A Descrição é obrigatória!");

            try
            {
                if (grupo.Cod_Grupo == 0)
                {
                    grupo.Cod_Empresa = DadosStaticos.IdEmpresa;
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    grupo.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioGrupo.Insert(ref grupo);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    grupo.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioGrupo.Update(grupo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return grupo.Cod_Grupo;
        }
    }
}
