using System;
using System.Globalization;
namespace OopRetangulo
{
    class Program
    {
        static void Main(string[] args) 
        {
            double largura, altura;
            Console.WriteLine("Entra com largura e altura do retângulo: ");
            largura = double.Parse(Console.ReadLine());
            altura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo();
            retangulo.Largura = largura;
            retangulo.Altura = altura;
            Console.WriteLine("AREA = "+ retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = "+ retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = "+ retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}