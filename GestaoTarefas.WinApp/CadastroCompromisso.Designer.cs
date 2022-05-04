namespace GestaoTarefas.WinApp
{
    partial class CadastroCompromisso
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
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.labelCompromisso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoAssunto = new System.Windows.Forms.TextBox();
            this.textoLocal = new System.Windows.Forms.TextBox();
            this.textoData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancelar.Location = new System.Drawing.Point(209, 127);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 13;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // botaoGravar
            // 
            this.botaoGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botaoGravar.Location = new System.Drawing.Point(128, 127);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 23);
            this.botaoGravar.TabIndex = 12;
            this.botaoGravar.Text = "Gravar";
            this.botaoGravar.UseVisualStyleBackColor = true;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // labelCompromisso
            // 
            this.labelCompromisso.AutoSize = true;
            this.labelCompromisso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCompromisso.Location = new System.Drawing.Point(71, 9);
            this.labelCompromisso.Name = "labelCompromisso";
            this.labelCompromisso.Size = new System.Drawing.Size(132, 15);
            this.labelCompromisso.TabIndex = 16;
            this.labelCompromisso.Text = " [Contato Selecionado]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Assunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Local:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Data do Compromisso:";
            // 
            // textoAssunto
            // 
            this.textoAssunto.Location = new System.Drawing.Point(71, 27);
            this.textoAssunto.Name = "textoAssunto";
            this.textoAssunto.Size = new System.Drawing.Size(206, 23);
            this.textoAssunto.TabIndex = 21;
            // 
            // textoLocal
            // 
            this.textoLocal.Location = new System.Drawing.Point(71, 56);
            this.textoLocal.Name = "textoLocal";
            this.textoLocal.Size = new System.Drawing.Size(206, 23);
            this.textoLocal.TabIndex = 22;
            // 
            // textoData
            // 
            this.textoData.Location = new System.Drawing.Point(147, 85);
            this.textoData.Name = "textoData";
            this.textoData.Size = new System.Drawing.Size(130, 23);
            this.textoData.TabIndex = 23;
            // 
            // CadastroCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 160);
            this.Controls.Add(this.textoData);
            this.Controls.Add(this.textoLocal);
            this.Controls.Add(this.textoAssunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCompromisso);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoGravar);
            this.Name = "CadastroCompromisso";
            this.Text = "Cadastro de Compromisso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.Label labelCompromisso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoAssunto;
        private System.Windows.Forms.TextBox textoLocal;
        private System.Windows.Forms.TextBox textoData;
    }
}