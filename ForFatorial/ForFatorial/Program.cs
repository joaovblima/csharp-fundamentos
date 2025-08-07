namespace ForFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int resultado = 1;

            for (int i = numero; i > 1; i--)
            {
                resultado *= i;
            }
            Console.WriteLine(resultado);
        }
    }
}