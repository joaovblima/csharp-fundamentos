using System;
using System.Globalization;
namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(ConversorDeMoedas.Calcular(dolar, quantidade).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}