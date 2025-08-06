namespace WhilePostoGasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "1.Alcool\n" +
                "2.Gasolina\n" +
                "3.Diesel\n" +
                "4.Fim";

            Console.WriteLine(texto);
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            int opcao = int.Parse(Console.ReadLine());
            
            
            while (opcao != 4) {
               
                if (opcao == 1)
                {
                    alcool += 1;
                }
                else if (opcao == 2)
                {
                    gasolina += 1;
                }
                else if (opcao == 3)
                {
                    diesel += 1;
                }
                opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}