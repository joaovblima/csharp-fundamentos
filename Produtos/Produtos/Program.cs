using System.Globalization;
namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:F2}");

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");

            Console.WriteLine($"Media com 8 casas decimais {medida}");
            Console.WriteLine($"Media com 8 casas decimais {medida:F3}");
            Console.WriteLine("Invariant culture " + medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}