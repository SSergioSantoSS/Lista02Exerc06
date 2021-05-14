using Lista02Exercicio06.Entities;
using Lista02Exercicio06.Repositories;
using System;

namespace Lista02Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCADASTRE O PRODUTO");

            var produto = new Produto();

            produto.Categoria = new Categoria();

            Console.WriteLine("\nPor favor, informe o Id do produto :");
            produto.IdProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPor favor, informe o nome do produto :");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("\nPor favor, informe o preço do produto :");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPor favor, informe a quantidade do produto :");
            produto.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("\nCADASTRE A CATEGORIA DO PRODUTO" );

            Console.WriteLine("\nPor favor, informe iD da categoria do produto :");
            produto.Categoria.IdCategoria =int.Parse(Console.ReadLine());

            Console.WriteLine("\nPor favor, informe a descrição da categoria do produto :");
            produto.Categoria.Descricao = Console.ReadLine();



            Console.WriteLine("\nVERIFIQUE SE OS DADOS DO PRODUTO ESTÃO CORRETOS");

            Console.WriteLine("ID...........:" + produto.IdProduto);
            Console.WriteLine("NOME.........:" + produto.Nome);
            Console.WriteLine("PREÇO........:" + produto.Preco);
            Console.WriteLine("QUANTIDADE...:" + produto.Quantidade);

            Console.WriteLine("\nVERIFIQUE SE OS DADOS DA CATEGORIA DO PRODUTO ESTÃO CORRETOS");
            Console.WriteLine("ID...........:" + produto.Categoria.IdCategoria);
            Console.WriteLine("DESCRIÇÃO....:" + produto.Categoria.Descricao);



            var produtoRepository = new ProdutoRepository();

            try
            {
                produtoRepository.ExportarDados(produto);
                Console.WriteLine("\nDados gravados com SUCESSO!");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nERRO :" + e.Message);
                
            }
            Console.ReadKey();
        }
    }
}
