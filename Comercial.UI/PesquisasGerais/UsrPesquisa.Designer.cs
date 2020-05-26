namespace Comercial.UI.PesquisasGerais
{
    partial class UsrPesquisa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(1, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 23);
            this.txtId.TabIndex = 0;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(105, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(65, 24);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(34, 23);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.TabStop = false;
            this.btnPesquisa.Text = "...";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(-2, 4);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(48, 17);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Nome";
            // 
            // UsrPesquisa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsrPesquisa";
            this.Size = new System.Drawing.Size(498, 53);
            this.Enter += new System.EventHandler(this.UsrPesquisa_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.Label lblCodigo;
    }
}
