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
    public partial class AtualizaçãoItensTarefa : Form
    {
        private Tarefa tarefa;

        public AtualizaçãoItensTarefa(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            labelTituloTarefa.Text = tarefa.Titulo;
            CarregarItensTarefas(tarefa);
        }

        private void CarregarItensTarefas(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                ListItensTarefas.Items.Add(item);

                if (item.Concluida)
                {
                    ListItensTarefas.SetItemChecked(i, true);
                    i++;
                }
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return ListItensTarefas.CheckedItems.Cast<ItemTarefa>().ToList();
            }
        }
        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return ListItensTarefas.CheckedItems.Cast<ItemTarefa>().Except(ItensConcluidos).ToList();
            }
        }

       
    }
}
