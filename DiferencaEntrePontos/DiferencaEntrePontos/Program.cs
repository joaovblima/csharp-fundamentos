namespace DiferencaEntrePontos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int produtoUm = a * b;
            int produtoDois = c * d;
            int diferenca = produtoUm - produtoDois;
            Console.WriteLine("DIFERENÇA = "+diferenca);
        }
    }
}