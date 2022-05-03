namespace GestaoTarefas.WinApp
{
    partial class ListagemTarefasFormcs
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
            this.botaoInserir = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoCadastrarItens = new System.Windows.Forms.Button();
            this.botaoAtualizarItens = new System.Windows.Forms.Button();
            this.caixaDeListaDeTarefas = new System.Windows.Forms.ListBox();
            this.botaoContatos = new System.Windows.Forms.Button();
            this.caixaDeListaDeContatos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoEditarContato = new System.Windows.Forms.Button();
            this.botaoExcluirContato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoInserir
            // 
            this.botaoInserir.Location = new System.Drawing.Point(658, 31);
            this.botaoInserir.Name = "botaoInserir";
            this.botaoInserir.Size = new System.Drawing.Size(108, 23);
            this.botaoInserir.TabIndex = 0;
            this.botaoInserir.Text = "Inserir Tarefas";
            this.botaoInserir.UseVisualStyleBackColor = true;
            this.botaoInserir.Click += new System.EventHandler(this.botaoInserir_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(658, 60);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(108, 23);
            this.botaoEditar.TabIndex = 1;
            this.botaoEditar.Text = "Editar Tarefas";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(658, 89);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(108, 23);
            this.botaoExcluir.TabIndex = 2;
            this.botaoExcluir.Text = "Excluir Tarefas";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // botaoCadastrarItens
            // 
            this.botaoCadastrarItens.Location = new System.Drawing.Point(658, 118);
            this.botaoCadastrarItens.Name = "botaoCadastrarItens";
            this.botaoCadastrarItens.Size = new System.Drawing.Size(139, 23);
            this.botaoCadastrarItens.TabIndex = 3;
            this.botaoCadastrarItens.Text = "Cadastrar Itens Tarefas";
            this.botaoCadastrarItens.UseVisualStyleBackColor = true;
            this.botaoCadastrarItens.Click += new System.EventHandler(this.botaoCadastrarItens_Click);
            // 
            // botaoAtualizarItens
            // 
            this.botaoAtualizarItens.Location = new System.Drawing.Point(658, 147);
            this.botaoAtualizarItens.Name = "botaoAtualizarItens";
            this.botaoAtualizarItens.Size = new System.Drawing.Size(130, 23);
            this.botaoAtualizarItens.TabIndex = 4;
            this.botaoAtualizarItens.Text = "Atualizar Itens Tarefas";
            this.botaoAtualizarItens.UseVisualStyleBackColor = true;
            this.botaoAtualizarItens.Click += new System.EventHandler(this.botaoAtualizarItens_Click);
            // 
            // caixaDeListaDeTarefas
            // 
            this.caixaDeListaDeTarefas.FormattingEnabled = true;
            this.caixaDeListaDeTarefas.ItemHeight = 15;
            this.caixaDeListaDeTarefas.Location = new System.Drawing.Point(12, 26);
            this.caixaDeListaDeTarefas.Name = "caixaDeListaDeTarefas";
            this.caixaDeListaDeTarefas.Size = new System.Drawing.Size(628, 154);
            this.caixaDeListaDeTarefas.TabIndex = 5;
            // 
            // botaoContatos
            // 
            this.botaoContatos.Location = new System.Drawing.Point(658, 231);
            this.botaoContatos.Name = "botaoContatos";
            this.botaoContatos.Size = new System.Drawing.Size(127, 23);
            this.botaoContatos.TabIndex = 6;
            this.botaoContatos.Text = "Inserir Contatos ";
            this.botaoContatos.UseVisualStyleBackColor = true;
            this.botaoContatos.Click += new System.EventHandler(this.botaoContatos_Click);
            // 
            // caixaDeListaDeContatos
            // 
            this.caixaDeListaDeContatos.FormattingEnabled = true;
            this.caixaDeListaDeContatos.ItemHeight = 15;
            this.caixaDeListaDeContatos.Location = new System.Drawing.Point(12, 220);
            this.caixaDeListaDeContatos.Name = "caixaDeListaDeContatos";
            this.caixaDeListaDeContatos.Size = new System.Drawing.Size(628, 184);
            this.caixaDeListaDeContatos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, -5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "TAREFAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "CONTATOS";
            // 
            // botaoEditarContato
            // 
            this.botaoEditarContato.Location = new System.Drawing.Point(658, 260);
            this.botaoEditarContato.Name = "botaoEditarContato";
            this.botaoEditarContato.Size = new System.Drawing.Size(127, 23);
            this.botaoEditarContato.TabIndex = 12;
            this.botaoEditarContato.Text = "Editar Contatos ";
            this.botaoEditarContato.UseVisualStyleBackColor = true;
            this.botaoEditarContato.Click += new System.EventHandler(this.botaoEditarContato_Click);
            // 
            // botaoExcluirContato
            // 
            this.botaoExcluirContato.Location = new System.Drawing.Point(658, 289);
            this.botaoExcluirContato.Name = "botaoExcluirContato";
            this.botaoExcluirContato.Size = new System.Drawing.Size(127, 23);
            this.botaoExcluirContato.TabIndex = 13;
            this.botaoExcluirContato.Text = "Excluir Contato";
            this.botaoExcluirContato.UseVisualStyleBackColor = true;
            this.botaoExcluirContato.Click += new System.EventHandler(this.botaoExcluirContato_Click);
            // 
            // ListagemTarefasFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.botaoExcluirContato);
            this.Controls.Add(this.botaoEditarContato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixaDeListaDeContatos);
            this.Controls.Add(this.botaoContatos);
            this.Controls.Add(this.caixaDeListaDeTarefas);
            this.Controls.Add(this.botaoAtualizarItens);
            this.Controls.Add(this.botaoCadastrarItens);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.botaoInserir);
            this.Name = "ListagemTarefasFormcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestao de Tarefas 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoInserir;
        private System.Windows.Forms.Button botaoEditar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoCadastrarItens;
        private System.Windows.Forms.Button botaoAtualizarItens;
        private System.Windows.Forms.ListBox caixaDeListaDeTarefas;
        private System.Windows.Forms.Button botaoContatos;
        private System.Windows.Forms.ListBox caixaDeListaDeContatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoEditarContato;
        private System.Windows.Forms.Button botaoExcluirContato;
    }
}