using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmCidade : Comercial.BaseUI.Base.frmPadrao
    {
        private Cidade _cidade;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmCidade()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmCidade(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrEstado.Programa(EnumProgramas.Estado);

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
            int idxCampo = cbCampos.SelectedIndex;
            string campo = Grade.BuscarCampo(ref dgvDados, cbCampos.Text);
            dgvDados.DataSource = _unitOfWork.ServicoCidade.Filtrar(campo, valor, DadosStaticos.IdEmpresa);
            cbCampos.SelectedIndex = idxCampo;
        }

        public override void Novo()
        {
            base.Novo();
            _cidade = new Cidade();
            UsrEstado.txtId.Clear();
            UsrEstado.txtNome.Clear();
            VincularDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _cidade = new Cidade();
                _cidade = _unitOfWork.ServicoCidade.ObterPorId(id);

                UsrEstado.txtId.Text = _cidade.Id_Estado.ToString();
                UsrEstado.txtNome.Text = _cidade.Estado.Desc_Estado;

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
                        var cidade = _unitOfWork.ServicoCidade.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (cidade != null)
                        {
                            _unitOfWork.ServicoCidade.Excluir(cidade, DadosStaticos.NomeUsuario);
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
                _cidade.Id_Estado = Funcoes.StrToInt(UsrEstado.txtId.Text);
                if (_cidade.Id_Estado == 0)
                    throw new Exception("O estado é obrigatório!");

                
                id = _unitOfWork.ServicoCidade.Salvar(_cidade, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoCidade.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados(bool salvar = false)
        {
            Funcoes.Binding(ref txtCodigo, _cidade, "Cod_Cidade");
            Funcoes.Binding(ref txtDescricao, _cidade, "Desc_Cidade");
            Funcoes.BindingMask(ref txtCEP, _cidade, "CEP");
            //Funcoes.Binding(ref txtIdEstado, _cidade, "Id_Estado");
            Funcoes.Binding(ref txtUsuarioAlterou, _cidade, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _cidade, "Usu_Inc");

            


            //txtICMS.txtValor.DataBindings.Clear();
            //txtICMS.txtValor.DataBindings.Add("Text", _cidade, "ICMS", false, DataSourceUpdateMode.OnPropertyChanged);
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

        private void frmCidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
