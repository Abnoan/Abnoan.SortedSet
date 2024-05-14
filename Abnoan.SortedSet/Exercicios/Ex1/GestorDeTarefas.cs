using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.SortedSet.Exercicios.Ex1
{
    public class GestorDeTarefas
    {
        private SortedSet<Tarefa> tarefas;

        public GestorDeTarefas()
        {
            tarefas = new SortedSet<Tarefa>(new ComparadorDeTarefas());
        }

        public void AdicionarTarefa(string descricao, int prioridade)
        {
            tarefas.Add(new Tarefa(descricao, prioridade));
        }

        public void ListarTarefas()
        {
            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"{tarefa.Prioridade}: {tarefa.Descricao}");
            }
        }
    }
}