using System;
using System.Globalization;
namespace ForDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i  = 0; i < num; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double a = int.Parse(valores[0]);
                double b = int.Parse(valores[1]);

                if (b == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((a / b).ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}