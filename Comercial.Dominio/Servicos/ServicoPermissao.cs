using Comercial.Dominio.Constantes;
using Comercial.Dominio.Entidades;
using Comercial.Dominio.Enumeradores;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoPermissao : ServicoBase<Permissao>, IServicoPermissao
    {
        private readonly IRepositorioPermissao _repositorioPermissao;
        private readonly IRepositorioPermissaoConsulta _repositorioPermissaoConsulta;

        public ServicoPermissao(IRepositorioPermissao repositorioPermissao,
            IRepositorioPermissaoConsulta repositorioPermissaoConsulta) : base(repositorioPermissao)
        {
            _repositorioPermissao = repositorioPermissao;
            _repositorioPermissaoConsulta = repositorioPermissaoConsulta;
        }

        public void Excluir(Permissao permissao)
        {
            _repositorioPermissao.Delete(permissao);
        }

        public IEnumerable<PermissaoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioPermissaoConsulta.Filtrar(campo, valor, codEmpresa, id);
        }

        public Permissao ObterPorId(int id)
        {
            return _repositorioPermissao.GetById(id);
        }

        public IEnumerable<Permissao> ObterPorUsuario(string nomeUsuario, int codEmpresa)
        {
            return _repositorioPermissao.GetList(x => x.Cod_Empresa == codEmpresa && x.Nome == nomeUsuario);
        }

        public void Permitir(Enumerador.AcaoUsuario enumerador, string tabela, string nomeUsuario)
        {
            var model = _repositorioPermissao.Permitir(tabela, nomeUsuario);

            if (model == null)
                throw new Exception("Usuário não encontrado");

            if (enumerador == AcaoUsuario.Consultar)
            {
                if (model.Con == "N")
                    throw new Exception(MensagensPadrao.UsuarioSemPermissao);
            }

            if (enumerador == AcaoUsuario.Incluir)
            {
                if (model.Inc == "N")
                    throw new Exception(MensagensPadrao.UsuarioSemPermissao);
            }

            if (enumerador == AcaoUsuario.Alterar)
            {
                if (model.Alt == "N")
                    throw new Exception(MensagensPadrao.UsuarioSemPermissao);
            }

            if (enumerador == AcaoUsuario.Excluir)
            {
                if (model.Exc == "N")
                    throw new Exception(MensagensPadrao.UsuarioSemPermissao);
            }
        }

        public IEnumerable<Permissao> RetornarListaPermissoesUsuario(string tabela, string nomeUsuario)
        {
            return _repositorioPermissao.GetList(x => x.Tabela == tabela && x.Nome == nomeUsuario);
        }

        public int Salvar(Permissao permissao, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(permissao.Nome))
                throw new Exception("O nome é obrigatório!");
            if (string.IsNullOrWhiteSpace(permissao.Tabela))
                throw new Exception("A tabela é obrigatória!");

            try
            {
                if (permissao.Id_Per == 0)
                {
                    permissao.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioPermissao.Insert(ref permissao);
                }
                else
                {
                    permissao.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioPermissao.Update(permissao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return permissao.Id_Per;
        }

        public bool UsuarioPermissaoAcesso(string tabela, string nomeUsuario)
        {
            var model = _repositorioPermissao.First(x => x.Tabela == tabela && x.Nome == nomeUsuario);
            return model.Con == "S";
        }
    }
}
