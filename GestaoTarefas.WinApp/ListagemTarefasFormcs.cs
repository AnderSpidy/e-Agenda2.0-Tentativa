using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemTarefasFormcs : Form
    {
        private RepositorioTarefa repositorioTarefa;
        private RepositorioContato repositorioContato;
        public ListagemTarefasFormcs()
        {
            repositorioTarefa = new RepositorioTarefa();
            repositorioContato = new RepositorioContato();
            InitializeComponent();
            CarreagarTarefas();
            CarreagarContatos();

        }

        private void CarreagarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();
            caixaDeListaDeTarefas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {
                caixaDeListaDeTarefas.Items.Add(t);
            }
        }

        private void CarreagarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();
            caixaDeListaDeContatos.Items.Clear();

            foreach (Contato t in contatos)
            {
                caixaDeListaDeContatos.Items.Add(t);
            }
        }

        private void botaoInserir_Click(object sender, EventArgs e)
        {
            CadastroTarefa tela = new CadastroTarefa();
            tela.Tarefa = new Tarefa();
            DialogResult resultado = tela.ShowDialog();

            if(resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarreagarTarefas();
                CarreagarContatos();
            }
        }
    

        private void botaoEditar_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)caixaDeListaDeTarefas.SelectedItem;
            CadastroTarefa tela = new CadastroTarefa();
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Tarefa Primeiro!!!",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tela.Tarefa = tarefaSelecionada;
            DialogResult resultado = tela.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarreagarTarefas();
                CarreagarContatos();

            }
        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)caixaDeListaDeTarefas.SelectedItem;
            if(tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Tarefa Primeiro!!!",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja Realmente excluir a Tarefa?", 
                "Exclusão de Tarefas",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarreagarTarefas();
                CarreagarContatos();


            }
        }

      

        private void botaoCadastrarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)caixaDeListaDeTarefas.SelectedItem;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Tarefa Primeiro!!!",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CadastroItensTarefa tela = new CadastroItensTarefa(tarefaSelecionada);
            
            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;

                repositorioTarefa.AdicionarItens(tarefaSelecionada, itens);

                CarreagarTarefas();
                CarreagarContatos();

            }
        }

        private void botaoAtualizarItens_Click(object sender, EventArgs e)
        {
            Tarefa tarefaSelecionada = (Tarefa)caixaDeListaDeTarefas.SelectedItem;
            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma Tarefa Primeiro!!!",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            AtualizaçãoItensTarefa tela = new AtualizaçãoItensTarefa(tarefaSelecionada);
            if (tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;
                List<ItemTarefa> itensPendentes = tela.ItensPendentes;

                repositorioTarefa.AtualizarItens(tarefaSelecionada, itensConcluidos, itensPendentes);
                CarreagarTarefas();
                CarreagarContatos();


            }
        }

        private void botaoContatos_Click(object sender, EventArgs e)
        {
            TelaContatos tela = new TelaContatos();
            tela.Contato = new Contato();
            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarreagarTarefas();
                CarreagarContatos();

            }
        }

        private void botaoEditarContato_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)caixaDeListaDeContatos.SelectedItem;
            TelaContatos tela = new TelaContatos();
            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um Contato Primeiro!!!",
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tela.Contato = contatoSelecionado;
            DialogResult resultado = tela.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarreagarTarefas();
                CarreagarContatos();
            }

        }

        private void botaoExcluirContato_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)caixaDeListaDeContatos.SelectedItem;
            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um Contato Primeiro!!!",
                "Exclusão de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja Realmente excluir o Contato?",
                "Exclusão de Contato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarreagarTarefas();
                CarreagarContatos();
            }

        }
    }
}
