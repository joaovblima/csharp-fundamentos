using System;
using System.Globalization;

namespace CondicionalImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, taxa, valorImposto;


            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.0)
            {
                valorImposto = 0.0;
            } else if (salario <= 3000.0)
            {
                taxa = 0.08;
                valorImposto = (salario - 2000) * taxa;

            } else if (salario <= 4500)
            {
                taxa = 0.18;
                valorImposto = (salario - 3000) * taxa + 1000.0 * 0.08 ;
            } else
            {
                taxa = 0.28;
                valorImposto = (salario - 4500) * taxa + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (valorImposto == 0.0)
            {
                Console.WriteLine("Isento");
            } else
            {
                Console.WriteLine("R$" + valorImposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
}
}