using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.SortedSet.Exercicios.Ex1
{
    public class ComparadorDeTarefas : IComparer<Tarefa>
    {
        public int Compare(Tarefa x, Tarefa y)
        {
            return x.Prioridade.CompareTo(y.Prioridade);
        }
    }
}