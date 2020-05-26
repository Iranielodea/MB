using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmVendedor : Comercial.BaseUI.Base.frmPadrao
    {
        private Vendedor _vendedor;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmVendedor()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmVendedor(String descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            Grade.Configurar(ref dgvDados);
            cbCampos.DataSource = Grade.ListarCampos(ref dgvDados);
            cbCampos.SelectedIndex = 1;
            Carregar(descricao);

            btnSair.Left = btnFiltro.Left;
            btnFiltro.Visible = false;
        }

        private void Carregar(string valor)
        {
            string campos = cbCampos.Text;
            string campo = Grade.BuscarCampo(ref dgvDados, cbCampos.Text);
            dgvDados.DataSource = _unitOfWork.ServicoVendedor.Filtrar(campo, valor, DadosStaticos.IdEmpresa).ToList();
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _vendedor = new Vendedor();
            VincularDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _vendedor = new Vendedor();
                _vendedor = _unitOfWork.ServicoVendedor.ObterPorId(id);
                VincularDados();
                txtDescricao.Focus();
            }
        }

        public override void Excluir()
        {
            if (dgvDados.RowCount > 0)
            {
                if (Funcoes.Confirmar("Confirmar Exclusão?"))
                {
                    try
                    {
                        base.Excluir();
                        var vendedor = _unitOfWork.ServicoVendedor.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (vendedor != null)
                        {
                            _unitOfWork.ServicoVendedor.Excluir(vendedor, DadosStaticos.NomeUsuario);
                            Carregar(txtTexto.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public override void Salvar()
        {
            try
            {
                int id = 0;
                id = _unitOfWork.ServicoVendedor.Salvar(_vendedor, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoVendedor.Filtrar("", "", 0, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _vendedor, "Cod_Vendedor");
            Funcoes.Binding(ref txtDescricao, _vendedor, "Nome");
            Funcoes.Binding(ref txtUsuarioAlterou, _vendedor, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _vendedor, "Usu_Inc");
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
        }

        protected override void OnShown(EventArgs e)
        {
            if (_pesquisa && dgvDados.RowCount > 0)
                dgvDados.Focus();
            else
                base.OnShown(e);

        }

        private void dgvDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (_pesquisa && dgvDados.RowCount > 0)
                {
                    DadosStaticos.IdSelecionado = Grade.RetornarId(ref dgvDados, "Codigo");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void frmVendedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
