using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class ListagemTarefasFormcs : Form
    {
        private RepositorioTarefa repositorioTarefa;
        private RepositorioContato repositorioContato;
        private RepositorioCompromisso repositorioCompromisso;
        public ListagemTarefasFormcs()
        {
            repositorioTarefa = new RepositorioTarefa();
            repositorioContato = new RepositorioContato();
            repositorioCompromisso = new RepositorioCompromisso();
            InitializeComponent();
            CarreagarTarefas();
            CarregarTarefasConcluidas();
            CarreagarContatos();
            CarregarCompromissos();


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
        private void CarregarTarefasConcluidas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodosConcluidos();
            caixaDeListaDeTarefasConcluidas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {

                caixaDeListaDeTarefasConcluidas.Items.Add(t);
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
        private void CarregarCompromissos()
        {
            List<Compromissos> compromissos = repositorioCompromisso.SelecionarTodos();
            caixadeListaDeCompromisso.Items.Clear();

            foreach (Compromissos c in compromissos)
            {
                caixadeListaDeCompromisso.Items.Add(c);
            }
        }

        private void botaoInserir_Click(object sender, EventArgs e)
        {
            CadastroTarefa tela = new CadastroTarefa();
            
            tela.Tarefa = new Tarefa();
            DialogResult resultado =DialogResult.None;
            do
            {
                resultado = tela.ShowDialog();
                if (resultado == DialogResult.Cancel)
                    break;


            } while (tela.Tarefa.Titulo == null);
            

            if(resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarreagarTarefas();
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();
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
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();

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
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();


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
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();

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
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();


            }
        }

        private void botaoContatos_Click(object sender, EventArgs e)
        {
            TelaContatos tela = new TelaContatos();
            tela.Contato = new Contato();
            DialogResult resultado = DialogResult.None;

            string resultadoValidacao = "";
            do
            {
                resultado = tela.ShowDialog();
                resultadoValidacao = tela.Contato.Validar();
                if (resultado == DialogResult.Cancel)
                    break;
            
            if (resultadoValidacao != "REGISTRO_VALIDO")
            {
                MessageBox.Show(resultadoValidacao,
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Contato cadastrado com sucesso!",
                "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            } while (resultadoValidacao != "REGISTRO_VALIDO");

            if (resultado == DialogResult.OK)
            {
                repositorioContato.Inserir(tela.Contato);
                CarreagarTarefas();
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();

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
            DialogResult resultado = DialogResult.None;
            if (resultado == DialogResult.OK)
            {
                repositorioContato.Editar(tela.Contato);
                CarreagarTarefas();
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();

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
            else if (contatoSelecionado.compromisso == true)
            {
                MessageBox.Show("Não é possivel excluir um contato que tenha um compromisso",
               "Exclusão de Contato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            DialogResult resultado = MessageBox.Show("Deseja Realmente excluir o Contato?",
                "Exclusão de Contato", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                repositorioContato.Excluir(contatoSelecionado);
                CarreagarTarefas();
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();

            }

        }

        private void botaoInserirCompromissos_Click(object sender, EventArgs e)
        {
            Contato contatoSelecionado = (Contato)caixaDeListaDeContatos.SelectedItem;
            
            if (contatoSelecionado == null)
            {
                MessageBox.Show("Selecione um Contato Primeiro!!!",
                "Edição de Compromissos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CadastroCompromisso tela = new CadastroCompromisso(contatoSelecionado);
            tela.Compromissos = new Compromissos();
            tela.Compromissos.Contato = contatoSelecionado;
            DialogResult resultado = DialogResult.None;
            
            string resultadoValidacao = "";
            do
            {
                resultado = tela.ShowDialog();
                //resultado = tela.ShowDialog();
                //if (resultado == DialogResult.Cancel)
                //    break;
                resultadoValidacao = tela.Compromissos.Validar();
                if (resultado == DialogResult.Cancel)
                    break;

                if (resultadoValidacao != "REGISTRO_VALIDO")
                {
                    MessageBox.Show(resultadoValidacao,
                    "Edição de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Compromisso cadastrado com sucesso!",
                    "Edição de Contatos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } while (resultadoValidacao != "REGISTRO_VALIDO");



            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Inserir(tela.Compromissos);
                CarreagarTarefas();
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();


            }



        }

        private void botaoEditarCompromissos_Click(object sender, EventArgs e)
        {
            Compromissos compromissoSelecionado = (Compromissos)caixadeListaDeCompromisso.SelectedItem;
            CadastroCompromisso tela = new CadastroCompromisso();
            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um Compromisso Primeiro!!!",
                "Edição de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tela.Compromissos = compromissoSelecionado;
            DialogResult resultado = tela.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Editar(tela.Compromissos);
                CarreagarTarefas();
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();

            }

        }

        private void botaoExcluirCompromissos_Click(object sender, EventArgs e)
        {
            Compromissos compromissoSelecionado = (Compromissos)caixadeListaDeCompromisso.SelectedItem;
            if (compromissoSelecionado == null)
            {
                MessageBox.Show("Selecione um Compromisso Primeiro!!!",
                "Exclusão de Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja Realmente excluir o Compromisso?",
                "Exclusão de Compromisso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                repositorioCompromisso.Excluir(compromissoSelecionado);
                CarreagarTarefas();
                CarregarTarefasConcluidas();
                CarreagarContatos();
                CarregarCompromissos();

            }

        }

       
    }
}
