using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        private const string EAgendaContato = @"C:\temp\EAgendaContato.bin";
        private int contador = 0;
        List<Contato> contatos;

        public RepositorioContato()
        {
            registros = CarregarRegistrosDoArquivo(EAgendaContato);

            contador = registros.Count;
        }


        //Crud -------------------------------------------------------------
        public override void Inserir(Contato contato)
        {
            contato.Numero = ++contador;
            registros.Add(contato);
            GravarRegistrosEmArquivo();
        }

        public override void Editar(Contato contato)
        {
            foreach (var item in registros)
            {
                if (item.Numero == contato.Numero)
                {
                    item.nome = contato.nome;
                    item.email = contato.email;
                    item.telefone = contato.telefone;
                    item.empresa = contato.empresa;
                    item.cargo = contato.cargo;
                    break;
                }
            }
            GravarRegistrosEmArquivo();
        }
        
        public void EditarCompromisso(string nome)
        {
            foreach (var item in registros)
            {
                if (item.nome == nome)
                {
                    //item.compromisso = true;
                    break;
                }
            }
            GravarRegistrosEmArquivo();
        }
        
        public override void Excluir(Contato contato)
        {
           // if (contato.compromisso == false)
            //{
                registros.Remove(contato);
            //}
            GravarRegistrosEmArquivo();
        }
        
        //Metodos ----------------------------------------------------------
        public List<Contato> SelecionarTodos()
        {
            contatos = new List<Contato>();

            foreach (Contato c in registros)
            {
                contatos.Add(c);
            }
            return contatos;
        }

        public void GravarRegistrosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, registros);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(EAgendaContato, bytes);
        }
    }
}
