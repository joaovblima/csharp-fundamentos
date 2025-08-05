namespace CondicionalMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());

            if (numero2 % numero1 == 0 || numero1 % numero2 == 0)
            {
                Console.WriteLine("São multiplos");
            } else
            {
                Console.WriteLine("Não são multiplos");
            }
        }
    }
}