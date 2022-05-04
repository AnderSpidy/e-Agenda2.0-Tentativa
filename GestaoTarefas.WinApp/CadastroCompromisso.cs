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
    public partial class CadastroCompromisso : Form
    {
        private Compromissos compromisso = new Compromissos();

        public CadastroCompromisso()
        {
            InitializeComponent();
        }

        public CadastroCompromisso(Contato contato)
        {
            InitializeComponent();
            labelCompromisso.Text = contato.Nome;
        }
        public Compromissos Compromissos
        {
            get
            {
                return compromisso;
            }
            set
            {
                compromisso = value;
               textoAssunto.Text = compromisso.assunto;
                textoLocal.Text = compromisso.local;
                textoData.Text = compromisso.dataCompromisso;
               //labelCompromisso.Text = compromisso.contato.Nome;

                //NÃO TA FUNCIONANDO direito para inserir novos contatos NAO SEI O PORQUÊ talvez eu esteja cansado e nao consiga perceber 

            }
        }

        private void botaoGravar_Click(object sender, EventArgs e)
        {
            if (textoAssunto.Text == string.Empty || textoLocal.Text == String.Empty || textoLocal.Text == String.Empty)
            {
                MessageBox.Show("Todos os Campos devem ser preenchidos!!!",
               "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else { 
            compromisso.assunto = textoAssunto.Text;
            compromisso.local = textoLocal.Text;
            compromisso.dataCompromisso = textoData.Text;
            }
            
        }
    }
}
