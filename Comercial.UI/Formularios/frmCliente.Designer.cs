namespace Comercial.UI.Formularios
{
    partial class frmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCnpjCpf = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tpEndereco = new System.Windows.Forms.TabPage();
            this.UsrCidade = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tpCompl = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCreditoQtde = new Comercial.UI.Objetos.ucValor();
            this.txtCreditoSaldo = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.txtCreditoQtdeUsada = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtCreditoData = new Comercial.UI.Objetos.ucData();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tpVendedor = new System.Windows.Forms.TabPage();
            this.UsrVendedor = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.btnContato = new System.Windows.Forms.Button();
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtCPF = new Comercial.UI.Objetos.ucCPF();
            this.txtDataCadastro = new Comercial.UI.Objetos.ucData();
            this.txtCNPJ = new Comercial.UI.Objetos.ucCNPJ();
            this.btnUltPedidos = new System.Windows.Forms.Button();
            this.UsrFormaPagto = new Comercial.UI.PesquisasGerais.UsrPesquisa();
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
            this.tabControl4.SuspendLayout();
            this.tpEndereco.SuspendLayout();
            this.tpCompl.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tpVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(733, 478);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.dgvDados);
            this.tpPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.tpPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.tpPesquisa.Size = new System.Drawing.Size(725, 448);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox1, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox2, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.dgvDados, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(4, 384);
            this.groupBox2.Size = new System.Drawing.Size(717, 60);
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
            this.groupBox1.Size = new System.Drawing.Size(717, 64);
            this.groupBox1.TabIndex = 0;
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
            this.tpEditar.Size = new System.Drawing.Size(725, 448);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUltPedidos);
            this.groupBox3.Controls.Add(this.btnContato);
            this.groupBox3.Location = new System.Drawing.Point(4, 384);
            this.groupBox3.Size = new System.Drawing.Size(717, 60);
            this.groupBox3.Controls.SetChildIndex(this.btnSalvar, 0);
            this.groupBox3.Controls.SetChildIndex(this.btnVoltar2, 0);
            this.groupBox3.Controls.SetChildIndex(this.btnContato, 0);
            this.groupBox3.Controls.SetChildIndex(this.btnUltPedidos, 0);
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
            this.tabControl2.Size = new System.Drawing.Size(717, 440);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.txtCPF);
            this.tbPrincipal.Controls.Add(this.label31);
            this.tbPrincipal.Controls.Add(this.txtRG);
            this.tbPrincipal.Controls.Add(this.txtDataCadastro);
            this.tbPrincipal.Controls.Add(this.label30);
            this.tbPrincipal.Controls.Add(this.label29);
            this.tbPrincipal.Controls.Add(this.cbTipoPessoa);
            this.tbPrincipal.Controls.Add(this.tabControl4);
            this.tbPrincipal.Controls.Add(this.label9);
            this.tbPrincipal.Controls.Add(this.txtInscEstadual);
            this.tbPrincipal.Controls.Add(this.lblCnpjCpf);
            this.tbPrincipal.Controls.Add(this.txtCNPJ);
            this.tbPrincipal.Controls.Add(this.label7);
            this.tbPrincipal.Controls.Add(this.label6);
            this.tbPrincipal.Controls.Add(this.txtFantasia);
            this.tbPrincipal.Controls.Add(this.txtNome);
            this.tbPrincipal.Controls.Add(this.txtCodigo);
            this.tbPrincipal.Controls.Add(this.label5);
            this.tbPrincipal.Size = new System.Drawing.Size(709, 410);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.CNPJ,
            this.CPF,
            this.Fone,
            this.Email});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(4, 68);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(717, 316);
            this.dgvDados.TabIndex = 1;
            this.dgvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyDown);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_Cliente";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 300;
            // 
            // CNPJ
            // 
            this.CNPJ.DataPropertyName = "CNPJ";
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.Width = 150;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF";
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.Width = 150;
            // 
            // Fone
            // 
            this.Fone.DataPropertyName = "Fone";
            this.Fone.HeaderText = "Telefone";
            this.Fone.Name = "Fone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 300;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(9, 36);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(71, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 36);
            this.txtNome.MaxLength = 60;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(449, 36);
            this.txtFantasia.MaxLength = 50;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(254, 23);
            this.txtFantasia.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Fantasia";
            // 
            // lblCnpjCpf
            // 
            this.lblCnpjCpf.AutoSize = true;
            this.lblCnpjCpf.Location = new System.Drawing.Point(263, 59);
            this.lblCnpjCpf.Name = "lblCnpjCpf";
            this.lblCnpjCpf.Size = new System.Drawing.Size(43, 17);
            this.lblCnpjCpf.TabIndex = 6;
            this.lblCnpjCpf.Text = "CNPJ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Inscrição Estadual";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(409, 79);
            this.txtInscEstadual.MaxLength = 20;
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(143, 23);
            this.txtInscEstadual.TabIndex = 7;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tpEndereco);
            this.tabControl4.Controls.Add(this.tpCompl);
            this.tabControl4.Controls.Add(this.tpVendedor);
            this.tabControl4.Location = new System.Drawing.Point(9, 113);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(694, 235);
            this.tabControl4.TabIndex = 9;
            // 
            // tpEndereco
            // 
            this.tpEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpEndereco.Controls.Add(this.UsrCidade);
            this.tpEndereco.Controls.Add(this.label19);
            this.tpEndereco.Controls.Add(this.label18);
            this.tpEndereco.Controls.Add(this.label17);
            this.tpEndereco.Controls.Add(this.txtEmail);
            this.tpEndereco.Controls.Add(this.txtFax);
            this.tpEndereco.Controls.Add(this.txtTelefone);
            this.tpEndereco.Controls.Add(this.label16);
            this.tpEndereco.Controls.Add(this.label15);
            this.tpEndereco.Controls.Add(this.txtEstado);
            this.tpEndereco.Controls.Add(this.txtCep);
            this.tpEndereco.Controls.Add(this.txtBairro);
            this.tpEndereco.Controls.Add(this.label13);
            this.tpEndereco.Controls.Add(this.label12);
            this.tpEndereco.Controls.Add(this.label11);
            this.tpEndereco.Controls.Add(this.txtComplemento);
            this.tpEndereco.Controls.Add(this.txtNumero);
            this.tpEndereco.Controls.Add(this.txtEndereco);
            this.tpEndereco.Controls.Add(this.label10);
            this.tpEndereco.Location = new System.Drawing.Point(4, 26);
            this.tpEndereco.Name = "tpEndereco";
            this.tpEndereco.Padding = new System.Windows.Forms.Padding(3);
            this.tpEndereco.Size = new System.Drawing.Size(686, 205);
            this.tpEndereco.TabIndex = 0;
            this.tpEndereco.Text = "Endereço";
            // 
            // UsrCidade
            // 
            this.UsrCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrCidade.Location = new System.Drawing.Point(6, 95);
            this.UsrCidade.Margin = new System.Windows.Forms.Padding(4);
            this.UsrCidade.Modificou = false;
            this.UsrCidade.Name = "UsrCidade";
            this.UsrCidade.Size = new System.Drawing.Size(498, 52);
            this.UsrCidade.TabIndex = 5;
            this.UsrCidade.Leave += new System.EventHandler(this.usrPesquisa1_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(260, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(134, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Fax";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(263, 166);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(417, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(137, 166);
            this.txtFax.MaxLength = 15;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(120, 23);
            this.txtFax.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 166);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(125, 23);
            this.txtTelefone.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(615, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(509, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "CEP";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(618, 119);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(57, 23);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.TabStop = false;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(512, 119);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 23);
            this.txtCep.TabIndex = 7;
            this.txtCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 69);
            this.txtBairro.MaxLength = 40;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(380, 23);
            this.txtBairro.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Bairro";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(451, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Complemento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(392, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(454, 23);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(226, 23);
            this.txtComplemento.TabIndex = 3;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(395, 23);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(53, 23);
            this.txtNumero.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 23);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(380, 23);
            this.txtEndereco.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Av/Rua";
            // 
            // tpCompl
            // 
            this.tpCompl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpCompl.Controls.Add(this.UsrFormaPagto);
            this.tpCompl.Controls.Add(this.groupBox5);
            this.tpCompl.Controls.Add(this.txtObservacao);
            this.tpCompl.Controls.Add(this.label21);
            this.tpCompl.Location = new System.Drawing.Point(4, 26);
            this.tpCompl.Name = "tpCompl";
            this.tpCompl.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompl.Size = new System.Drawing.Size(686, 205);
            this.tpCompl.TabIndex = 1;
            this.tpCompl.Text = "Complemento";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.txtCreditoQtde);
            this.groupBox5.Controls.Add(this.txtCreditoSaldo);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.txtCreditoQtdeUsada);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.label32);
            this.groupBox5.Controls.Add(this.txtCreditoData);
            this.groupBox5.Location = new System.Drawing.Point(436, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(244, 166);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crédito:";
            // 
            // txtCreditoQtde
            // 
            this.txtCreditoQtde.CasasDecimais = Comercial.UI.Objetos.ucValor.Casas.Inteira;
            this.txtCreditoQtde.Location = new System.Drawing.Point(109, 64);
            this.txtCreditoQtde.Name = "txtCreditoQtde";
            this.txtCreditoQtde.Size = new System.Drawing.Size(100, 23);
            this.txtCreditoQtde.TabIndex = 1;
            // 
            // txtCreditoSaldo
            // 
            this.txtCreditoSaldo.Location = new System.Drawing.Point(109, 122);
            this.txtCreditoSaldo.Name = "txtCreditoSaldo";
            this.txtCreditoSaldo.ReadOnly = true;
            this.txtCreditoSaldo.Size = new System.Drawing.Size(100, 23);
            this.txtCreditoSaldo.TabIndex = 3;
            this.txtCreditoSaldo.TabStop = false;
            this.txtCreditoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(16, 128);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 17);
            this.label35.TabIndex = 6;
            this.label35.Text = "Saldo";
            // 
            // txtCreditoQtdeUsada
            // 
            this.txtCreditoQtdeUsada.Location = new System.Drawing.Point(109, 93);
            this.txtCreditoQtdeUsada.MaxLength = 10;
            this.txtCreditoQtdeUsada.Name = "txtCreditoQtdeUsada";
            this.txtCreditoQtdeUsada.ReadOnly = true;
            this.txtCreditoQtdeUsada.Size = new System.Drawing.Size(100, 23);
            this.txtCreditoQtdeUsada.TabIndex = 2;
            this.txtCreditoQtdeUsada.TabStop = false;
            this.txtCreditoQtdeUsada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(16, 99);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(85, 17);
            this.label34.TabIndex = 4;
            this.label34.Text = "Qtde Usada";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(16, 70);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(87, 17);
            this.label33.TabIndex = 2;
            this.label33.Text = "Quantidade";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(16, 41);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 17);
            this.label32.TabIndex = 1;
            this.label32.Text = "Data";
            // 
            // txtCreditoData
            // 
            this.txtCreditoData.Location = new System.Drawing.Point(109, 35);
            this.txtCreditoData.Name = "txtCreditoData";
            this.txtCreditoData.Size = new System.Drawing.Size(100, 23);
            this.txtCreditoData.TabIndex = 0;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(5, 79);
            this.txtObservacao.MaxLength = 150;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(418, 120);
            this.txtObservacao.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 59);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 17);
            this.label21.TabIndex = 20;
            this.label21.Text = "Observação";
            // 
            // tpVendedor
            // 
            this.tpVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpVendedor.Controls.Add(this.UsrVendedor);
            this.tpVendedor.Location = new System.Drawing.Point(4, 26);
            this.tpVendedor.Name = "tpVendedor";
            this.tpVendedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpVendedor.Size = new System.Drawing.Size(686, 205);
            this.tpVendedor.TabIndex = 2;
            this.tpVendedor.Text = "Vendedor";
            // 
            // UsrVendedor
            // 
            this.UsrVendedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrVendedor.Location = new System.Drawing.Point(7, 19);
            this.UsrVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.UsrVendedor.Modificou = false;
            this.UsrVendedor.Name = "UsrVendedor";
            this.UsrVendedor.Size = new System.Drawing.Size(498, 53);
            this.UsrVendedor.TabIndex = 8;
            // 
            // btnContato
            // 
            this.btnContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContato.Location = new System.Drawing.Point(230, 11);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(105, 39);
            this.btnContato.TabIndex = 5;
            this.btnContato.Text = "Contatos";
            this.btnContato.UseVisualStyleBackColor = true;
            this.btnContato.Click += new System.EventHandler(this.btnContato_Click);
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(9, 80);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(142, 25);
            this.cbTipoPessoa.TabIndex = 3;
            this.cbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPessoa_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(146, 17);
            this.label29.TabIndex = 10;
            this.label29.Text = "Pessoa Física/Jurídica";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(154, 60);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(106, 17);
            this.label30.TabIndex = 11;
            this.label30.Text = "Data Cadastro";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(558, 79);
            this.txtRG.MaxLength = 20;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(145, 23);
            this.txtRG.TabIndex = 8;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(555, 60);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 17);
            this.label31.TabIndex = 14;
            this.label31.Text = "RG";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(266, 79);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(123, 24);
            this.txtCPF.TabIndex = 6;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Location = new System.Drawing.Point(157, 80);
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(103, 24);
            this.txtDataCadastro.TabIndex = 4;
            this.txtDataCadastro.TabStop = false;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(266, 80);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(137, 25);
            this.txtCNPJ.TabIndex = 5;
            // 
            // btnUltPedidos
            // 
            this.btnUltPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUltPedidos.Location = new System.Drawing.Point(341, 11);
            this.btnUltPedidos.Name = "btnUltPedidos";
            this.btnUltPedidos.Size = new System.Drawing.Size(105, 39);
            this.btnUltPedidos.TabIndex = 6;
            this.btnUltPedidos.Text = "Últ.Pedidos";
            this.btnUltPedidos.UseVisualStyleBackColor = true;
            this.btnUltPedidos.Click += new System.EventHandler(this.btnUltPedidos_Click);
            // 
            // UsrFormaPagto
            // 
            this.UsrFormaPagto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrFormaPagto.Location = new System.Drawing.Point(4, 4);
            this.UsrFormaPagto.Margin = new System.Windows.Forms.Padding(4);
            this.UsrFormaPagto.Modificou = false;
            this.UsrFormaPagto.Name = "UsrFormaPagto";
            this.UsrFormaPagto.Size = new System.Drawing.Size(425, 53);
            this.UsrFormaPagto.TabIndex = 0;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 478);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCliente";
            this.Text = "Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCliente_FormClosed);
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
            this.tabControl4.ResumeLayout(false);
            this.tpEndereco.ResumeLayout(false);
            this.tpEndereco.PerformLayout();
            this.tpCompl.ResumeLayout(false);
            this.tpCompl.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tpVendedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.Label lblCnpjCpf;
        private Objetos.ucCNPJ txtCNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tpEndereco;
        private System.Windows.Forms.TabPage tpCompl;
        private System.Windows.Forms.TabPage tpVendedor;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnContato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtRG;
        private Objetos.ucData txtDataCadastro;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCreditoSaldo;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtCreditoQtdeUsada;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private Objetos.ucData txtCreditoData;
        private Objetos.ucValor txtCreditoQtde;
        private Objetos.ucCPF txtCPF;
        private System.Windows.Forms.Button btnUltPedidos;
        private PesquisasGerais.UsrPesquisa UsrCidade;
        private PesquisasGerais.UsrPesquisa UsrVendedor;
        private PesquisasGerais.UsrPesquisa UsrFormaPagto;
    }
}