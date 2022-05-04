using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    [Serializable]

    public class Compromissos : EntidadeBase
    {
        public string assunto;
        public string local;
        public string dataCompromisso;
        public Contato contato;

        public override string ToString()
        {
            return $"Compromisso {assunto} | Local: {local} | Dia {dataCompromisso} | " +
                $"Contato: {contato.Nome}";
        }

    }
}
