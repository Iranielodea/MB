using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Data;

namespace Comercial.Dominio.Servicos
{
    public class ServicoFornecedorTipoEmpresa : ServicoBase<FornecedorTipoEmpresa>, IServicoFornecedorTipoEmpresa
    {
        private readonly IRepositorioFornecedorTipoEmpresa _repositorioFornecedorTipoEmpresa;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioFornecedorTipoEmpresaConsulta _repositorioFornecedorTipoEmpresaConsulta;

        public ServicoFornecedorTipoEmpresa(IRepositorioFornecedorTipoEmpresa repositorioFornecedorTipoEmpresa,
            IRepositorioFornecedorTipoEmpresaConsulta repositorioFornecedorTipoEmpresaConsulta, IServicoPermissao servicoPermissao)
            :base(repositorioFornecedorTipoEmpresa)
        {
            _repositorioFornecedorTipoEmpresa = repositorioFornecedorTipoEmpresa;
            _repositorioFornecedorTipoEmpresaConsulta = repositorioFornecedorTipoEmpresaConsulta;
            _servicoPermissao = servicoPermissao;
        }

        public FornecedorTipoEmpresa ObterPorId(int id)
        {
            return _repositorioFornecedorTipoEmpresa.GetById(id);
        }

        public void Excluir(FornecedorTipoEmpresa fornecedorTipoEmpresa, string nomeUsuario)
        {
            try
            {
                _repositorioFornecedorTipoEmpresa.Delete(fornecedorTipoEmpresa);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(FornecedorTipoEmpresa fornecedorTipoEmpresa, string nomeUsuario)
        {
            if (string.IsNullOrWhiteSpace(fornecedorTipoEmpresa.Desc_Tipo))
                throw new Exception("A Descrição é obrigatória!");

            if (string.IsNullOrWhiteSpace(fornecedorTipoEmpresa.Sigla))
                throw new Exception("A Sigla é obrigatória!");

            try
            {
                if (fornecedorTipoEmpresa.Id_Tipo == 0)
                {
                    fornecedorTipoEmpresa.Cod_Empresa = DadosStaticos.IdEmpresa;
                    fornecedorTipoEmpresa.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioFornecedorTipoEmpresa.Insert(ref fornecedorTipoEmpresa);
                }
                else
                {
                    fornecedorTipoEmpresa.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioFornecedorTipoEmpresa.Update(fornecedorTipoEmpresa);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fornecedorTipoEmpresa.Id_Tipo;
        }

        public IEnumerable<FornecedorTipoEmpresaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioFornecedorTipoEmpresaConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
