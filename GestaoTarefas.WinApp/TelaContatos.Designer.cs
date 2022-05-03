namespace GestaoTarefas.WinApp
{
    partial class TelaContatos
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEmpresa = new System.Windows.Forms.TextBox();
            this.comboCargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 24);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(46, 15);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empresa:";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(62, 16);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(206, 23);
            this.textNome.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(62, 47);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(206, 23);
            this.textEmail.TabIndex = 5;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(62, 79);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(206, 23);
            this.textTelefone.TabIndex = 6;
            // 
            // textEmpresa
            // 
            this.textEmpresa.Location = new System.Drawing.Point(62, 108);
            this.textEmpresa.Name = "textEmpresa";
            this.textEmpresa.Size = new System.Drawing.Size(206, 23);
            this.textEmpresa.TabIndex = 7;
            // 
            // comboCargo
            // 
            this.comboCargo.FormattingEnabled = true;
            this.comboCargo.Items.AddRange(new object[] {
            "Gerente",
            "Auxiliar",
            "Estagiario",
            "Operario",
            "Programador"});
            this.comboCargo.Location = new System.Drawing.Point(62, 137);
            this.comboCargo.Name = "comboCargo";
            this.comboCargo.Size = new System.Drawing.Size(121, 23);
            this.comboCargo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cargo:";
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancelar.Location = new System.Drawing.Point(189, 179);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 11;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // botaoGravar
            // 
            this.botaoGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botaoGravar.Location = new System.Drawing.Point(108, 179);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 23);
            this.botaoGravar.TabIndex = 10;
            this.botaoGravar.Text = "Gravar";
            this.botaoGravar.UseVisualStyleBackColor = true;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // TelaContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 218);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboCargo);
            this.Controls.Add(this.textEmpresa);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeLabel);
            this.Name = "TelaContatos";
            this.Text = "TelaContatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEmpresa;
        private System.Windows.Forms.ComboBox comboCargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoGravar;
    }
}