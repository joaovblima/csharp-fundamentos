using System;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 28;
            string nome = "joão";
            double saldo = 1780;

            Console.WriteLine(nome);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine($"{nome} tem {idade} e recebe um salário de {saldo}");
        }
    }
}