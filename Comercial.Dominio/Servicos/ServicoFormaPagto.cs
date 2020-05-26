using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoFormaPagto : ServicoBase<FormaPagto>, IServicoFormaPagto
    {
        private readonly string _tabela;
        private readonly IRepositorioFormaPagto _repositorioFormaPagto;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioFormaPagtoConsulta _repositorioFormaPagtoConsulta;

        public ServicoFormaPagto(IRepositorioFormaPagto repositorioFormaPagto,
            IRepositorioFormaPagtoConsulta repositorioFormaPagtoConsulta, IServicoPermissao servicoPermissao)
            :base(repositorioFormaPagto)
        {
            _repositorioFormaPagto = repositorioFormaPagto;
            _repositorioFormaPagtoConsulta = repositorioFormaPagtoConsulta;
            _servicoPermissao = servicoPermissao;
            _tabela = "FORMA_PAGTO";
        }

        public FormaPagto ObterPorId(int id)
        {
            return _repositorioFormaPagto.GetById(id);
        }

        public void Excluir(FormaPagto formaPagto, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioFormaPagto.Delete(formaPagto);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(FormaPagto formaPagto, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(formaPagto.Desc_Pagto))
                throw new Exception("A Descrição é obrigatória!");
            if (string.IsNullOrWhiteSpace(formaPagto.Sigla))
                throw new Exception("A Abreviatura é obrigatória!");

            try
            {
                if (formaPagto.Cod_Pagto == 0)
                {
                    formaPagto.Cod_Empresa = DadosStaticos.IdEmpresa;
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    formaPagto.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioFormaPagto.Insert(ref formaPagto);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    formaPagto.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioFormaPagto.Update(formaPagto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return formaPagto.Cod_Pagto;
        }

        public IEnumerable<FormaPagtoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioFormaPagtoConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
