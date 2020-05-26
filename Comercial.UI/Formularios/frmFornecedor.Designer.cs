namespace Comercial.UI.Formularios
{
    partial class frmFornecedor
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
            this.Insc_Estadual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCNPJ = new Comercial.UI.Objetos.ucCNPJ();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInscEstadual = new System.Windows.Forms.TextBox();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tpEndereco = new System.Windows.Forms.TabPage();
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
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tpBanco = new System.Windows.Forms.TabPage();
            this.label28 = new System.Windows.Forms.Label();
            this.txtCPF = new Comercial.UI.Objetos.ucCPF();
            this.txtNomeDepositante = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtNomeTitular = new System.Windows.Forms.TextBox();
            this.txtNroConta = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNroAgencia = new System.Windows.Forms.TextBox();
            this.txtNomeBanco = new System.Windows.Forms.TextBox();
            this.txtNumeroBanco = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnContato = new System.Windows.Forms.Button();
            this.UsrTipoEmpresa = new Comercial.UI.PesquisasGerais.UsrPesquisa();
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
            this.tabControl4.SuspendLayout();
            this.tpEndereco.SuspendLayout();
            this.tpCompl.SuspendLayout();
            this.tpBanco.SuspendLayout();
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
            this.groupBox3.Controls.Add(this.btnContato);
            this.groupBox3.Location = new System.Drawing.Point(4, 384);
            this.groupBox3.Size = new System.Drawing.Size(717, 60);
            this.groupBox3.Controls.SetChildIndex(this.btnSalvar, 0);
            this.groupBox3.Controls.SetChildIndex(this.btnVoltar2, 0);
            this.groupBox3.Controls.SetChildIndex(this.btnContato, 0);
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
            this.tbPrincipal.Controls.Add(this.tabControl4);
            this.tbPrincipal.Controls.Add(this.label9);
            this.tbPrincipal.Controls.Add(this.txtInscEstadual);
            this.tbPrincipal.Controls.Add(this.label8);
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
            this.Insc_Estadual,
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
            this.Codigo.DataPropertyName = "Cod_For";
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
            // Insc_Estadual
            // 
            this.Insc_Estadual.DataPropertyName = "Insc_Estadual";
            this.Insc_Estadual.HeaderText = "Insc. Estadual";
            this.Insc_Estadual.Name = "Insc_Estadual";
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
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(9, 84);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(137, 25);
            this.txtCNPJ.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "CNPJ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Inscrição Estadual";
            // 
            // txtInscEstadual
            // 
            this.txtInscEstadual.Location = new System.Drawing.Point(152, 84);
            this.txtInscEstadual.MaxLength = 20;
            this.txtInscEstadual.Name = "txtInscEstadual";
            this.txtInscEstadual.Size = new System.Drawing.Size(143, 23);
            this.txtInscEstadual.TabIndex = 4;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tpEndereco);
            this.tabControl4.Controls.Add(this.tpCompl);
            this.tabControl4.Controls.Add(this.tpBanco);
            this.tabControl4.Location = new System.Drawing.Point(9, 113);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(694, 235);
            this.tabControl4.TabIndex = 5;
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(215, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 17);
            this.label19.TabIndex = 21;
            this.label19.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(109, 146);
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
            this.txtEmail.Location = new System.Drawing.Point(218, 166);
            this.txtEmail.MaxLength = 80;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(462, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(112, 166);
            this.txtFax.MaxLength = 15;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 23);
            this.txtFax.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(6, 166);
            this.txtTelefone.MaxLength = 15;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(499, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(393, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 17);
            this.label15.TabIndex = 13;
            this.label15.Text = "CEP";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(502, 120);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(57, 23);
            this.txtEstado.TabIndex = 8;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(396, 120);
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
            this.tpCompl.Controls.Add(this.UsrTipoEmpresa);
            this.tpCompl.Controls.Add(this.txtObservacao);
            this.tpCompl.Controls.Add(this.label21);
            this.tpCompl.Location = new System.Drawing.Point(4, 26);
            this.tpCompl.Name = "tpCompl";
            this.tpCompl.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompl.Size = new System.Drawing.Size(686, 205);
            this.tpCompl.TabIndex = 1;
            this.tpCompl.Text = "Complemento";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(5, 79);
            this.txtObservacao.MaxLength = 150;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(418, 120);
            this.txtObservacao.TabIndex = 1;
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
            // tpBanco
            // 
            this.tpBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tpBanco.Controls.Add(this.label28);
            this.tpBanco.Controls.Add(this.txtCPF);
            this.tpBanco.Controls.Add(this.txtNomeDepositante);
            this.tpBanco.Controls.Add(this.label27);
            this.tpBanco.Controls.Add(this.label25);
            this.tpBanco.Controls.Add(this.txtNomeTitular);
            this.tpBanco.Controls.Add(this.txtNroConta);
            this.tpBanco.Controls.Add(this.label26);
            this.tpBanco.Controls.Add(this.label22);
            this.tpBanco.Controls.Add(this.label23);
            this.tpBanco.Controls.Add(this.txtNroAgencia);
            this.tpBanco.Controls.Add(this.txtNomeBanco);
            this.tpBanco.Controls.Add(this.txtNumeroBanco);
            this.tpBanco.Controls.Add(this.label24);
            this.tpBanco.Location = new System.Drawing.Point(4, 26);
            this.tpBanco.Name = "tpBanco";
            this.tpBanco.Padding = new System.Windows.Forms.Padding(3);
            this.tpBanco.Size = new System.Drawing.Size(686, 205);
            this.tpBanco.TabIndex = 2;
            this.tpBanco.Text = "Dados Bancários";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(392, 115);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 17);
            this.label28.TabIndex = 19;
            this.label28.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(395, 135);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(112, 24);
            this.txtCPF.TabIndex = 6;
            // 
            // txtNomeDepositante
            // 
            this.txtNomeDepositante.Location = new System.Drawing.Point(6, 135);
            this.txtNomeDepositante.MaxLength = 50;
            this.txtNomeDepositante.Name = "txtNomeDepositante";
            this.txtNomeDepositante.Size = new System.Drawing.Size(380, 23);
            this.txtNomeDepositante.TabIndex = 5;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(131, 17);
            this.label27.TabIndex = 16;
            this.label27.Text = "Nome Depositante";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(166, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 17);
            this.label25.TabIndex = 15;
            this.label25.Text = "Nome Titular";
            // 
            // txtNomeTitular
            // 
            this.txtNomeTitular.Location = new System.Drawing.Point(169, 84);
            this.txtNomeTitular.MaxLength = 50;
            this.txtNomeTitular.Name = "txtNomeTitular";
            this.txtNomeTitular.Size = new System.Drawing.Size(511, 23);
            this.txtNomeTitular.TabIndex = 4;
            // 
            // txtNroConta
            // 
            this.txtNroConta.Location = new System.Drawing.Point(7, 84);
            this.txtNroConta.MaxLength = 20;
            this.txtNroConta.Name = "txtNroConta";
            this.txtNroConta.Size = new System.Drawing.Size(156, 23);
            this.txtNroConta.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 64);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 17);
            this.label26.TabIndex = 12;
            this.label26.Text = "Nro Conta";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(451, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "Nro Agência";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(166, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 17);
            this.label23.TabIndex = 10;
            this.label23.Text = "Nome Banco";
            // 
            // txtNroAgencia
            // 
            this.txtNroAgencia.Location = new System.Drawing.Point(454, 32);
            this.txtNroAgencia.MaxLength = 20;
            this.txtNroAgencia.Name = "txtNroAgencia";
            this.txtNroAgencia.Size = new System.Drawing.Size(226, 23);
            this.txtNroAgencia.TabIndex = 2;
            // 
            // txtNomeBanco
            // 
            this.txtNomeBanco.Location = new System.Drawing.Point(169, 32);
            this.txtNomeBanco.MaxLength = 50;
            this.txtNomeBanco.Name = "txtNomeBanco";
            this.txtNomeBanco.Size = new System.Drawing.Size(279, 23);
            this.txtNomeBanco.TabIndex = 1;
            // 
            // txtNumeroBanco
            // 
            this.txtNumeroBanco.Location = new System.Drawing.Point(6, 32);
            this.txtNumeroBanco.MaxLength = 20;
            this.txtNumeroBanco.Name = "txtNumeroBanco";
            this.txtNumeroBanco.Size = new System.Drawing.Size(157, 23);
            this.txtNumeroBanco.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 12);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 17);
            this.label24.TabIndex = 6;
            this.label24.Text = "Nro Banco";
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
            // UsrTipoEmpresa
            // 
            this.UsrTipoEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrTipoEmpresa.Location = new System.Drawing.Point(5, 2);
            this.UsrTipoEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.UsrTipoEmpresa.Modificou = false;
            this.UsrTipoEmpresa.Name = "UsrTipoEmpresa";
            this.UsrTipoEmpresa.Size = new System.Drawing.Size(423, 53);
            this.UsrTipoEmpresa.TabIndex = 0;
            // 
            // UsrCidade
            // 
            this.UsrCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrCidade.Location = new System.Drawing.Point(5, 96);
            this.UsrCidade.Margin = new System.Windows.Forms.Padding(4);
            this.UsrCidade.Modificou = false;
            this.UsrCidade.Name = "UsrCidade";
            this.UsrCidade.Size = new System.Drawing.Size(386, 53);
            this.UsrCidade.TabIndex = 5;
            this.UsrCidade.Leave += new System.EventHandler(this.UsrCidade_Leave);
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 478);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFornecedor";
            this.Text = "Fornecedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFornecedor_FormClosed);
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
            this.tpBanco.ResumeLayout(false);
            this.tpBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInscEstadual;
        private System.Windows.Forms.Label label8;
        private Objetos.ucCNPJ txtCNPJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tpEndereco;
        private System.Windows.Forms.TabPage tpCompl;
        private System.Windows.Forms.TabPage tpBanco;
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
        private System.Windows.Forms.Label label28;
        private Objetos.ucCPF txtCPF;
        private System.Windows.Forms.TextBox txtNomeDepositante;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtNomeTitular;
        private System.Windows.Forms.TextBox txtNroConta;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNroAgencia;
        private System.Windows.Forms.TextBox txtNomeBanco;
        private System.Windows.Forms.TextBox txtNumeroBanco;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insc_Estadual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private PesquisasGerais.UsrPesquisa UsrTipoEmpresa;
        private PesquisasGerais.UsrPesquisa UsrCidade;
    }
}