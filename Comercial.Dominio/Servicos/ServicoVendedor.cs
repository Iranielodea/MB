using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoVendedor : ServicoBase<Vendedor>, IServicoVendedor
    {
        private readonly string _tabela;
        private readonly IRepositorioVendedor _repositorioVendedor;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioVendedorConsulta _repositorioVendedorConsulta;

        public ServicoVendedor(IRepositorioVendedor repositorioVendedor,
            IRepositorioVendedorConsulta repositorioVendedorConsulta, IServicoPermissao servicoPermissao) : base(repositorioVendedor)
        {
            _repositorioVendedor = repositorioVendedor;
            _repositorioVendedorConsulta = repositorioVendedorConsulta;
            _servicoPermissao = servicoPermissao;
            _tabela = "VENDEDOR";
        }

        public Vendedor ObterPorId(int id)
        {
            return _repositorioVendedor.GetById(id);
        }

        public void Excluir(Vendedor vendedor, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioVendedor.Delete(vendedor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Vendedor vendedor, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(vendedor.Nome))
                throw new Exception("O nome é obrigatório!");

            try
            {
                if (vendedor.Cod_Vendedor == 0)
                {
                    vendedor.Cod_Empresa = DadosStaticos.IdEmpresa;
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    vendedor.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioVendedor.Insert(ref vendedor);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    vendedor.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioVendedor.Update(vendedor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return vendedor.Cod_Vendedor;
        }

        public IEnumerable<VendedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioVendedorConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
