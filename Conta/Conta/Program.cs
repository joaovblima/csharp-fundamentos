using System;
using System.Globalization;
namespace Conta
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDeposito;
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());  
            Console.Write("Entre com o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string haveraDeposito = Console.ReadLine();
            if (haveraDeposito == "s" || haveraDeposito == "S")
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numeroDaConta, nomeTitular, valorDeposito);
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine(conta);
            } else
            {
                Console.WriteLine("Dados da conta: ");
                conta = new ContaBancaria(numeroDaConta, nomeTitular);
                Console.WriteLine(conta);
            }
            Console.Write("Entre com um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}