using CrossPlataforma;
using System;
using System.Windows.Forms;
using Comercial.UI.Formularios;
using Comercial.UI.Comum;
using Comercial.Dominio.Entidades;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.UI
{
    public partial class frmMenu : Form
    {
       // private List<Permissao> _permissoes;

        public frmMenu()
        {
            InitializeComponent();
            BootStrapper.ConfigureStructerMap();
            RegisterMappings.Register();

            Carregar();
        }

        private void Carregar()
        {
            DadosStaticos.IdEmpresa = 1;
            DadosStaticos.NomeUsuario = "MOACIR";
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmGrupo();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
            //formulario.Show();
        }

        private void tiposDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmTipoFornecedor();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmVendedor();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmEstados();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void formasDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmFormaPagto();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void textoParaUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmTextoUnidade();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void contasBancáriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmContaBanco();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmCidade();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmUnidade();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmProduto();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmEmpresa();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void tabelaDeCódigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmTabCodigo();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void transportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmTransportadora();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void motoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmMotorista();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFornecedor();
        }

        private void AbrirFornecedor()
        {
            var formulario = new frmFornecedor();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFornecedor();
        }

        private void AbrirCliente()
        {
            var formulario = new frmCliente();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirCliente();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmContas(TipoFinanceiro.tfReceber);
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulario = new frmContas(TipoFinanceiro.tfPagar);
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            var formulario = new frmPedido();
            formulario.MdiParent = this;
            Funcoes.AbrirTela(formulario);
        }
    }
}
