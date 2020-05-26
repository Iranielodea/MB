using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoUsuario : ServicoBase<Usuario>, IServicoUsuario
    {
        private readonly string _tabela;
        private readonly IRepositorioUsuario _repositorioUsuario;
        private readonly IRepositorioUsuarioConsulta _repositorioUsuarioConsulta;
        private readonly IServicoPermissao _servicoPermissao;

        public ServicoUsuario(IRepositorioUsuario repositorioUsuario,
            IRepositorioUsuarioConsulta repositorioUsuarioConsulta, IServicoPermissao servicoPermissao)
            :base(repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
            _repositorioUsuarioConsulta = repositorioUsuarioConsulta;
            _servicoPermissao = servicoPermissao;
            _tabela = "CAD_USUARIO";
        }
        
        public Usuario ObterPorId(int id)
        {
            return _repositorioUsuario.GetById(id);
        }

        public IEnumerable<UsuarioConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioUsuarioConsulta.Filtrar(campo, valor, codEmpresa, id);
        }

        public int Salvar(Usuario usuario, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(usuario.Nome))
                throw new Exception("O nome é obrigatório!");
            if (string.IsNullOrWhiteSpace(usuario.Senha))
                throw new Exception("A senha é obrigatório!");

            try
            {
                if (usuario.Id_Usuario == 0)
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    usuario.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioUsuario.Insert(ref usuario);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    usuario.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioUsuario.Update(usuario);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return usuario.Id_Usuario;
        }

        public Usuario ObterPorUsuarioSenha(string usuario, string senha, int codEmpresa)
        {
            return _repositorioUsuario.First(x => x.Cod_Empresa == codEmpresa && x.Nome == usuario && x.Senha == senha);
        }

        public void Excluir(Usuario usuario, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioUsuario.Delete(usuario);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
