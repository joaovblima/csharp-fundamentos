namespace WhileQuadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0 )
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                    break;
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                    break;
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                    break;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    break;
                }
                else
                {
                    break;
                }
            }
        }
    }
}