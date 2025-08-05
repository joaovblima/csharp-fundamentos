namespace CondicionalDuracaoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = int.Parse(Console.ReadLine());
            int termino = int.Parse(Console.ReadLine());
            int resultado;

            if (inicio == termino)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS.");
            }
            else if (termino >= inicio)
            {
                resultado = termino - inicio;
                Console.WriteLine("O JOGO DUROU " + resultado + " HORAS.");
            }
            else
            {
                resultado = (24 - inicio) + termino;
                Console.WriteLine("O JOGO DUROU " + resultado + " HORAS.");
            }
        }
    }
}