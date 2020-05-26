namespace Comercial.UI.Formularios
{
    partial class frmMotorista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFoneCelular = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFoneFixo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlacaVeiculo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPlacaReboque1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPlacaReboque2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPlacaReboque3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCnh = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtRenavan = new System.Windows.Forms.TextBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtUFTrans = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCPF = new Comercial.UI.Objetos.ucCPF();
            this.UsrCidade = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.UsrTransportador = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.tabControl1.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpEditar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbPrincipal.SuspendLayout();
            this.tpFiltro.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(762, 524);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.dgvDados);
            this.tpPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.tpPesquisa.Size = new System.Drawing.Size(754, 494);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox1, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox2, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.dgvDados, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 430);
            this.groupBox2.Size = new System.Drawing.Size(746, 60);
            // 
            // btnFiltro
            // 
            this.toolTip1.SetToolTip(this.btnFiltro, "F4");
            // 
            // btnSair
            // 
            this.toolTip1.SetToolTip(this.btnSair, "ESC");
            // 
            // btnExcluir
            // 
            this.toolTip1.SetToolTip(this.btnExcluir, "F3");
            // 
            // btnEditar
            // 
            this.toolTip1.SetToolTip(this.btnEditar, "F2");
            // 
            // btnNovo
            // 
            this.toolTip1.SetToolTip(this.btnNovo, "Insert");
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Size = new System.Drawing.Size(746, 64);
            // 
            // txtTexto
            // 
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // cbCampos
            // 
            this.cbCampos.Size = new System.Drawing.Size(204, 25);
            // 
            // tpEditar
            // 
            this.tpEditar.Margin = new System.Windows.Forms.Padding(4);
            this.tpEditar.Padding = new System.Windows.Forms.Padding(4);
            this.tpEditar.Size = new System.Drawing.Size(754, 494);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(4, 430);
            this.groupBox3.Size = new System.Drawing.Size(746, 60);
            // 
            // btnVoltar2
            // 
            this.toolTip1.SetToolTip(this.btnVoltar2, "ESC");
            // 
            // btnSalvar
            // 
            this.toolTip1.SetToolTip(this.btnSalvar, "F8");
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(4, 4);
            this.tabControl2.Size = new System.Drawing.Size(746, 486);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.UsrTransportador);
            this.tbPrincipal.Controls.Add(this.UsrCidade);
            this.tbPrincipal.Controls.Add(this.label24);
            this.tbPrincipal.Controls.Add(this.label23);
            this.tbPrincipal.Controls.Add(this.txtUFTrans);
            this.tbPrincipal.Controls.Add(this.label22);
            this.tbPrincipal.Controls.Add(this.txtObservacao);
            this.tbPrincipal.Controls.Add(this.label21);
            this.tbPrincipal.Controls.Add(this.txtRenavan);
            this.tbPrincipal.Controls.Add(this.label20);
            this.tbPrincipal.Controls.Add(this.txtCnh);
            this.tbPrincipal.Controls.Add(this.label19);
            this.tbPrincipal.Controls.Add(this.txtPlacaReboque3);
            this.tbPrincipal.Controls.Add(this.label18);
            this.tbPrincipal.Controls.Add(this.txtPlacaReboque2);
            this.tbPrincipal.Controls.Add(this.label17);
            this.tbPrincipal.Controls.Add(this.txtPlacaReboque1);
            this.tbPrincipal.Controls.Add(this.label16);
            this.tbPrincipal.Controls.Add(this.txtPlacaVeiculo);
            this.tbPrincipal.Controls.Add(this.label15);
            this.tbPrincipal.Controls.Add(this.txtDataNasc);
            this.tbPrincipal.Controls.Add(this.label14);
            this.tbPrincipal.Controls.Add(this.txtFoneFixo);
            this.tbPrincipal.Controls.Add(this.label13);
            this.tbPrincipal.Controls.Add(this.txtFoneCelular);
            this.tbPrincipal.Controls.Add(this.txtEstado);
            this.tbPrincipal.Controls.Add(this.label11);
            this.tbPrincipal.Controls.Add(this.label10);
            this.tbPrincipal.Controls.Add(this.txtCep);
            this.tbPrincipal.Controls.Add(this.label8);
            this.tbPrincipal.Controls.Add(this.txtBairro);
            this.tbPrincipal.Controls.Add(this.label7);
            this.tbPrincipal.Controls.Add(this.txtEndereco);
            this.tbPrincipal.Controls.Add(this.label6);
            this.tbPrincipal.Controls.Add(this.label5);
            this.tbPrincipal.Controls.Add(this.txtNome);
            this.tbPrincipal.Controls.Add(this.txtCodigo);
            this.tbPrincipal.Controls.Add(this.txtCPF);
            this.tbPrincipal.Size = new System.Drawing.Size(738, 456);
            // 
            // tpFiltro
            // 
            this.tpFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.tpFiltro.Padding = new System.Windows.Forms.Padding(4);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(4, 440);
            this.groupBox4.Size = new System.Drawing.Size(690, 60);
            // 
            // btnImprimir
            // 
            this.toolTip1.SetToolTip(this.btnImprimir, "F6");
            // 
            // btnFiltrar
            // 
            this.toolTip1.SetToolTip(this.btnFiltrar, "F5");
            // 
            // tabControl3
            // 
            this.tabControl3.Location = new System.Drawing.Point(4, 4);
            this.tabControl3.Size = new System.Drawing.Size(690, 496);
            // 
            // tpFiltroPrincipal
            // 
            this.tpFiltroPrincipal.Size = new System.Drawing.Size(682, 466);
            // 
            // txtUsuarioAlterou
            // 
            this.txtUsuarioAlterou.Margin = new System.Windows.Forms.Padding(4);
            // 
            // txtUsuarioCadastrou
            // 
            this.txtUsuarioCadastrou.Margin = new System.Windows.Forms.Padding(4);
            // 
            // dgvDados
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.CPF});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(4, 68);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(746, 362);
            this.dgvDados.TabIndex = 3;
            this.dgvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyDown);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_Motorista";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 400;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            dataGridViewCellStyle4.Format = "00\\.000\\.000/0000-00";
            this.CPF.DefaultCellStyle = dataGridViewCellStyle4;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.Width = 200;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 27);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(426, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(79, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 75);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(520, 23);
            this.txtEndereco.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 124);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(520, 23);
            this.txtBairro.TabIndex = 3;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(538, 171);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(106, 23);
            this.txtCep.TabIndex = 6;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(535, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 48;
            this.label10.Text = "CEP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(650, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(653, 171);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(49, 23);
            this.txtEstado.TabIndex = 7;
            this.txtEstado.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 52;
            this.label13.Text = "Fone Celular";
            // 
            // txtFoneCelular
            // 
            this.txtFoneCelular.Location = new System.Drawing.Point(6, 270);
            this.txtFoneCelular.MaxLength = 15;
            this.txtFoneCelular.Name = "txtFoneCelular";
            this.txtFoneCelular.Size = new System.Drawing.Size(114, 23);
            this.txtFoneCelular.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(136, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 54;
            this.label14.Text = "Fone Fixo";
            // 
            // txtFoneFixo
            // 
            this.txtFoneFixo.Location = new System.Drawing.Point(139, 270);
            this.txtFoneFixo.MaxLength = 15;
            this.txtFoneFixo.Name = "txtFoneFixo";
            this.txtFoneFixo.Size = new System.Drawing.Size(114, 23);
            this.txtFoneFixo.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(267, 250);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Data Nascimento";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(270, 270);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(114, 23);
            this.txtDataNasc.TabIndex = 14;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 17);
            this.label16.TabIndex = 58;
            this.label16.Text = "Placa Veículo";
            // 
            // txtPlacaVeiculo
            // 
            this.txtPlacaVeiculo.Location = new System.Drawing.Point(6, 317);
            this.txtPlacaVeiculo.MaxLength = 20;
            this.txtPlacaVeiculo.Name = "txtPlacaVeiculo";
            this.txtPlacaVeiculo.Size = new System.Drawing.Size(114, 23);
            this.txtPlacaVeiculo.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(136, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 17);
            this.label17.TabIndex = 60;
            this.label17.Text = "Placa Reboque 1";
            // 
            // txtPlacaReboque1
            // 
            this.txtPlacaReboque1.Location = new System.Drawing.Point(139, 317);
            this.txtPlacaReboque1.MaxLength = 10;
            this.txtPlacaReboque1.Name = "txtPlacaReboque1";
            this.txtPlacaReboque1.Size = new System.Drawing.Size(114, 23);
            this.txtPlacaReboque1.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(267, 297);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 17);
            this.label18.TabIndex = 62;
            this.label18.Text = "Placa Reboque 2";
            // 
            // txtPlacaReboque2
            // 
            this.txtPlacaReboque2.Location = new System.Drawing.Point(270, 317);
            this.txtPlacaReboque2.MaxLength = 10;
            this.txtPlacaReboque2.Name = "txtPlacaReboque2";
            this.txtPlacaReboque2.Size = new System.Drawing.Size(114, 23);
            this.txtPlacaReboque2.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(396, 297);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(119, 17);
            this.label19.TabIndex = 64;
            this.label19.Text = "Placa Reboque 3";
            // 
            // txtPlacaReboque3
            // 
            this.txtPlacaReboque3.Location = new System.Drawing.Point(399, 317);
            this.txtPlacaReboque3.MaxLength = 10;
            this.txtPlacaReboque3.Name = "txtPlacaReboque3";
            this.txtPlacaReboque3.Size = new System.Drawing.Size(114, 23);
            this.txtPlacaReboque3.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 347);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 17);
            this.label20.TabIndex = 66;
            this.label20.Text = "CNH";
            // 
            // txtCnh
            // 
            this.txtCnh.Location = new System.Drawing.Point(6, 367);
            this.txtCnh.MaxLength = 30;
            this.txtCnh.Name = "txtCnh";
            this.txtCnh.Size = new System.Drawing.Size(247, 23);
            this.txtCnh.TabIndex = 19;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(267, 347);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(70, 17);
            this.label21.TabIndex = 68;
            this.label21.Text = "RENAVAN";
            // 
            // txtRenavan
            // 
            this.txtRenavan.Location = new System.Drawing.Point(270, 367);
            this.txtRenavan.MaxLength = 50;
            this.txtRenavan.Name = "txtRenavan";
            this.txtRenavan.Size = new System.Drawing.Size(243, 23);
            this.txtRenavan.TabIndex = 20;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(538, 271);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(194, 120);
            this.txtObservacao.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(535, 251);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 17);
            this.label22.TabIndex = 70;
            this.label22.Text = "Observação";
            // 
            // txtUFTrans
            // 
            this.txtUFTrans.Location = new System.Drawing.Point(654, 222);
            this.txtUFTrans.MaxLength = 2;
            this.txtUFTrans.Name = "txtUFTrans";
            this.txtUFTrans.Size = new System.Drawing.Size(48, 23);
            this.txtUFTrans.TabIndex = 11;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(535, 202);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 17);
            this.label23.TabIndex = 73;
            this.label23.Text = "CPF";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(651, 202);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 17);
            this.label24.TabIndex = 74;
            this.label24.Text = "Estado";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(538, 222);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(110, 24);
            this.txtCPF.TabIndex = 10;
            // 
            // UsrCidade
            // 
            this.UsrCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrCidade.Location = new System.Drawing.Point(6, 150);
            this.UsrCidade.Margin = new System.Windows.Forms.Padding(4);
            this.UsrCidade.Modificou = false;
            this.UsrCidade.Name = "UsrCidade";
            this.UsrCidade.Size = new System.Drawing.Size(525, 53);
            this.UsrCidade.TabIndex = 4;
            this.UsrCidade.Leave += new System.EventHandler(this.UsrCidade_Leave);
            // 
            // UsrTransportador
            // 
            this.UsrTransportador.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrTransportador.Location = new System.Drawing.Point(6, 198);
            this.UsrTransportador.Margin = new System.Windows.Forms.Padding(4);
            this.UsrTransportador.Modificou = false;
            this.UsrTransportador.Name = "UsrTransportador";
            this.UsrTransportador.Size = new System.Drawing.Size(525, 53);
            this.UsrTransportador.TabIndex = 8;
            // 
            // frmMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 524);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMotorista";
            this.Text = "Motoristas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMotorista_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpEditar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbPrincipal.ResumeLayout(false);
            this.tbPrincipal.PerformLayout();
            this.tpFiltro.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtRenavan;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCnh;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPlacaReboque3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPlacaReboque2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPlacaReboque1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlacaVeiculo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFoneFixo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFoneCelular;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtUFTrans;
        private Objetos.ucCPF txtCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private PesquisasGerais.UsrPesquisa UsrCidade;
        private PesquisasGerais.UsrPesquisa UsrTransportador;
    }
}