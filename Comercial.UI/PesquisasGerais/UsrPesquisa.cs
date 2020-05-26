using System;
using System.Windows.Forms;
using static Comercial.Dominio.Enumeradores.Enumerador;
using Comercial.UI.Consultas;
using Comercial.Dominio.Entidades;
using Comercial.UI.Comum;

namespace Comercial.UI.PesquisasGerais
{
    public partial class UsrPesquisa : UserControl
    {
        private EnumProgramas _ePrograma;
        private object _objecto = null;

        public bool Modificou { get; set; }

        public UsrPesquisa()
        {
            InitializeComponent();
        }

        public void Programa(EnumProgramas enumPrograma)
        {
            _ePrograma = enumPrograma;
            Consultar(TipoPesquisaGeral.pgNenhum);
        }

        public object RetornarObjeto()
        {
            return _objecto;
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            if (txtId.Modified)
            {
                Consultar(TipoPesquisaGeral.pgId);
            }
        }

        private void ConsultarEstado(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaEstado();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var estado = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (estado != null)
                {
                    txtId.Text = estado.Id_Estado.ToString();
                    txtNome.Text = estado.Desc_Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarVendedor(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaVendedor();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var Vendedor = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (Vendedor != null)
                {
                    txtId.Text = Vendedor.Cod_Vendedor.ToString();
                    txtNome.Text = Vendedor.Nome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarCliente(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaCliente();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtId.Text = model.Cod_Cliente.ToString();
                    txtNome.Text = model.Nome;
                    _objecto = model;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarUnidadeTexto(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaUnidadeTexto();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var unidadeTexto = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (unidadeTexto != null)
                {
                    txtId.Text = unidadeTexto.Id.ToString();
                    txtNome.Text = unidadeTexto.Observacao;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarGrupo(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaGrupo();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var grupo = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (grupo != null)
                {
                    txtId.Text = grupo.Cod_Grupo.ToString();
                    txtNome.Text = grupo.Desc_Grupo;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarUnidade(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaUnidade();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtId.Text = model.Id_Unidade.ToString();
                    txtNome.Text = model.Sigla;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarFornecedorTipoEmpresa(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaFornecedorTipoEmpresa();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtId.Text = model.Id_Tipo.ToString();
                    txtNome.Text = model.Desc_Tipo;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarTransportador(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaTransportadora();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtId.Text = model.Cod_Trans.ToString();
                    txtNome.Text = model.Nome;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarFormaPagto(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaFormaPagto();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtId.Text = model.Cod_Pagto.ToString();
                    txtNome.Text = model.Desc_Pagto;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarContaBancaria(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaContaBancaria();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtId.Text = model.Id_ContaBanco.ToString();
                    txtNome.Text = model.Num_Conta;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarCidade(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaCidade();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var cidade = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (cidade != null)
                {
                    txtId.Text = cidade.Cod_Cidade.ToString();
                    txtNome.Text = cidade.Desc_Cidade;
                    _objecto = cidade;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void ConsultarFornecedor(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaFornecedor();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtId.Text = "";
                    txtNome.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtId.Text = model.Cod_For.ToString();
                    txtNome.Text = model.Nome;
                    _objecto = model;
                    Modificou = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtId.Modified = false;
            txtNome.Modified = false;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Modified)
            {
                Consultar(TipoPesquisaGeral.pgDescricao);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Consultar(TipoPesquisaGeral.pgTela);
            txtNome.Focus();
        }

        private void Consultar(TipoPesquisaGeral tipoPesquisaGeral)
        {
            switch ((int)_ePrograma)
            {
                case 1:
                    {
                        lblCodigo.Text = "Estado";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarEstado(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 2:
                    {
                        lblCodigo.Text = "Vendedor";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarVendedor(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 3:
                    {
                        lblCodigo.Text = "Cidade";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarCidade(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 4:
                    {
                        lblCodigo.Text = "Texto";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarUnidadeTexto(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 5:
                    {
                        lblCodigo.Text = "Grupo";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarGrupo(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 6:
                    {
                        lblCodigo.Text = "Unidade Medida";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarUnidade(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 7:
                    {
                        lblCodigo.Text = "Tipo Empresa";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarFornecedorTipoEmpresa(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 8:
                    {
                        lblCodigo.Text = "Transportadora";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarTransportador(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 9:
                    {
                        lblCodigo.Text = "Forma de Pagto";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarFormaPagto(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 10:
                    {
                        lblCodigo.Text = "Conta Bancária";
                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarContaBancaria(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 11:
                    {
                        if (lblCodigo.Text == "Nome")
                            lblCodigo.Text = "Cliente";

                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarCliente(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
                case 12:
                    {
                        if (lblCodigo.Text == "Nome")
                            lblCodigo.Text = "Fornecedor";

                        if (tipoPesquisaGeral != TipoPesquisaGeral.pgNenhum)
                            ConsultarFornecedor(Funcoes.StrToInt(txtId.Text), txtNome.Text, tipoPesquisaGeral);
                        break;
                    }
            }
        }

        private void UsrPesquisa_Enter(object sender, EventArgs e)
        {
            Modificou = false;
        }

        public void LimparTela()
        {
            txtId.Clear();
            txtNome.Clear();
        }
    }
}
