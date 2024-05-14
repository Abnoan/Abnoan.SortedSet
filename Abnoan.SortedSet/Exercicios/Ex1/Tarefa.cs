using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.SortedSet.Exercicios.Ex1
{
public class Tarefa
{
    public string Descricao { get; set; }

    // Prioridade mais baixa significa maior urgência
    public int Prioridade { get; set; }  

    public Tarefa(string descricao, int prioridade)
    {
        Descricao = descricao;
        Prioridade = prioridade;
    }
}
}