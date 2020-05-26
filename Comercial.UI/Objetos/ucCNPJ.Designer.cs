namespace Comercial.UI.Objetos
{
    partial class ucCNPJ
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
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Location = new System.Drawing.Point(0, 0);
            this.txtValor.Mask = "00,000,000/0000-00";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(108, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // ucCNPJ
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.txtValor);
            this.Name = "ucCNPJ";
            this.Size = new System.Drawing.Size(110, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox txtValor;
    }
}
