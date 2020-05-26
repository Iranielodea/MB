using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmEmpresa : Comercial.BaseUI.Base.frmPadrao
    {
        private Empresa _empresa;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmEmpresa()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmEmpresa(string descricao)
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
            dgvDados.DataSource = _unitOfWork.ServicoEmpresa.Filtrar(campo, valor, DadosStaticos.IdEmpresa);
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _empresa = new Empresa();
            Funcoes.LimparTela(tbPrincipal);
            VincularDados();
            txtNome.Focus();
        }

        public override void Editar()
        {
            _empresa = new Empresa();
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                Funcoes.LimparTela(tbPrincipal);
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _empresa = _unitOfWork.ServicoEmpresa.ObterPorId(id);
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
                        _unitOfWork.ServicoEmpresa.Excluir(Grade.RetornarId(ref dgvDados, "Codigo"), DadosStaticos.NomeUsuario);
                        Carregar(txtTexto.Text);
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
                _empresa.CNPJ = txtCNPJ.txtValor.Text;
                id = _unitOfWork.ServicoEmpresa.Salvar(_empresa, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoEmpresa.Filtrar("", "", id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados(bool salvar = false)
        {
            txtCNPJ.txtValor.Text = _empresa.CNPJ;
            Funcoes.Binding(ref txtCodigo, _empresa, "Cod_Empresa");
            Funcoes.Binding(ref txtNome, _empresa, "Nome");
            Funcoes.Binding(ref txtVersao, _empresa, "Versao");
            Funcoes.Binding(ref txtEndereco, _empresa, "Endereco");
            Funcoes.Binding(ref txtBairro, _empresa, "Bairro");
            Funcoes.Binding(ref txtNumero, _empresa, "Numero");
            Funcoes.Binding(ref txtCidade, _empresa, "Desc_Cidade");
            Funcoes.BindingMask(ref txtCep, _empresa, "Cep");
            Funcoes.Binding(ref txtEstado, _empresa, "Estado");
            Funcoes.Binding(ref txtFone, _empresa, "Fone");
            Funcoes.Binding(ref txtFax, _empresa, "Fax");
            Funcoes.Binding(ref txtEmail, _empresa, "Email");
            Funcoes.Binding(ref txtInscricao, _empresa, "Insc_Estadual");

            Funcoes.Binding(ref txtUsuarioAlterou, _empresa, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _empresa, "Usu_Inc");
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

        private void frmEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
