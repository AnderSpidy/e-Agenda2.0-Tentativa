using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class RepositorioCompromisso : RepositorioBase<Compromissos>
    {
        private const string EAgendaCompromisso = @"C:\temp\EAgendaCompromisso.bin";
        private int contador = 0;
        List<Compromissos> compromissos;

        public RepositorioCompromisso()
        {
            registros = CarregarRegistrosDoArquivo(EAgendaCompromisso);

            contador = registros.Count;
        }
        public override void Inserir(Compromissos compromisso)
        {
            compromisso.Numero = ++contador;
            registros.Add(compromisso);
            GravarRegistrosEmArquivo();
        }

        public override void Editar(Compromissos compromisso)
        {
            foreach (var item in registros)
            {
                if (item.Numero == compromisso.Numero)
                {
                    item.Assunto = compromisso.Assunto;
                    item.Local = compromisso.Local;
                    item.DataCompromisso = compromisso.DataCompromisso;
                    item.HoraInicio = compromisso.HoraInicio;
                    item.HoraTermino = compromisso.HoraTermino;
                    break;
                }
            }
            GravarRegistrosEmArquivo();
        }

        public override void Excluir(Compromissos compromisso)
        {
            compromisso.Contato.compromisso = false;
            registros.Remove(compromisso);
            GravarRegistrosEmArquivo();
        }

        public List<Compromissos> SelecionarTodos()
        {
            compromissos = new List<Compromissos>();

            foreach (Compromissos c in registros)
            {
                compromissos.Add(c);
            }
            return compromissos;
        }

        public void GravarRegistrosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream ms = new MemoryStream();

            serializador.Serialize(ms, registros);

            byte[] bytes = ms.ToArray();

            File.WriteAllBytes(EAgendaCompromisso, ms.ToArray());
        }
    }
}
