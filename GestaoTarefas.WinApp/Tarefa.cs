using System;
using System.Collections.Generic;
using System.Linq;

namespace GestaoTarefas.WinApp
{
    [Serializable]

    public class Tarefa : EntidadeBase
    {
        public int Prioridade { get; set; }

        private List<ItemTarefa> itens = new List<ItemTarefa>();
        public Tarefa(int n, string t) : this()
        {
            Numero = n;
            Titulo = t;
            DataConclusao = null;
        }

        public Tarefa()
        {
            DataCriacao = DateTime.Now;
        }

        public int Numero { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        public List<ItemTarefa> Itens { get { return itens; } }
        
        public override string ToString()
        {
            var percentual = CalcularPercentualConcluido();
            string strPrioridade="";
            if (Prioridade == 3)
                strPrioridade = "ALTA";
            else if (Prioridade == 2)
                strPrioridade = "NORMAL";

            else strPrioridade = "BAIXO";

            if (DataConclusao.HasValue)
            {
                return $"Título: {Titulo} | Prioridade: {strPrioridade}" +
                $" | Conclusão: {DataConclusao.Value.ToShortDateString()}";
            }

            return $"Título: {Titulo} | Prioridade: {strPrioridade}" +
                $" | Criação: {DataCriacao.ToShortDateString()}" +
                $" | Conclusão: {percentual} %";
        }

        public void AdicionarItem(ItemTarefa item)
        {
            if(Itens.Exists(x=>x.Equals(item)) == false)
            itens.Add(item);

        }

        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));
            itemTarefa.Concluir();
            var percentual = CalcularPercentualConcluido();
            if(percentual == 100)
            {
                DataConclusao = DateTime.Now;
            }
        }
        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = itens.Find(x => x.Equals(item));
            itemTarefa.MarcarPendente();

        }
        public decimal CalcularPercentualConcluido()
        {
            if (itens.Count == 0)
                return 0;
            
            int qtdConcluidas = itens.Count(x => x.Concluida);
            var percentualConcluido = (qtdConcluidas / (decimal)itens.Count()) * 100;

            return Math.Round(percentualConcluido, 2);
        }
    }
}