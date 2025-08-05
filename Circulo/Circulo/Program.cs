namespace Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14159F;
            float raio = float.Parse(Console.ReadLine());
            float area = pi * (raio * raio);
            Console.WriteLine($"A: {area:F4}");
        }
    }
}