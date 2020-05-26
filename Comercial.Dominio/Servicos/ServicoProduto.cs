using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Data;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoProduto : ServicoBase<Produto>, IServicoProduto
    {
        private readonly string _tabela;
        private readonly IRepositorioProduto _repositorioProduto;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioProdutoConsulta _repositorioProdutoConsulta;

        public ServicoProduto(IRepositorioProduto repositorioProduto,
            IRepositorioProdutoConsulta repositorioProdutoConsulta, IServicoPermissao servicoPermissao)
            :base(repositorioProduto)
        {
            _repositorioProduto = repositorioProduto;
            _repositorioProdutoConsulta = repositorioProdutoConsulta;
            _servicoPermissao = servicoPermissao;
            _tabela = "PRODUTO";
        }

        public Produto ObterPorId(int id)
        {
            return _repositorioProduto.GetById(id);
        }

        public void Excluir(Produto produto, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioProduto.Delete(produto);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Produto produto, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(produto.Desc_Produto))
                throw new Exception("A Descrição é obrigatório!");
            if (produto.Id_Unidade == 0)
                throw new Exception("A unidade é obrigatório!");

            try
            {
                if (produto.Cod_Produto == 0)
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    produto.Cod_Empresa = DadosStaticos.IdEmpresa;
                    produto.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioProduto.Insert(ref produto);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    produto.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioProduto.Update(produto);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return produto.Cod_Produto;
        }

        public IEnumerable<ProdutoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioProdutoConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
