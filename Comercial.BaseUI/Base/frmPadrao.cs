using System.Windows.Forms;

namespace Comercial.BaseUI.Base
{
    public partial class frmPadrao : Form
    {
        int _campo;
        public frmPadrao()
        {
            InitializeComponent();

            btnSair.Click += (s, e) => Sair();
            btnNovo.Click += (s, e) => Novo();
            btnEditar.Click += (s, e) => Editar();
            btnExcluir.Click += (s, e) => Excluir();
            btnSalvar.Click += (s, e) => Salvar();
            btnVoltar.Click += (s, e) => Voltar();
            btnVoltar2.Click += (s, e) => Voltar();
            btnImprimir.Click += (s, e) => Imprimir();
            btnFiltrar.Click += (s, e) => Filtrar();
            btnFiltro.Click += (s, e) => Filtro();
            btnPesquisar.Click += (s, e) => Pesquisar();
        }

        public virtual void Pesquisar()
        {
            if (tabControl1.SelectedTab == tpPesquisa)
                Close();
        }
        public virtual void Sair()
        {
            this.Close();
        }

        public virtual void Novo()
        {
            if (tabControl1.SelectedTab == tpPesquisa)
                TelaEdicao();
        }

        public virtual void Editar()
        {
            if (tabControl1.SelectedTab == tpPesquisa)
                TelaEdicao();
        }

        public virtual void Salvar()
        {
            if (tabControl1.SelectedTab == tpEditar)
            {
                TelaPesquisa();
                cbCampos.SelectedIndex = _campo;
                
                txtTexto.Focus();
            }
        }

        public virtual void Voltar()
        {
            TelaPesquisa();
            txtTexto.Focus();
        }

        public virtual void Filtrar()
        {
            if (tabControl1.SelectedTab == tpFiltro)
                TelaPesquisa();
        }

        public virtual void Filtro()
        {
            if (tabControl1.SelectedTab == tpPesquisa)
                TelaFiltro();
        }

        public virtual void Excluir()
        {
            //using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
            //{
            //    var lista = unitOfWork.ServicoGrupo.Filtrar("desc_grupo", "", 1).ToList();
            //    dataGridView1.DataSource = lista;
            //}
        }

        public virtual void Imprimir()
        {

        }

        private void TelaEdicao()
        {
            tabControl1.TabPages.Remove(tpPesquisa);
            tabControl1.TabPages.Add(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);
            tabControl2.SelectedIndex = 0;
        }

        private void TelaPesquisa()
        {
            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Add(tpPesquisa);
            tabControl1.TabPages.Remove(tpFiltro);
            cbCampos.SelectedIndex = _campo;
        }

        private void TelaFiltro()
        {
            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpPesquisa);
            tabControl1.TabPages.Add(tpFiltro);
        }

        private void frmBase_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    if (tabControl1.SelectedTab == tpPesquisa)
                        Novo();
                    break;
                case Keys.F2:
                    if (tabControl1.SelectedTab == tpPesquisa)
                        Editar();
                    break;
                case Keys.F3:
                    if (tabControl1.SelectedTab == tpPesquisa)
                        Excluir();
                    break;
                case Keys.F4:
                    if (tabControl1.SelectedTab == tpPesquisa)
                        Filtro();
                    break;
                case Keys.F8:
                    if (tabControl1.SelectedTab == tpEditar)
                    {
                        if (btnSalvar.Enabled)
                            Salvar();
                    }
                    break;
                case Keys.F12:
                    if (btnPesquisar.Visible)
                        Pesquisar();
                    break;
                case Keys.Escape:
                    if (tabControl1.SelectedTab == tpPesquisa)
                    {
                        if (txtTexto.Focused)
                            Sair();
                        else
                            txtTexto.Focus();
                    }

                    if (tpEditar.Focus() || tpFiltro.Focus())
                    {
                        Voltar();
                    }
                    break;
            }
        }

        private void frmPadrao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmPadrao_Shown(object sender, System.EventArgs e)
        {
            
            txtTexto.Focus();
        }

        private void txtTexto_Enter(object sender, System.EventArgs e)
        {
            txtTexto.SelectAll();
        }

        private void cbCampos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _campo = cbCampos.SelectedIndex;
        }
    }
}
