using System;
using System.Globalization;
namespace OopProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto produto = new Produto();
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.Nome = nome;
            produto.Preco = preco;
            produto.Quantidade = quantidade;
            double valorTotal = produto.Quantidade * produto.Preco;
            Console.WriteLine("Dados do produto: "+ produto);
            
            Console.Write("Digite o numero de produtos a ser adicionados no estoque: ");
            int produtosEstoque = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(produtosEstoque);
            Console.WriteLine("Atualizando dados do produto: "+ produto);
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            produtosEstoque = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(produtosEstoque);
            Console.WriteLine("Atualizando dados do produto: " + produto);



        }
    }
}