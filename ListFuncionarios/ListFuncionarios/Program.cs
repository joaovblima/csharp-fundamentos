using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de funcionarios? ");
            int numeroFuncionarios = int.Parse(Console.ReadLine());
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            for (int i = 1; i <= numeroFuncionarios; i++)
            {
                Console.WriteLine("Funcionario #"+i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario funcionario = new Funcionario(id, nome, salario);
                listaFuncionarios.Add(funcionario);
            }
            Console.Write("Entre o Id do funcionario que deve ter seu salário aumentado: ");
            int funcionarioId = int.Parse(Console.ReadLine());
            Console.Write("Entre a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario f1 = listaFuncionarios.Find(x =>  x.Id == funcionarioId);
            f1.AumentarSalario(porcentagem);


            Console.WriteLine("Lista de funcionarios atualizada: ");
            foreach (Funcionario func in listaFuncionarios) 
            {
                Console.WriteLine(func);
            }
        }

    }
}