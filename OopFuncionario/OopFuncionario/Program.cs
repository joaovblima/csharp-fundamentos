using System;
using System.Globalization;
namespace OopFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = nome;
            funcionario.SalarioBruto = salarioBruto;
            funcionario.Imposto = imposto;

            Console.WriteLine("Funcionário: "+funcionario);
            Console.Write("Digite a porcentagem de aumento: ");
            double porcentagemAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagemAumento);
            Console.WriteLine("Dados atualizados: "+ funcionario);
        }

    }
}