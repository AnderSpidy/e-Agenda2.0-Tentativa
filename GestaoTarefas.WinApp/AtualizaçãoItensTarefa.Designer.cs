namespace GestaoTarefas.WinApp
{
    partial class AtualizaçãoItensTarefa
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
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoGravar = new System.Windows.Forms.Button();
            this.ListItensTarefas = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloTarefa.Location = new System.Drawing.Point(56, 9);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(88, 15);
            this.labelTituloTarefa.TabIndex = 15;
            this.labelTituloTarefa.Text = " [Titulo Tarefa]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tarefa: ";
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancelar.Location = new System.Drawing.Point(320, 220);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 17;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // botaoGravar
            // 
            this.botaoGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botaoGravar.Location = new System.Drawing.Point(239, 220);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 23);
            this.botaoGravar.TabIndex = 16;
            this.botaoGravar.Text = "Gravar";
            this.botaoGravar.UseVisualStyleBackColor = true;
            // 
            // ListItensTarefas
            // 
            this.ListItensTarefas.FormattingEnabled = true;
            this.ListItensTarefas.Location = new System.Drawing.Point(12, 27);
            this.ListItensTarefas.Name = "ListItensTarefas";
            this.ListItensTarefas.Size = new System.Drawing.Size(383, 184);
            this.ListItensTarefas.TabIndex = 18;
            // 
            // AtualizaçãoItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 255);
            this.Controls.Add(this.ListItensTarefas);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoGravar);
            this.Controls.Add(this.labelTituloTarefa);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AtualizaçãoItensTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualização dos Itens da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTituloTarefa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.CheckedListBox ListItensTarefas;
    }
}