using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;

namespace Comercial.Dominio.Servicos
{
    public class ServicoObsConta : ServicoBase<ObsConta>, IServicoObsConta
    {
        IRepositorioObsConta _repositorioObsConta;

        public ServicoObsConta(IRepositorioObsConta repositorioObsConta)
            :base(repositorioObsConta)
        {
            _repositorioObsConta = repositorioObsConta;
        }

        public IEnumerable<ObsConta> ObterPorConta(int IdConta, int codEmpresa)
        {
            return _repositorioObsConta.ObterPorConta(IdConta, codEmpresa);
        }

        public ObsConta ObterPorId(int id)
        {
            return _repositorioObsConta.GetById(id);
        }

        public void Excluir(int id)
        {
            _repositorioObsConta.Delete(_repositorioObsConta.GetById(id));
        }

        public void Salvar(ObsConta obsConta)
        {
            if (string.IsNullOrWhiteSpace(obsConta.Texto))
                throw new Exception("Informe o Texto!");

            if (obsConta.Id_Obs == 0)
                _repositorioObsConta.Insert(ref obsConta);
            else
                _repositorioObsConta.Update(obsConta);
        }

        public void ExcluirObsDaConta(int codEmpresa, int idConta)
        {
            var lista = ObterPorConta(idConta, codEmpresa);
            foreach (var item in lista)
            {
                _repositorioObsConta.Delete(item);
            }
        }
    }
}
