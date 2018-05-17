namespace Compi
{
    partial class FormaPrincipal
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
            this.btnCompilar = new System.Windows.Forms.Button();
            this.tablaResultados = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Texto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCompilar
            // 
            this.btnCompilar.Location = new System.Drawing.Point(457, 12);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(75, 23);
            this.btnCompilar.TabIndex = 1;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            this.btnCompilar.Click += new System.EventHandler(this.btnCompilar_Click);
            // 
            // tablaResultados
            // 
            this.tablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema,
            this.Renglon});
            this.tablaResultados.Location = new System.Drawing.Point(552, 12);
            this.tablaResultados.Name = "tablaResultados";
            this.tablaResultados.Size = new System.Drawing.Size(355, 357);
            this.tablaResultados.TabIndex = 2;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // Renglon
            // 
            this.Renglon.HeaderText = "Renglon";
            this.Renglon.Name = "Renglon";
            // 
            // txb_Texto
            // 
            this.txb_Texto.Location = new System.Drawing.Point(13, 13);
            this.txb_Texto.Multiline = true;
            this.txb_Texto.Name = "txb_Texto";
            this.txb_Texto.Size = new System.Drawing.Size(423, 471);
            this.txb_Texto.TabIndex = 3;
            // 
            // FormaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 528);
            this.Controls.Add(this.txb_Texto);
            this.Controls.Add(this.tablaResultados);
            this.Controls.Add(this.btnCompilar);
            this.Name = "FormaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.DataGridView tablaResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renglon;
        private System.Windows.Forms.TextBox txb_Texto;
    }
}

