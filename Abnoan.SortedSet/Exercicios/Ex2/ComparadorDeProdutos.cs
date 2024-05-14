using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.SortedSet.Exercicios.Ex2
{
    public class ComparadorDeProdutos : IComparer<Produto>
    {
        public int Compare(Produto x, Produto y)
        {
            int result = x.Nome.CompareTo(y.Nome);
            if (result == 0)
            {
                result = x.Preco.CompareTo(y.Preco);
            }
            return result;
        }
    }
}