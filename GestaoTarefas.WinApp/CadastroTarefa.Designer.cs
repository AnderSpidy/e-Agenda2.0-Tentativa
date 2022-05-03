namespace GestaoTarefas.WinApp
{
    partial class CadastroTarefa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitulo = new System.Windows.Forms.TextBox();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.checkBoxBaixa = new System.Windows.Forms.CheckBox();
            this.checkBoxNormal = new System.Windows.Forms.CheckBox();
            this.checkBoxAlta = new System.Windows.Forms.CheckBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prioridade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título:";
            // 
            // textoTitulo
            // 
            this.textoTitulo.Location = new System.Drawing.Point(72, 92);
            this.textoTitulo.Name = "textoTitulo";
            this.textoTitulo.Size = new System.Drawing.Size(339, 23);
            this.textoTitulo.TabIndex = 3;
            // 
            // botaoGravar
            // 
            this.botaoGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botaoGravar.Location = new System.Drawing.Point(255, 204);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 23);
            this.botaoGravar.TabIndex = 4;
            this.botaoGravar.Text = "Gravar";
            this.botaoGravar.UseVisualStyleBackColor = true;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancelar.Location = new System.Drawing.Point(336, 204);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 5;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // checkBoxBaixa
            // 
            this.checkBoxBaixa.AutoSize = true;
            this.checkBoxBaixa.Location = new System.Drawing.Point(89, 61);
            this.checkBoxBaixa.Name = "checkBoxBaixa";
            this.checkBoxBaixa.Size = new System.Drawing.Size(54, 19);
            this.checkBoxBaixa.TabIndex = 6;
            this.checkBoxBaixa.Text = "Baixa";
            this.checkBoxBaixa.UseVisualStyleBackColor = true;
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.Location = new System.Drawing.Point(161, 61);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(66, 19);
            this.checkBoxNormal.TabIndex = 7;
            this.checkBoxNormal.Text = "Normal";
            this.checkBoxNormal.UseVisualStyleBackColor = true;
            this.checkBoxNormal.CheckedChanged += new System.EventHandler(this.checkBoxNormal_CheckedChanged);
            // 
            // checkBoxAlta
            // 
            this.checkBoxAlta.AutoSize = true;
            this.checkBoxAlta.Location = new System.Drawing.Point(250, 61);
            this.checkBoxAlta.Name = "checkBoxAlta";
            this.checkBoxAlta.Size = new System.Drawing.Size(47, 19);
            this.checkBoxAlta.TabIndex = 8;
            this.checkBoxAlta.Text = "Alta";
            this.checkBoxAlta.UseVisualStyleBackColor = true;
            this.checkBoxAlta.CheckedChanged += new System.EventHandler(this.checkBoxAlta_CheckedChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Enabled = false;
            this.textoNumero.Location = new System.Drawing.Point(69, 18);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(36, 23);
            this.textoNumero.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero:";
            // 
            // CadastroTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 239);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.checkBoxAlta);
            this.Controls.Add(this.checkBoxNormal);
            this.Controls.Add(this.checkBoxBaixa);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoGravar);
            this.Controls.Add(this.textoTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroTarefa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro de Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTitulo;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.CheckBox checkBoxBaixa;
        private System.Windows.Forms.CheckBox checkBoxNormal;
        private System.Windows.Forms.CheckBox checkBoxAlta;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label3;
    }
}