namespace Comercial.UI.Formularios
{
    partial class frmTransportadora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_TRANSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInscricao = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDDD = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFone1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFone2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkImportante = new System.Windows.Forms.CheckBox();
            this.tpCompl = new System.Windows.Forms.TabPage();
            this.txtRenavam = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtANTT = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tpBancarios = new System.Windows.Forms.TabPage();
            this.txtNomeDepositante = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtNomeTitular = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtNroConta = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtNroAgencia = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNomBanco = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtNumBanco = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDataNasc = new Comercial.UI.Objetos.ucData();
            this.txtCNPJ = new Comercial.UI.Objetos.ucCNPJ();
            this.txtCPF = new Comercial.UI.Objetos.ucCPF();
            this.UsrCidade = new Comercial.UI.PesquisasGerais.UsrPesquisa();
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
            this.tpCompl.SuspendLayout();
            this.tpBancarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.dgvDados);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox1, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox2, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.dgvDados, 0);
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
            // txtTexto
            // 
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // cbCampos
            // 
            this.cbCampos.Size = new System.Drawing.Size(204, 25);
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
            this.tabControl2.Controls.Add(this.tpCompl);
            this.tabControl2.Controls.Add(this.tpBancarios);
            this.tabControl2.Controls.SetChildIndex(this.tpBancarios, 0);
            this.tabControl2.Controls.SetChildIndex(this.tpCompl, 0);
            this.tabControl2.Controls.SetChildIndex(this.tbPrincipal, 0);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.UsrCidade);
            this.tbPrincipal.Controls.Add(this.chkImportante);
            this.tbPrincipal.Controls.Add(this.label22);
            this.tbPrincipal.Controls.Add(this.txtEmail);
            this.tbPrincipal.Controls.Add(this.label21);
            this.tbPrincipal.Controls.Add(this.txtObservacao);
            this.tbPrincipal.Controls.Add(this.label20);
            this.tbPrincipal.Controls.Add(this.txtContato);
            this.tbPrincipal.Controls.Add(this.label19);
            this.tbPrincipal.Controls.Add(this.txtDataNasc);
            this.tbPrincipal.Controls.Add(this.label18);
            this.tbPrincipal.Controls.Add(this.txtFax);
            this.tbPrincipal.Controls.Add(this.label17);
            this.tbPrincipal.Controls.Add(this.txtFone2);
            this.tbPrincipal.Controls.Add(this.label16);
            this.tbPrincipal.Controls.Add(this.txtFone1);
            this.tbPrincipal.Controls.Add(this.label15);
            this.tbPrincipal.Controls.Add(this.txtDDD);
            this.tbPrincipal.Controls.Add(this.label14);
            this.tbPrincipal.Controls.Add(this.label13);
            this.tbPrincipal.Controls.Add(this.txtUF);
            this.tbPrincipal.Controls.Add(this.txtCEP);
            this.tbPrincipal.Controls.Add(this.txtBairro);
            this.tbPrincipal.Controls.Add(this.label11);
            this.tbPrincipal.Controls.Add(this.txtEndereco);
            this.tbPrincipal.Controls.Add(this.label10);
            this.tbPrincipal.Controls.Add(this.txtInscricao);
            this.tbPrincipal.Controls.Add(this.label9);
            this.tbPrincipal.Controls.Add(this.label8);
            this.tbPrincipal.Controls.Add(this.txtCNPJ);
            this.tbPrincipal.Controls.Add(this.txtCPF);
            this.tbPrincipal.Controls.Add(this.label7);
            this.tbPrincipal.Controls.Add(this.txtNome);
            this.tbPrincipal.Controls.Add(this.label6);
            this.tbPrincipal.Controls.Add(this.txtCodigo);
            this.tbPrincipal.Controls.Add(this.label5);
            // 
            // btnImprimir
            // 
            this.toolTip1.SetToolTip(this.btnImprimir, "F6");
            // 
            // btnFiltrar
            // 
            this.toolTip1.SetToolTip(this.btnFiltrar, "F5");
            // 
            // dgvDados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.CNPJ,
            this.CPF_TRANSP});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 67);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(692, 374);
            this.dgvDados.TabIndex = 3;
            this.dgvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyDown);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_Trans";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 250;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            dataGridViewCellStyle2.Format = "00,000,000/0000-00";
            this.CNPJ.DefaultCellStyle = dataGridViewCellStyle2;
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Width = 150;
            // 
            // CPF_TRANSP
            // 
            this.CPF_TRANSP.DataPropertyName = "CPF_TRANSP";
            dataGridViewCellStyle3.Format = "000,000,000-00";
            this.CPF_TRANSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.CPF_TRANSP.HeaderText = "CPF";
            this.CPF_TRANSP.Name = "CPF_TRANSP";
            this.CPF_TRANSP.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(18, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(70, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(94, 37);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(570, 23);
            this.txtNome.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "CNPJ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Inscrição Estadual";
            // 
            // txtInscricao
            // 
            this.txtInscricao.Location = new System.Drawing.Point(518, 82);
            this.txtInscricao.MaxLength = 20;
            this.txtInscricao.Name = "txtInscricao";
            this.txtInscricao.Size = new System.Drawing.Size(146, 23);
            this.txtInscricao.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(18, 132);
            this.txtEndereco.MaxLength = 40;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(350, 23);
            this.txtEndereco.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(377, 132);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(287, 23);
            this.txtBairro.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Bairro";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(377, 181);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(86, 23);
            this.txtCEP.TabIndex = 9;
            this.txtCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(595, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 17);
            this.label13.TabIndex = 19;
            this.label13.Text = "Estado";
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(598, 181);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(66, 23);
            this.txtUF.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(374, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "CEP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "DDD";
            // 
            // txtDDD
            // 
            this.txtDDD.Location = new System.Drawing.Point(18, 237);
            this.txtDDD.MaxLength = 3;
            this.txtDDD.Name = "txtDDD";
            this.txtDDD.Size = new System.Drawing.Size(54, 23);
            this.txtDDD.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(75, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 17);
            this.label16.TabIndex = 24;
            this.label16.Text = "Fone 1";
            // 
            // txtFone1
            // 
            this.txtFone1.Location = new System.Drawing.Point(78, 237);
            this.txtFone1.MaxLength = 15;
            this.txtFone1.Name = "txtFone1";
            this.txtFone1.Size = new System.Drawing.Size(142, 23);
            this.txtFone1.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(223, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "Fone 2";
            // 
            // txtFone2
            // 
            this.txtFone2.Location = new System.Drawing.Point(226, 237);
            this.txtFone2.MaxLength = 20;
            this.txtFone2.Name = "txtFone2";
            this.txtFone2.Size = new System.Drawing.Size(142, 23);
            this.txtFone2.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(374, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 17);
            this.label18.TabIndex = 28;
            this.label18.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(377, 225);
            this.txtFax.MaxLength = 15;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(142, 23);
            this.txtFax.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(522, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 17);
            this.label19.TabIndex = 30;
            this.label19.Text = "Data Nascimento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 266);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 17);
            this.label20.TabIndex = 32;
            this.label20.Text = "Contato / Indicação";
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(19, 286);
            this.txtContato.MaxLength = 40;
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(349, 23);
            this.txtContato.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(374, 254);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 17);
            this.label21.TabIndex = 34;
            this.label21.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(377, 274);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(287, 85);
            this.txtObservacao.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 363);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 17);
            this.label22.TabIndex = 36;
            this.label22.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(18, 383);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(646, 23);
            this.txtEmail.TabIndex = 19;
            // 
            // chkImportante
            // 
            this.chkImportante.AutoSize = true;
            this.chkImportante.Location = new System.Drawing.Point(171, 361);
            this.chkImportante.Name = "chkImportante";
            this.chkImportante.Size = new System.Drawing.Size(198, 21);
            this.chkImportante.TabIndex = 18;
            this.chkImportante.Text = "Transportador Importantes";
            this.chkImportante.UseVisualStyleBackColor = true;
            // 
            // tpCompl
            // 
            this.tpCompl.Controls.Add(this.txtRenavam);
            this.tpCompl.Controls.Add(this.label24);
            this.tpCompl.Controls.Add(this.txtANTT);
            this.tpCompl.Controls.Add(this.label23);
            this.tpCompl.Location = new System.Drawing.Point(4, 26);
            this.tpCompl.Name = "tpCompl";
            this.tpCompl.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompl.Size = new System.Drawing.Size(684, 468);
            this.tpCompl.TabIndex = 2;
            this.tpCompl.Text = "Complemento";
            this.tpCompl.UseVisualStyleBackColor = true;
            // 
            // txtRenavam
            // 
            this.txtRenavam.Location = new System.Drawing.Point(19, 85);
            this.txtRenavam.MaxLength = 50;
            this.txtRenavam.Name = "txtRenavam";
            this.txtRenavam.Size = new System.Drawing.Size(350, 23);
            this.txtRenavam.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 17);
            this.label24.TabIndex = 14;
            this.label24.Text = "RENAVAM";
            // 
            // txtANTT
            // 
            this.txtANTT.Location = new System.Drawing.Point(19, 35);
            this.txtANTT.MaxLength = 50;
            this.txtANTT.Name = "txtANTT";
            this.txtANTT.Size = new System.Drawing.Size(350, 23);
            this.txtANTT.TabIndex = 0;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(16, 14);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(37, 17);
            this.label23.TabIndex = 12;
            this.label23.Text = "ANTT";
            // 
            // tpBancarios
            // 
            this.tpBancarios.Controls.Add(this.txtNomeDepositante);
            this.tpBancarios.Controls.Add(this.label30);
            this.tpBancarios.Controls.Add(this.txtNomeTitular);
            this.tpBancarios.Controls.Add(this.label29);
            this.tpBancarios.Controls.Add(this.txtNroConta);
            this.tpBancarios.Controls.Add(this.label28);
            this.tpBancarios.Controls.Add(this.txtNroAgencia);
            this.tpBancarios.Controls.Add(this.label27);
            this.tpBancarios.Controls.Add(this.txtNomBanco);
            this.tpBancarios.Controls.Add(this.label26);
            this.tpBancarios.Controls.Add(this.txtNumBanco);
            this.tpBancarios.Controls.Add(this.label25);
            this.tpBancarios.Location = new System.Drawing.Point(4, 26);
            this.tpBancarios.Name = "tpBancarios";
            this.tpBancarios.Padding = new System.Windows.Forms.Padding(3);
            this.tpBancarios.Size = new System.Drawing.Size(684, 468);
            this.tpBancarios.TabIndex = 3;
            this.tpBancarios.Text = "Dados Bancários";
            this.tpBancarios.UseVisualStyleBackColor = true;
            // 
            // txtNomeDepositante
            // 
            this.txtNomeDepositante.Location = new System.Drawing.Point(395, 85);
            this.txtNomeDepositante.MaxLength = 50;
            this.txtNomeDepositante.Name = "txtNomeDepositante";
            this.txtNomeDepositante.Size = new System.Drawing.Size(186, 23);
            this.txtNomeDepositante.TabIndex = 5;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(392, 64);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(153, 17);
            this.label30.TabIndex = 22;
            this.label30.Text = "Nome do Depositante";
            // 
            // txtNomeTitular
            // 
            this.txtNomeTitular.Location = new System.Drawing.Point(145, 85);
            this.txtNomeTitular.MaxLength = 50;
            this.txtNomeTitular.Name = "txtNomeTitular";
            this.txtNomeTitular.Size = new System.Drawing.Size(244, 23);
            this.txtNomeTitular.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(142, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(111, 17);
            this.label29.TabIndex = 20;
            this.label29.Text = "Nome do Titular";
            // 
            // txtNroConta
            // 
            this.txtNroConta.Location = new System.Drawing.Point(16, 85);
            this.txtNroConta.MaxLength = 20;
            this.txtNroConta.Name = "txtNroConta";
            this.txtNroConta.Size = new System.Drawing.Size(123, 23);
            this.txtNroConta.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(13, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 17);
            this.label28.TabIndex = 18;
            this.label28.Text = "Nro Conta";
            // 
            // txtNroAgencia
            // 
            this.txtNroAgencia.Location = new System.Drawing.Point(395, 34);
            this.txtNroAgencia.MaxLength = 20;
            this.txtNroAgencia.Name = "txtNroAgencia";
            this.txtNroAgencia.Size = new System.Drawing.Size(186, 23);
            this.txtNroAgencia.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(392, 13);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 17);
            this.label27.TabIndex = 16;
            this.label27.Text = "Nro Agência";
            // 
            // txtNomBanco
            // 
            this.txtNomBanco.Location = new System.Drawing.Point(145, 34);
            this.txtNomBanco.MaxLength = 50;
            this.txtNomBanco.Name = "txtNomBanco";
            this.txtNomBanco.Size = new System.Drawing.Size(244, 23);
            this.txtNomBanco.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(142, 13);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(115, 17);
            this.label26.TabIndex = 14;
            this.label26.Text = "Nome do Banco";
            // 
            // txtNumBanco
            // 
            this.txtNumBanco.Location = new System.Drawing.Point(16, 34);
            this.txtNumBanco.MaxLength = 20;
            this.txtNumBanco.Name = "txtNumBanco";
            this.txtNumBanco.Size = new System.Drawing.Size(123, 23);
            this.txtNumBanco.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 17);
            this.label25.TabIndex = 12;
            this.label25.Text = "Nro Banco";
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(525, 225);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(139, 23);
            this.txtDataNasc.TabIndex = 15;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(377, 82);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(135, 28);
            this.txtCNPJ.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(18, 83);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(108, 24);
            this.txtCPF.TabIndex = 2;
            // 
            // UsrCidade
            // 
            this.UsrCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrCidade.Location = new System.Drawing.Point(17, 158);
            this.UsrCidade.Margin = new System.Windows.Forms.Padding(4);
            this.UsrCidade.Modificou = false;
            this.UsrCidade.Name = "UsrCidade";
            this.UsrCidade.Size = new System.Drawing.Size(356, 53);
            this.UsrCidade.TabIndex = 7;
            this.UsrCidade.Leave += new System.EventHandler(this.UsrCidade_Leave);
            // 
            // frmTransportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(706, 534);
            this.Name = "frmTransportadora";
            this.Text = "Transportadoras";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTransportadora_FormClosed);
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
            this.tpCompl.ResumeLayout(false);
            this.tpCompl.PerformLayout();
            this.tpBancarios.ResumeLayout(false);
            this.tpBancarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabPage tpCompl;
        private System.Windows.Forms.TextBox txtRenavam;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtANTT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tpBancarios;
        private System.Windows.Forms.TextBox txtNomeDepositante;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtNomeTitular;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtNroConta;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNroAgencia;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNomBanco;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtNumBanco;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox chkImportante;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.Label label19;
        private Objetos.ucData txtDataNasc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFone2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFone1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDDD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInscricao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Objetos.ucCNPJ txtCNPJ;
        private Objetos.ucCPF txtCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_TRANSP;
        private PesquisasGerais.UsrPesquisa UsrCidade;
    }
}
