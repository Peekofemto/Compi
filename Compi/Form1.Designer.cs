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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaPrincipal));
            this.tablaResultados = new System.Windows.Forms.DataGridView();
            this.TablaErrores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gpbErrores = new System.Windows.Forms.GroupBox();
            this.TokenError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LexemaError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineaError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Renglon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MetroBtnLexico = new MetroFramework.Controls.MetroButton();
            this.MetroBtnSintactico = new MetroFramework.Controls.MetroButton();
            this.txb_Texto = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaErrores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpbErrores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaResultados
            // 
            this.tablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema,
            this.Renglon});
            this.tablaResultados.Location = new System.Drawing.Point(6, 19);
            this.tablaResultados.Name = "tablaResultados";
            this.tablaResultados.Size = new System.Drawing.Size(959, 381);
            this.tablaResultados.TabIndex = 2;
            // 
            // TablaErrores
            // 
            this.TablaErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TokenError,
            this.LexemaError,
            this.LineaError});
            this.TablaErrores.Location = new System.Drawing.Point(6, 17);
            this.TablaErrores.Name = "TablaErrores";
            this.TablaErrores.Size = new System.Drawing.Size(959, 371);
            this.TablaErrores.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tablaResultados);
            this.groupBox1.Location = new System.Drawing.Point(593, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lexico";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gpbErrores
            // 
            this.gpbErrores.Controls.Add(this.TablaErrores);
            this.gpbErrores.Location = new System.Drawing.Point(591, 472);
            this.gpbErrores.Name = "gpbErrores";
            this.gpbErrores.Size = new System.Drawing.Size(971, 400);
            this.gpbErrores.TabIndex = 6;
            this.gpbErrores.TabStop = false;
            this.gpbErrores.Text = "Errores";
            // 
            // TokenError
            // 
            this.TokenError.HeaderText = "Token";
            this.TokenError.Name = "TokenError";
            this.TokenError.Width = 250;
            // 
            // LexemaError
            // 
            this.LexemaError.HeaderText = "Lexema";
            this.LexemaError.Name = "LexemaError";
            this.LexemaError.Width = 250;
            // 
            // LineaError
            // 
            this.LineaError.HeaderText = "Línea";
            this.LineaError.Name = "LineaError";
            this.LineaError.Width = 250;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.Width = 250;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            this.Lexema.Width = 250;
            // 
            // Renglon
            // 
            this.Renglon.HeaderText = "Renglon";
            this.Renglon.Name = "Renglon";
            this.Renglon.Width = 250;
            // 
            // MetroBtnLexico
            // 
            this.MetroBtnLexico.Location = new System.Drawing.Point(241, 31);
            this.MetroBtnLexico.Name = "MetroBtnLexico";
            this.MetroBtnLexico.Size = new System.Drawing.Size(75, 23);
            this.MetroBtnLexico.TabIndex = 8;
            this.MetroBtnLexico.Text = "Lexico";
            this.MetroBtnLexico.Click += new System.EventHandler(this.MetroBtnLexico_Click);
            // 
            // MetroBtnSintactico
            // 
            this.MetroBtnSintactico.Location = new System.Drawing.Point(331, 31);
            this.MetroBtnSintactico.Name = "MetroBtnSintactico";
            this.MetroBtnSintactico.Size = new System.Drawing.Size(75, 23);
            this.MetroBtnSintactico.TabIndex = 9;
            this.MetroBtnSintactico.Text = "Sintactico";
            this.MetroBtnSintactico.Click += new System.EventHandler(this.MetroBtnSintactico_Click);
            // 
            // txb_Texto
            // 
            this.txb_Texto.Location = new System.Drawing.Point(23, 63);
            this.txb_Texto.Multiline = true;
            this.txb_Texto.Name = "txb_Texto";
            this.txb_Texto.Size = new System.Drawing.Size(562, 797);
            this.txb_Texto.TabIndex = 10;
            this.txb_Texto.Text = "Código";
            // 
            // FormaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 882);
            this.Controls.Add(this.txb_Texto);
            this.Controls.Add(this.MetroBtnSintactico);
            this.Controls.Add(this.MetroBtnLexico);
            this.Controls.Add(this.gpbErrores);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaPrincipal";
            this.Text = "Analizador Golang";
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaErrores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gpbErrores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaResultados;
        private System.Windows.Forms.DataGridView TablaErrores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn TokenError;
        private System.Windows.Forms.DataGridViewTextBoxColumn LexemaError;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineaError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renglon;
        private MetroFramework.Controls.MetroButton MetroBtnLexico;
        private MetroFramework.Controls.MetroButton MetroBtnSintactico;
        private MetroFramework.Controls.MetroTextBox txb_Texto;
    }
}

