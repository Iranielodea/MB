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
    public partial class frmFornecedor : BaseUI.Base.frmPadrao
    {
        private Fornecedor _fornecedor;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmFornecedor()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmFornecedor(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrTipoEmpresa.Programa(EnumProgramas.TipoFornecedorEmpresa);
            UsrCidade.Programa(EnumProgramas.Cidade);

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            //dgvDados.Columns["CPF"].DefaultCellStyle.Format = @"00\.000\.000/000-00";
            //dgvDados.Columns["CPF"].DefaultCellStyle.Format = @"###\.###\.###-##";
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
            dgvDados.DataSource = _unitOfWork.ServicoFornecedor.Filtrar(campo, valor, DadosStaticos.IdEmpresa);
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _fornecedor = new Fornecedor();
            btnContato.Enabled = false;
            LimparTela();
            VincularDados(TipoVinculo.Novo, null);
            VincularDados();
            txtNome.Focus();
        }

        private void LimparTela()
        {
            tabControl4.SelectedTab = tpEndereco;
            Funcoes.LimparTela(tbPrincipal);
            Funcoes.LimparTela(tpEndereco);
            Funcoes.LimparTela(tpCompl);
            Funcoes.LimparTela(tpBanco);
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                LimparTela();
                btnContato.Enabled = true;
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _fornecedor = new Fornecedor();
                _fornecedor = _unitOfWork.ServicoFornecedor.ObterPorId(id);
                VincularDados();
                VincularDados(TipoVinculo.Editar, _unitOfWork);
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
                        var fornecedor = _unitOfWork.ServicoFornecedor.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (fornecedor != null)
                        {
                            _unitOfWork.ServicoFornecedor.Excluir(fornecedor, DadosStaticos.NomeUsuario);
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
                VincularDados(TipoVinculo.Salvar, null);
                id = _unitOfWork.ServicoFornecedor.Salvar(_fornecedor, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoFornecedor.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados(TipoVinculo tipoVinculo, IUnitOfWork unitOfWork)
        {
            if (tipoVinculo == TipoVinculo.Novo)
            {
                txtCNPJ.txtValor.Clear();
                txtCPF.txtValor.Clear();
                UsrCidade.txtId.Clear();
                UsrTipoEmpresa.txtId.Clear();
            }

            if (tipoVinculo == TipoVinculo.Editar)
            {
                txtCPF.txtValor.Text = _fornecedor.CPF;
                txtCNPJ.txtValor.Text = _fornecedor.CNPJ;
                if (_fornecedor.Cod_Cidade != null)
                {
                    UsrCidade.txtId.Text = _fornecedor.Cod_Cidade.Value.ToString();
                    UsrCidade.txtNome.Text = _fornecedor.Cidade.Desc_Cidade;

                    if (_fornecedor.Cidade != null)
                        txtEstado.Text = (_fornecedor.Cidade.Estado != null) ? _fornecedor.Cidade.Estado.Sigla : "";
                }

                if (_fornecedor.Id_Tipo_Empresa != null)
                {

                    if (_fornecedor.FornecedorTipoEmpresa != null)
                    {
                        UsrTipoEmpresa.txtId.Text = _fornecedor.FornecedorTipoEmpresa.Cod_Empresa.ToString();
                        UsrTipoEmpresa.txtNome.Text = _fornecedor.FornecedorTipoEmpresa.Desc_Tipo;
                    }
                }
            }

            if (tipoVinculo == TipoVinculo.Salvar)
            {
                _fornecedor.CPF = txtCPF.txtValor.Text;
                _fornecedor.CNPJ = txtCNPJ.txtValor.Text;
                _fornecedor.Cod_Cidade = Funcoes.StrToIntNull(UsrCidade.txtId.Text);
                _fornecedor.Id_Tipo_Empresa = Funcoes.StrToIntNull(UsrTipoEmpresa.txtId.Text);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _fornecedor, "Cod_For");
            Funcoes.Binding(ref txtNome, _fornecedor, "Nome");
            Funcoes.Binding(ref txtFantasia, _fornecedor, "Fantasia");
            Funcoes.Binding(ref txtEndereco, _fornecedor, "Endereco");
            Funcoes.Binding(ref txtNumero, _fornecedor, "Numero");
            Funcoes.Binding(ref txtComplemento, _fornecedor, "Complemento");
            Funcoes.Binding(ref txtBairro, _fornecedor, "Bairro");
            Funcoes.BindingMask(ref txtCep, _fornecedor, "Cep");
            Funcoes.Binding(ref txtInscEstadual, _fornecedor, "Insc_Estadual");
            Funcoes.Binding(ref txtTelefone, _fornecedor, "Fone");
            Funcoes.Binding(ref txtFax, _fornecedor, "Fax");
            Funcoes.Binding(ref txtEmail, _fornecedor, "Email");
            Funcoes.Binding(ref txtObservacao, _fornecedor, "Obs");
            Funcoes.Binding(ref txtNumeroBanco, _fornecedor, "Num_Banco");
            Funcoes.Binding(ref txtNomeBanco, _fornecedor, "Nome_Banco");
            Funcoes.Binding(ref txtNroAgencia, _fornecedor, "Num_Agencia");
            Funcoes.Binding(ref txtNroConta, _fornecedor, "Num_Conta");
            Funcoes.Binding(ref txtNomeTitular, _fornecedor, "Nome_Titular");
            Funcoes.Binding(ref txtNomeDepositante, _fornecedor, "Nome_Despositante");

            Funcoes.Binding(ref txtUsuarioAlterou, _fornecedor, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _fornecedor, "Usu_Inc");
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

        //private void txtCodCidade_Leave(object sender, EventArgs e)
        //{
        //}

        //private void txtNomeCidade_Leave(object sender, EventArgs e)
        //{
        //}

        private void BuscarContatos(int codigo)
        {
            frmContato frmContato = new frmContato(codigo, EnContato.Fornecedor);
            frmContato.ShowDialog();
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            BuscarContatos(int.Parse(txtCodigo.Text));
        }

        private void frmFornecedor_FormClosed(object sender, FormClosedEventArgs e)
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
                    txtCep.Text = cidade.CEP;
                    txtEstado.Clear();
                    if (cidade.Estado != null)
                        txtEstado.Text = cidade.Estado.Sigla;
                }
            }
        }
    }
}
