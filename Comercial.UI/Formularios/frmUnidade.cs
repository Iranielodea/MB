using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using Comercial.UI.Consultas;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.UI.Formularios
{
    public partial class frmUnidade : Comercial.BaseUI.Base.frmPadrao
    {
        private Unidade _unidade;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmUnidade()
        {
            _pesquisa = false;
            Iniciar("abcde");
        }

        public frmUnidade(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrUnidadeTexto.Programa(EnumProgramas.UnidadeTexto);

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
            dgvDados.DataSource = _unitOfWork.ServicoUnidade.Filtrar(campo, valor, DadosStaticos.IdEmpresa).ToList();
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _unidade = new Unidade();
            VincularDados();
            txtFator.txtValor.Text = "1,0000";
            UsrUnidadeTexto.txtId.Clear();
            UsrUnidadeTexto.txtNome.Clear();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _unidade = new Unidade();
                _unidade = _unitOfWork.ServicoUnidade.ObterPorId(id);
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
                        var unidade = _unitOfWork.ServicoUnidade.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (unidade != null)
                        {
                            _unitOfWork.ServicoUnidade.Excluir(unidade, DadosStaticos.NomeUsuario);
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
                _unidade.Cod_Empresa = DadosStaticos.IdEmpresa;
                _unidade.Id_Texto = Funcoes.StrToIntNull(UsrUnidadeTexto.txtId.Text);
                _unidade.Fator_Conversao = decimal.Parse(txtFator.txtValor.Text);
                id = _unitOfWork.ServicoUnidade.Salvar(_unidade, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoUnidade.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados(bool salvar = false)
        {
            Funcoes.Binding(ref txtCodigo, _unidade, "Id_Unidade");
            Funcoes.Binding(ref txtDescricao, _unidade, "Desc_Unidade");
            Funcoes.Binding(ref txtSigla, _unidade, "Sigla");
            Funcoes.Binding(ref txtComplemento, _unidade, "Compl_Unidade");
            Funcoes.Binding(ref txtUsuarioAlterou, _unidade, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _unidade, "Usu_Inc");

            txtFator.txtValor.Text = _unidade.Fator_Conversao.ToString("n4"); //Funcoes.FormatStrDecimal("N2", txtICMS.txtValor.Text);            

            UsrUnidadeTexto.txtId.Text = Funcoes.StrToStrNull(_unidade.Id_Texto.ToString());
            if (_unidade.UnidadeTexto != null)
                UsrUnidadeTexto.txtNome.Text = _unidade.UnidadeTexto.Observacao;
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

        private void frmUnidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
