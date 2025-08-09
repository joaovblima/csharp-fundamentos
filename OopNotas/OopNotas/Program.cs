using System;
using System.Globalization;
namespace OopNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite três notas do aluno: ");
            double[] notas = new double[3];
            notas[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notas[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Aluno aluno = new Aluno();
            aluno.Nome = nome;
            aluno.Notas = notas;
            Console.WriteLine("Media = "+ aluno.CalculaMedia(notas).ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.Aprovado() == false)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.0 - aluno.CalculaMedia(notas)).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS.");
            }

        }
    }
}