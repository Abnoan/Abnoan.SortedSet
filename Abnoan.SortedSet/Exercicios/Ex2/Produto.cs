using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.SortedSet.Exercicios.Ex2
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, string categoria, decimal preco)
        {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }
    }
}