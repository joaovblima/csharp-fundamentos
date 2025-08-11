using System;
using System.Globalization;


namespace Conta
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() 
        { }
        public ContaBancaria (int numeroDaConta,  string nome)
        {   Numero = numeroDaConta;
            Nome= nome;
            Saldo = 0.0;
        }

        public ContaBancaria(int numeroDaConta, string nome, double valorDeposito) : this()
        {
            Deposito(valorDeposito);
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            if (valorSaque > Saldo)
            {
                Console.WriteLine("Operação não concluida... Saldo insuficiente. ");
            } else
            {
                Saldo -= valorSaque;
                Saldo -= 5.00;
            }
        }

        public override string ToString()
        {
            return "Conta " + Numero
                + ", Titular: " + Nome
                + ", Saldo: R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture); 
        }

       

        

    }
}
