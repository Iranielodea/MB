using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial.BaseUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControle.TabPages.Remove(tpEditar);
            tabControle.TabPages.Remove(tpFiltrar);
        }

        private void TelaEditar()
        {
            tabControle.TabPages.Add(tpEditar);
            tabControle.TabPages.Remove(tpPesquisar);
            tabControle.TabPages.Remove(tpFiltrar);
        }

        private void TelaPesquisar()
        {
            tabControle.TabPages.Remove(tpEditar);
            tabControle.TabPages.Add(tpPesquisar);
            tabControle.TabPages.Remove(tpFiltrar);
        }

        private void TelaFiltrar()
        {
            tabControle.TabPages.Remove(tpEditar);
            tabControle.TabPages.Remove(tpPesquisar);
            tabControle.TabPages.Add(tpFiltrar);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        protected void Novo()
        {
            TelaEditar();
        }

        protected void Editar()
        {
            TelaEditar();
        }

        protected void Salvar()
        {
            TelaPesquisar();
        }

        protected void Cancelar()
        {
            TelaPesquisar();
        }

        protected void Filtrar()
        {
            TelaFiltrar();
        }

        protected void VoltarFilto()
        {
            TelaPesquisar();
        }

        protected void AplicarFiltro()
        {
            TelaPesquisar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            TelaFiltrar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TelaPesquisar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPesquisar();
        }
    }
}
