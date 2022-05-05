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
    public partial class TelaContatos : Form
    {
        private Contato contato = new Contato();
        public TelaContatos()
        {
            InitializeComponent();
        }
        public Contato Contato
        {
            get
            {
                return contato;
            }
            set
            {
                contato = value;
                textNome.Text = contato.Nome;
                textEmail.Text = contato.email;
                textTelefone.Text = contato.telefone;
                comboCargo.Text = contato.empresa;
  
            }
        }
        private void botaoGravar_Click(object sender, EventArgs e)
        {

            contato.Nome = textNome.Text;
            contato.email = textEmail.Text;
            contato.telefone = textTelefone.Text;
            contato.empresa = textEmpresa.Text;
            contato.cargo = comboCargo.Text;
        }
    }
}
