using System;
using System.Globalization;
namespace CondicionalIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (entrada < 0 || entrada > 100)
            {
                Console.WriteLine("Fora do intervalo.");
            } else if (entrada <=25)
            {
                Console.WriteLine("Intervalo (0,25]");
            } else if (entrada <=50)
            {
                Console.WriteLine("Intervalo (25,50]");
            } else if (entrada <= 75){
                Console.WriteLine("Intervalo (50,75]");
            } else
            {
                Console.WriteLine("Intervalo (75, 100]");
            }
        }
    }
}