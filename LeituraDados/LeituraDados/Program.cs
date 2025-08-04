using System.IO.Pipes;

namespace LeituraDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine($"Aqui está o relatorio de dados: \n {nome} tem {idade} anos e recebe R${salario}");
        }
    }
}