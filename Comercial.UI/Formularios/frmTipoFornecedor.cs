using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmTipoFornecedor : BaseUI.Base.frmPadrao
    {
        private bool _pesquisa;
        private FornecedorTipoEmpresa _fornecedorTipoEmpresa;
        private IUnitOfWork _unitOfWork;

        public frmTipoFornecedor()
        {
            Iniciar("abcde");
        }

        public frmTipoFornecedor(string descricao)
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

        private void Carregar(string valor, int id = 0)
        {
            string campos = cbCampos.Text;
            string campo = Grade.BuscarCampo(ref dgvDados, cbCampos.Text);
            dgvDados.DataSource = _unitOfWork.ServicoFornecedorTipoEmpresa.Filtrar(campo, valor, DadosStaticos.IdEmpresa).ToList();
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _fornecedorTipoEmpresa = new FornecedorTipoEmpresa();
            VinclusarDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _fornecedorTipoEmpresa = new FornecedorTipoEmpresa();
                _fornecedorTipoEmpresa = _unitOfWork.ServicoFornecedorTipoEmpresa.ObterPorId(id);
                VinclusarDados();
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
                        var tipoFornecedor = _unitOfWork.ServicoFornecedorTipoEmpresa.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (tipoFornecedor != null)
                        {
                            _unitOfWork.ServicoFornecedorTipoEmpresa.Excluir(tipoFornecedor, DadosStaticos.NomeUsuario);
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
                id = _unitOfWork.ServicoFornecedorTipoEmpresa.Salvar(_fornecedorTipoEmpresa, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoFornecedorTipoEmpresa.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            if (_pesquisa && dgvDados.RowCount > 0)
                dgvDados.Focus();
            else
                base.OnShown(e);

        }

        private void VinclusarDados()
        {
            Funcoes.Binding(ref txtCodigo, _fornecedorTipoEmpresa, "Id_Tipo");
            Funcoes.Binding(ref txtDescricao, _fornecedorTipoEmpresa, "Desc_Tipo");
            Funcoes.Binding(ref txtSigla, _fornecedorTipoEmpresa, "Sigla");
            Funcoes.Binding(ref txtUsuarioAlterou, _fornecedorTipoEmpresa, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _fornecedorTipoEmpresa, "Usu_Inc");
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
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

        private void frmTipoFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
