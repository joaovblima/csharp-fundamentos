namespace LeituraDadosParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int numeroQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Ente com seu ultimo nome, idadde, altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idadeNova = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(numeroQuartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idadeNova);
            Console.WriteLine(altura);

        }
    }
}