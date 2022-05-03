namespace GestaoTarefas.WinApp
{
    partial class CadastroItensTarefa
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listItensDaTarefa = new System.Windows.Forms.ListBox();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancelar.Location = new System.Drawing.Point(215, 201);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 7;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // botaoGravar
            // 
            this.botaoGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botaoGravar.Location = new System.Drawing.Point(134, 201);
            this.botaoGravar.Name = "botaoGravar";
            this.botaoGravar.Size = new System.Drawing.Size(75, 23);
            this.botaoGravar.TabIndex = 6;
            this.botaoGravar.Text = "Gravar";
            this.botaoGravar.UseVisualStyleBackColor = true;
            this.botaoGravar.Click += new System.EventHandler(this.botaoGravar_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(56, 29);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(153, 23);
            this.txtTitulo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titulo: ";
            // 
            // listItensDaTarefa
            // 
            this.listItensDaTarefa.FormattingEnabled = true;
            this.listItensDaTarefa.ItemHeight = 15;
            this.listItensDaTarefa.Location = new System.Drawing.Point(12, 58);
            this.listItensDaTarefa.Name = "listItensDaTarefa";
            this.listItensDaTarefa.Size = new System.Drawing.Size(278, 139);
            this.listItensDaTarefa.TabIndex = 10;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(215, 28);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(75, 23);
            this.botaoAdicionar.TabIndex = 11;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tarefa: ";
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloTarefa.Location = new System.Drawing.Point(56, 9);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(88, 15);
            this.labelTituloTarefa.TabIndex = 13;
            this.labelTituloTarefa.Text = " [Titulo Tarefa]";
            // 
            // CadastroItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 233);
            this.Controls.Add(this.labelTituloTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.listItensDaTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CadastroItensTarefa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Itens da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoGravar;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItensDaTarefa;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTituloTarefa;
    }
}