using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Formularios;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.UI.Consultas
{
    public class ConsultaContaBancaria
    {
        public ContaBanco Pesquisar(int id, string descricao, int codEmpresa, TipoPesquisaGeral tipoPesquisa)
        {
            if (id == 0 && tipoPesquisa == TipoPesquisaGeral.pgId)
                return null;

            if (string.IsNullOrEmpty(descricao) && tipoPesquisa == TipoPesquisaGeral.pgDescricao)
                return null;

            if (tipoPesquisa == TipoPesquisaGeral.pgTela)
            {
                frmContaBanco formulario = new frmContaBanco("");
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    if (DadosStaticos.IdSelecionado == 0)
                        return null;

                    using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
                    {
                        return unitOfWork.ServicoContaBanco.ObterPorId(DadosStaticos.IdSelecionado);
                    }
                }
            }

            if (tipoPesquisa == TipoPesquisaGeral.pgId && id > 0)
            {
                using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
                {
                    var model = unitOfWork.ServicoContaBanco.ObterPorId(id);
                    if (model == null)
                        throw new Exception("Registro não encontrado!");
                    return model;
                }
            }

            if (tipoPesquisa == TipoPesquisaGeral.pgDescricao && descricao.Length > 0)
            {
                using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
                {
                    var model = unitOfWork.ServicoContaBanco.Filtrar("NUM_CONTA", descricao, codEmpresa);
                    if (model == null)
                    {
                        frmContaBanco formulario = new frmContaBanco(descricao);
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            return unitOfWork.ServicoContaBanco.ObterPorId(DadosStaticos.IdSelecionado);
                        }
                        return null;
                    }
                    else
                    {
                        if (model.Count() == 1)
                            return unitOfWork.ServicoContaBanco.ObterPorId(model.First().Id_ContaBanco);
                        else
                        {
                            frmContaBanco formulario = new frmContaBanco(descricao);
                            if (formulario.ShowDialog() == DialogResult.OK)
                            {
                                return unitOfWork.ServicoContaBanco.ObterPorId(DadosStaticos.IdSelecionado);
                            }
                        }
                        return null;
                    }
                }
            }
            else
                return null;
        }
    }
}
