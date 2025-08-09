using System;
using System.Globalization;
namespace OopPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionario: ");
            Console.WriteLine("Nome: ");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            pessoa.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            Console.WriteLine("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            pessoa2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (pessoa.salario + pessoa2.salario) / 2;
            Console.WriteLine("Salario médio = "+media.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}