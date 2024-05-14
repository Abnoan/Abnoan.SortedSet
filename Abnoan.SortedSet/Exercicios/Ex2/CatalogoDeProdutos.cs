using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.SortedSet.Exercicios.Ex2
{
    public class CatalogoDeProdutos
    {
        public SortedSet<Produto> produtos;

        public CatalogoDeProdutos()
        {
            produtos = new SortedSet<Produto>(new ComparadorDeProdutos());
        }

        public void AdicionarProduto(string nome, string categoria, decimal preco)
        {
            produtos.Add(new Produto(nome, categoria, preco));
        }

        public void MostrarProdutos()
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"{produto.Nome} - {produto.Categoria} - ${produto.Preco}");
            }
        }

        public void IntersectCatalogo(SortedSet<Produto> outroCatalogo)
        {
            produtos.IntersectWith(outroCatalogo);
        }

        // Método para realizar a união de catálogos
        public void UnionCatalogo(SortedSet<Produto> outroCatalogo)
        {
            produtos.UnionWith(outroCatalogo);
        }

        // Método para realizar a diferença de catálogos
        public void ExceptCatalogo(SortedSet<Produto> outroCatalogo)
        {
            produtos.ExceptWith(outroCatalogo);
        }
    }
}