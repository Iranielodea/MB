using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.Dominio.Servicos
{
    public class ServicoFornecedor : ServicoBase<Fornecedor>, IServicoFornecedor
    {
        private readonly string _tabela;
        private readonly IRepositorioFornecedor _repositorioFornecedor;
        private readonly IServicoPermissao _servicoPermissao;
        private readonly IRepositorioFornecedorConsulta _repositorioFornecedorConsulta;
        private readonly IRepositorioCidade _repositorioCidade;
        private readonly IRepositorioEstado _repositorioEstado;

        public ServicoFornecedor(IRepositorioFornecedor repositorioFornecedor,
            IRepositorioFornecedorConsulta repositorioFornecedorConsulta, IServicoPermissao servicoPermissao,
            IRepositorioCidade repositorioCidade, IRepositorioEstado repositorioEstado)
            : base(repositorioFornecedor)
        {
            _repositorioFornecedor = repositorioFornecedor;
            _repositorioFornecedorConsulta = repositorioFornecedorConsulta;
            _servicoPermissao = servicoPermissao;
            _repositorioCidade = repositorioCidade;
            _repositorioEstado = repositorioEstado;
            _tabela = "FORNECEDOR";
        }

        public Fornecedor ObterPorId(int id)
        {
            return _repositorioFornecedor.GetById(id);
        }

        public void Excluir(Fornecedor fornecedor, string nomeUsuario)
        {
            try
            {
                _servicoPermissao.Permitir(AcaoUsuario.Excluir, _tabela, nomeUsuario);
                _repositorioFornecedor.Delete(fornecedor);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public int Salvar(Fornecedor fornecedor, string nomeUsuario)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fornecedor.Nome))
                    throw new Exception("O Nome é obrigatório!");

                if (fornecedor.CNPJ != null)
                {
                    string documento = Dominio.Geral.Funcao.SomenteNumeros(fornecedor.CNPJ);
                    if (documento.Length > 0)
                    {
                        if (!Geral.Validacao.ValidarCnpj(documento))
                            throw new Exception("CNPJ inválido!");
                    }
                }

                if (fornecedor.CPF != null)
                {
                    string documento = Dominio.Geral.Funcao.SomenteNumeros(fornecedor.CPF);
                    if (documento.Length > 0)
                    {
                        if (!Geral.Validacao.ValidarCPF(documento))
                            throw new Exception("CPF inválido!");
                    }
                }

                if (!string.IsNullOrWhiteSpace(fornecedor.Insc_Estadual) && fornecedor.Cod_Cidade != null)
                {
                    fornecedor.Cidade = _repositorioCidade.GetById(fornecedor.Cod_Cidade.Value);
                    if (fornecedor.Cidade.Id_Estado > 0)
                    {
                        fornecedor.Cidade.Estado = _repositorioEstado.GetById(fornecedor.Cidade.Id_Estado);
                        if (!Geral.Validacao.ValidarIE(fornecedor.Insc_Estadual, fornecedor.Cidade.Estado.Sigla))
                            throw new Exception("Inscrição Estadual Inválida!");
                    }
                }

                if (fornecedor.Cod_For == 0)
                {
                    fornecedor.Cod_Empresa = DadosStaticos.IdEmpresa;
                    _servicoPermissao.Permitir(AcaoUsuario.Incluir, _tabela, nomeUsuario);
                    fornecedor.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioFornecedor.Insert(ref fornecedor);
                }
                else
                {
                    _servicoPermissao.Permitir(AcaoUsuario.Alterar, _tabela, nomeUsuario);
                    fornecedor.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioFornecedor.Update(fornecedor);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return fornecedor.Cod_For;
        }

        public IEnumerable<FornecedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            return _repositorioFornecedorConsulta.Filtrar(campo, valor, codEmpresa, id);
        }
    }
}
