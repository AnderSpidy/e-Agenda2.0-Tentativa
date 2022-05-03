using System;

namespace GestaoTarefas.WinApp
{
    [Serializable]

    public class ItemTarefa
    {
        public string Titulo { get; internal set; }
        public bool Concluida { get; private set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void Concluir()
        {
            Concluida = true;

        }

        public void MarcarPendente()
        {
            Concluida = false;
        }
    }
}