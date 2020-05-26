using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using Comercial.UI.Consultas;
using StructureMap;
using System;
using System.Windows.Forms;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.UI.Formularios
{
    public partial class frmTransportadora : Comercial.BaseUI.Base.frmPadrao
    {
        private bool _pesquisa;
        private Transportadora _transportadora;
        private IUnitOfWork _unitOfWork;

        public frmTransportadora()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmTransportadora(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrCidade.Programa(EnumProgramas.Cidade);

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
            dgvDados.DataSource = _unitOfWork.ServicoTransportadora.Filtrar(campo, valor, DadosStaticos.IdEmpresa);
            cbCampos.Text = campos;
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _transportadora, "Cod_Trans");
            Funcoes.Binding(ref txtNome, _transportadora, "Nome");
            Funcoes.Binding(ref txtEndereco, _transportadora, "Endereco");
            Funcoes.Binding(ref txtInscricao, _transportadora, "Insc_Estadual");
            Funcoes.Binding(ref txtFone1, _transportadora, "Fone1");
            Funcoes.Binding(ref txtFone2, _transportadora, "Fone2");
            Funcoes.Binding(ref txtContato, _transportadora, "Contato");
            Funcoes.Binding(ref txtDDD, _transportadora, "DDD");
            Funcoes.Binding(ref txtUsuarioAlterou, _transportadora, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _transportadora, "Usu_Inc");
            Funcoes.Binding(ref txtFax, _transportadora, "Fax");
            Funcoes.Binding(ref txtObservacao, _transportadora, "Obs");
            Funcoes.Binding(ref txtNumBanco, _transportadora, "Num_Banco");
            Funcoes.Binding(ref txtNomBanco, _transportadora, "Nome_Banco");
            Funcoes.Binding(ref txtNroAgencia, _transportadora, "Num_Agencia");
            Funcoes.Binding(ref txtNroConta, _transportadora, "Num_Conta");
            Funcoes.Binding(ref txtNomeTitular, _transportadora, "Nome_Titular");
            Funcoes.Binding(ref txtNomeDepositante, _transportadora, "Nome_Despositante");
            Funcoes.Binding(ref txtEmail, _transportadora, "Email");
            Funcoes.Binding(ref txtANTT, _transportadora, "ANTT");
            Funcoes.Binding(ref txtRenavam, _transportadora, "RENAVAN");
            Funcoes.BindingMask(ref txtCEP, _transportadora, "CEP");

            txtCNPJ.txtValor.DataBindings.Clear();
            txtCNPJ.txtValor.DataBindings.Add("Text", _transportadora, "CNPJ");

            chkImportante.Checked = _transportadora.Destaque == "S";

            txtDataNasc.txtData.Clear();
            if (_transportadora.DataNasc != null)
                txtDataNasc.txtData.Text = _transportadora.DataNasc.ToString();

            txtCPF.txtValor.DataBindings.Clear();
            txtCPF.txtValor.DataBindings.Add("Text", _transportadora, "CPF_TRANSP");

            if (_transportadora.Cod_Cidade != null)
                UsrCidade.txtId.Text = Funcoes.StrToNullStr(_transportadora.Cod_Cidade.Value);

        }

        public override void Novo()
        {
            base.Novo();
            _transportadora = new Transportadora();

            VincularDados();
            txtNome.Focus();
        }

        private void LimparTela()
        {
            Funcoes.LimparTela(tbPrincipal);
            Funcoes.LimparTela(tpCompl);
            Funcoes.LimparTela(tpBancarios);
            Funcoes.LimparTela(tpCompl);
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _transportadora = new Transportadora();
                _transportadora = _unitOfWork.ServicoTransportadora.ObterPorId(id);
                VincularDados();

                if (_transportadora.Cod_Cidade != null)
                {
                    UsrCidade.txtNome.Text = _transportadora.Cidade.Desc_Cidade;
                    txtUF.Text = _transportadora.Cidade.Estado.Sigla;
                }
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
                        var transportadora = _unitOfWork.ServicoTransportadora.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (transportadora != null)
                        {
                            _unitOfWork.ServicoTransportadora.Excluir(transportadora, DadosStaticos.NomeUsuario);
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
                _transportadora.Cod_Empresa = DadosStaticos.IdEmpresa;
                _transportadora.Destaque = chkImportante.Checked ? "S" : "N";
                _transportadora.DataNasc = Funcoes.StrToDateNull(txtDataNasc.txtData.Text);
                _transportadora.Cod_Cidade = Funcoes.StrToIntNull(UsrCidade.txtId.Text);

                id = _unitOfWork.ServicoTransportadora.Salvar(_transportadora, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoTransportadora.Filtrar("", "", DadosStaticos.IdEmpresa, id);
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

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
        }

        private void frmTransportadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }

        private void UsrCidade_Leave(object sender, EventArgs e)
        {
            if (UsrCidade.Modificou)
            {
                var cidade = (Cidade)UsrCidade.RetornarObjeto();
                if (cidade != null)
                {
                    txtCEP.Text = cidade.CEP;
                    txtUF.Clear();
                    if (cidade.Estado != null)
                        txtUF.Text = cidade.Estado.Sigla;
                }
            }
        }
    }
}
