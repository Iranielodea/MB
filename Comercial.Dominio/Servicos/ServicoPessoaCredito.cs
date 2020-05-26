using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;

namespace Comercial.Dominio.Servicos
{
    public class ServicoPessoaCredito : ServicoBase<PessoaCredito>, IServicoPessoaCredito
    {
        private readonly IRepositorioPessoaCredito _repositorioPessoaCredito;

        public ServicoPessoaCredito(IRepositorioPessoaCredito repositorioPessoaCredito)
            :base(repositorioPessoaCredito)
        {
            _repositorioPessoaCredito = repositorioPessoaCredito;
        }

        public void Atualizar(PessoaCredito pessoaCredito)
        {
            _repositorioPessoaCredito.Atualizar(pessoaCredito);
        }

        public PessoaCredito ObterPorId(int id)
        {
            return _repositorioPessoaCredito.ObterPorCodigo(id);
        }

        public void Salvar(PessoaCredito pessoaCredito)
        {
            try
            {
                if (pessoaCredito.Cod_Cliente == 0)
                {
                    if (pessoaCredito.Qtde_Credito > 0)
                        _repositorioPessoaCredito.Insert(ref pessoaCredito);
                }
                else
                {
                    var credito = _repositorioPessoaCredito.ObterPorCodigo(pessoaCredito.Cod_Cliente);
                    if (credito == null)
                    {
                        _repositorioPessoaCredito.Insert(ref pessoaCredito);
                    }
                    else
                    {
                        _repositorioPessoaCredito.Atualizar(pessoaCredito);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
