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
        private int caixaSelecionada = 1;
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

        private void checkBoxBaixa_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNormal.Checked = false;
            checkBoxAlta.Checked = false;
            caixaSelecionada = 1;
        }

        private void checkBoxNormal_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAlta.Checked = false;
            checkBoxBaixa.Checked = false;
            caixaSelecionada = 2;
        }

        private void checkBoxAlta_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxBaixa.Checked = false;
            checkBoxNormal.Checked = false;
            caixaSelecionada = 3;
        }

        
        private void botaoGravar_Click(object sender, EventArgs e)
        {
            if(textoTitulo.Text == string.Empty)
            {
                MessageBox.Show("Não é possivel registrar uma tarefa sem titulo!!!",
               "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            tarefa.Titulo = textoTitulo.Text;
            tarefa.Prioridade = caixaSelecionada;
           
        }

       
    }
}
