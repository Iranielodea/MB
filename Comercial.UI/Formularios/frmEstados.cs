using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmEstados : Comercial.BaseUI.Base.frmPadrao
    {
        private Estado _estado;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmEstados()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmEstados(string descricao)
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
            dgvDados.DataSource = _unitOfWork.ServicoEstado.Filtrar(campo, valor, DadosStaticos.IdEmpresa).ToList();
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _estado = new Estado();
            txtICMS.txtValor.Text = "0,00";
            VincularDados();
            txtNome.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _estado = new Estado();
                _estado = _unitOfWork.ServicoEstado.ObterPorId(id);
                VincularDados();
                txtNome.Focus();
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
                        var estado = _unitOfWork.ServicoEstado.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (estado != null)
                        {
                            _unitOfWork.ServicoEstado.Excluir(estado, DadosStaticos.NomeUsuario);
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
                _estado.ICMS = decimal.Parse(txtICMS.txtValor.Text);
                id = _unitOfWork.ServicoEstado.Salvar(_estado, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoEstado.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados(bool salvar = false)
        {
            Funcoes.Binding(ref txtCodigo, _estado, "Id_Estado");
            Funcoes.Binding(ref txtNome, _estado, "Desc_Estado");
            Funcoes.Binding(ref txtSigla, _estado, "Sigla");
            //Funcoes.Binding(ref txtICMS.txtValor, _estado, "ICMS");
            Funcoes.Binding(ref txtUsuarioAlterou, _estado, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _estado, "Usu_Inc");

            //txtICMS.txtValor.DataBindings.Clear();
            //txtICMS.txtValor.DataBindings.Add("Text", _estado, "ICMS", false, DataSourceUpdateMode.OnPropertyChanged);
            txtICMS.txtValor.Text = _estado.ICMS.ToString("n2"); //Funcoes.FormatStrDecimal("N2", txtICMS.txtValor.Text);            
        }

        protected override void OnShown(EventArgs e)
        {
            if (_pesquisa && dgvDados.RowCount > 0)
                dgvDados.Focus();
            else
                base.OnShown(e);

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

        private void frmEstados_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
