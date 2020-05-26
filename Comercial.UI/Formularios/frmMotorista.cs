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
    public partial class frmMotorista : Comercial.BaseUI.Base.frmPadrao
    {
        private Motorista _motorista;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmMotorista()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmMotorista(string descricao)
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
            UsrTransportador.Programa(EnumProgramas.Transportador);

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            //dgvDados.Columns["CPF"].DefaultCellStyle.Format = @"00\.000\.000/000-00";
            dgvDados.Columns["CPF"].DefaultCellStyle.Format = @"###\.###\.###-##";
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
            dgvDados.DataSource = _unitOfWork.ServicoMotorista.Filtrar(campo, valor, DadosStaticos.IdEmpresa);
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _motorista = new Motorista();
            VincularDados(TipoVinculo.Novo, null);
            VincularDados();
            Funcoes.LimparTela(tbPrincipal);
            txtNome.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _motorista = new Motorista();
                _motorista = _unitOfWork.ServicoMotorista.ObterPorId(id);
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
                        var motorista = _unitOfWork.ServicoMotorista.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (motorista != null)
                        {
                            _unitOfWork.ServicoMotorista.Excluir(motorista, DadosStaticos.NomeUsuario);
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
                id = _unitOfWork.ServicoMotorista.Salvar(_motorista, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoMotorista.Filtrar("", "", DadosStaticos.IdEmpresa, id);
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
                txtCPF.txtValor.Clear();
                UsrCidade.txtId.Clear();
                UsrTransportador.txtId.Clear();
            }

            if (tipoVinculo == TipoVinculo.Editar)
            {
                txtCPF.txtValor.Text = _motorista.CPF;
                txtDataNasc.Text = _motorista.DataNasc.ToString();
                if (_motorista.Cod_Cidade != null)
                {
                    UsrCidade.txtId.Text = _motorista.Cod_Cidade.Value.ToString();
                    UsrCidade.txtNome.Text = _motorista.Cidade.Desc_Cidade;
                    txtEstado.Text = (_motorista.Cidade.Estado != null) ? _motorista.Cidade.Estado.Sigla : "";
                }

                if (_motorista.Cod_Trans != null)
                {
                    UsrTransportador.txtId.Text = _motorista.Transportadora.Cod_Trans.ToString();
                    UsrTransportador.txtNome.Text = _motorista.Transportadora.Nome;
                }
            }

            if (tipoVinculo == TipoVinculo.Salvar)
            {
                _motorista.CPF = txtCPF.txtValor.Text;
                _motorista.Cod_Cidade = Funcoes.StrToIntNull(UsrCidade.txtId.Text);
                _motorista.Cod_Trans = Funcoes.StrToIntNull(UsrTransportador.txtId.Text);
                _motorista.DataNasc = Funcoes.StrToDateNull(txtDataNasc.Text);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _motorista, "Cod_Motorista");
            Funcoes.Binding(ref txtNome, _motorista, "Nome");
            Funcoes.Binding(ref txtEndereco, _motorista, "Endereco");
            Funcoes.Binding(ref txtBairro, _motorista, "Bairro");
            Funcoes.BindingMask(ref txtCep, _motorista, "Cep");
            Funcoes.Binding(ref txtFoneCelular, _motorista, "Fone1");
            Funcoes.Binding(ref txtFoneFixo, _motorista, "Fone2");
            Funcoes.Binding(ref txtPlacaVeiculo, _motorista, "Placa");
            Funcoes.Binding(ref txtPlacaReboque1, _motorista, "Placa_Reboque1");
            Funcoes.Binding(ref txtPlacaReboque2, _motorista, "Placa_Reboque2");
            Funcoes.Binding(ref txtPlacaReboque3, _motorista, "Placa_Reboque3");
            Funcoes.Binding(ref txtCnh, _motorista, "CNH");
            Funcoes.Binding(ref txtRenavan, _motorista, "RENAVAN");
            Funcoes.Binding(ref txtObservacao, _motorista, "Obs");
            Funcoes.Binding(ref txtUFTrans, _motorista, "Estado_CPF");

            Funcoes.Binding(ref txtUsuarioAlterou, _motorista, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _motorista, "Usu_Inc");
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

        private void frmMotorista_FormClosed(object sender, FormClosedEventArgs e)
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
