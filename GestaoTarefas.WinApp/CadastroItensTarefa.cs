using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroItensTarefa : Form
    {
        public CadastroItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            labelTituloTarefa.Text = tarefa.Titulo;

            foreach (ItemTarefa item in tarefa.Itens)
            {
                listItensDaTarefa.Items.Add(item);
            }
        }

        internal List<ItemTarefa> ItensAdicionados 
        { 
            get
            {
                return listItensDaTarefa.Items.Cast<ItemTarefa>().ToList();

            } 
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {

        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            List<string> titulos = ItensAdicionados.Select(x => x.Titulo).ToList();
            if(titulos.Count == 0 || titulos.Contains(txtTitulo.Text) == false)
            {
                ItemTarefa itemTarefa = new ItemTarefa();

                itemTarefa.Titulo = txtTitulo.Text;

                listItensDaTarefa.Items.Add(itemTarefa);

            }
            
        }
    }
}
