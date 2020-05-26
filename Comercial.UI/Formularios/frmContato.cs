using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Windows.Forms;
using Comercial.Dominio.Enumeradores;

namespace Comercial.UI.Formularios
{
    public partial class frmContato : BaseUI.Base.frmPadrao
    {
        private Contato _contato;
        private Enumerador.EnContato _enContato;
        private int _codigo;
        private IUnitOfWork _unitOfWork;

        public frmContato(int codigo, Enumerador.EnContato enContato)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            Grade.Configurar(ref dgvDados);

            btnSair.Left = btnFiltro.Left;
            btnFiltro.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            cbCampos.Visible = false;
            txtTexto.Visible = false;

            _enContato = enContato;
            _codigo = codigo;
            Carregar(codigo, _unitOfWork);
            cbCampos.Items.Add("Codigo");
        }

        private void Carregar(int codigo, IUnitOfWork unitOfWork)
        {
            dgvDados.DataSource = unitOfWork.ServicoContato.ObterPorCodigo(DadosStaticos.IdEmpresa, codigo, _enContato);
        }

        public override void Novo()
        {
            base.Novo();
            _contato = new Contato();
            txtDataNasc.txtData.Clear();
            VincularDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                int seq = Grade.RetornarId(ref dgvDados, "Seq");
                _contato = new Contato();
                _contato = _unitOfWork.ServicoContato.ObterPorId(DadosStaticos.IdEmpresa, id, seq, _enContato);

                VincularDados();
                txtDataNasc.txtData.Text = _contato.DataNasc.ToString();
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
                        int id = Grade.RetornarId(ref dgvDados, "Codigo");
                        int seq = Grade.RetornarId(ref dgvDados, "Seq");

                        var contato = new Contato();
                        contato = _unitOfWork.ServicoContato.ObterPorId(DadosStaticos.IdEmpresa, id, seq, _enContato);

                        if (contato != null)
                        {
                            _unitOfWork.ServicoContato.Excluir(contato, DadosStaticos.NomeUsuario);
                            Carregar(id, _unitOfWork);
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
                _contato.DataNasc = Funcoes.StrToDateNull(txtDataNasc.txtData.Text);
                _contato.Codigo = _codigo;

                _unitOfWork.ServicoContato.Salvar(_contato, DadosStaticos.NomeUsuario, _enContato);
                Carregar(_contato.Codigo, _unitOfWork);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtEmail, _contato, "Email");
            Funcoes.Binding(ref txtDescricao, _contato, "ContatoTexto");
            Funcoes.Binding(ref txtFax, _contato, "Fax");
            Funcoes.Binding(ref txtTelefone, _contato, "Fone");

            Funcoes.Binding(ref txtUsuarioAlterou, _contato, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _contato, "Usu_Inc");
        }

        private void dgvDados_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Return)
            //{
            //    if (_pesquisa && dgvDados.RowCount > 0)
            //    {
            //        DadosStaticos.IdSelecionado = Grade.RetornarId(ref dgvDados, "Codigo");
            //        DialogResult = DialogResult.OK;
            //        Close();
            //    }
            //}
        }

        private void frmContato_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
