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
    public class ConsultaUnidade
    {
        public Unidade Pesquisar(int id, string descricao, int codEmpresa, TipoPesquisaGeral tipoPesquisa)
        {
            if (id == 0 && tipoPesquisa == TipoPesquisaGeral.pgId)
                return null;

            if (string.IsNullOrEmpty(descricao) && tipoPesquisa == TipoPesquisaGeral.pgDescricao)
                return null;

            if (tipoPesquisa == TipoPesquisaGeral.pgTela)
            {
                frmUnidade formulario = new frmUnidade("");
                if (formulario.ShowDialog() == DialogResult.OK)
                {
                    if (DadosStaticos.IdSelecionado == 0)
                        return null;

                    using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
                    {
                        return unitOfWork.ServicoUnidade.ObterPorId(DadosStaticos.IdSelecionado);
                    }
                }
            }

            if (tipoPesquisa == TipoPesquisaGeral.pgId && id > 0)
            {
                using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
                {
                    var model = unitOfWork.ServicoUnidade.ObterPorId(id);
                    if (model == null)
                        throw new Exception("Registro não encontrado!");
                    return model;
                }
            }

            if (tipoPesquisa == TipoPesquisaGeral.pgDescricao && descricao.Length > 0)
            {
                using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
                {
                    var model = unitOfWork.ServicoUnidade.Filtrar("SIGLA", descricao, codEmpresa);
                    if (model == null)
                    {
                        frmUnidade formulario = new frmUnidade();
                        if (formulario.ShowDialog() == DialogResult.OK)
                        {
                            return unitOfWork.ServicoUnidade.ObterPorId(DadosStaticos.IdSelecionado);
                        }
                        return null;
                    }
                    else
                    {
                        if (model.Count() == 1)
                            return unitOfWork.ServicoUnidade.ObterPorId(model.First().Id_Unidade);
                        else
                        {
                            frmUnidade formulario = new frmUnidade(descricao);
                            if (formulario.ShowDialog() == DialogResult.OK)
                            {
                                return unitOfWork.ServicoUnidade.ObterPorId(DadosStaticos.IdSelecionado);
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
