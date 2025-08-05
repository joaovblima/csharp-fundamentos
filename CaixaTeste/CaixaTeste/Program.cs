using System;
using System.Globalization;
namespace CaixaTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigoUm, codigoDois, quantidadeUm, quantidadeDois;
            double valorProdutoUm, valorProdutoDois, valorAPagar;

            Console.WriteLine("Código do primeiro produto: ");
            codigoUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            quantidadeUm = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor: ");
            valorProdutoUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Código do segundo produto: ");
            codigoDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            quantidadeDois = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor: ");
            valorProdutoDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorAPagar = quantidadeUm * valorProdutoUm + quantidadeDois * valorProdutoDois;
            Console.WriteLine("Valor a pagar: R$ "+ valorAPagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}