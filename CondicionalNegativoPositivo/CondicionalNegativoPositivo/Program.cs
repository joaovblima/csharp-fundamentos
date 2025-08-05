namespace CondicionalNegativoPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Negativo");
            } else
            {
                Console.WriteLine("Positivo");
            }
        }
    }
}