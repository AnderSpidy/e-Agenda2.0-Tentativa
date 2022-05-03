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
    public partial class CadastroTarefa : Form
    {
        private Tarefa tarefa;
        public CadastroTarefa()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                textoNumero.Text = tarefa.Numero.ToString();
                textoTitulo.Text = tarefa.Titulo;
                if (tarefa.Prioridade == 3)
                {
                    checkBoxAlta.Checked = true;
                }
                else if (tarefa.Prioridade == 2)
                {
                    checkBoxNormal.Checked = true;
                }
                else
                {
                    checkBoxBaixa.Checked = true;
                }


            }
        }
        
        

        private void checkBoxNormal_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.Prioridade = 2;
        }

        private void checkBoxAlta_CheckedChanged(object sender, EventArgs e)
        {
            tarefa.Prioridade = 3;
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = textoTitulo.Text;
           
        }

        
    }
}
