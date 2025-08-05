namespace CondicionalLanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            string apresentacao = "CODIGO    |    ESPECIFICAÇÃO    |    PREÇO";
            string texto = "1    |    CACHORRO QUENTE    |    R$ 4.00\n" +
                "2    |    X-Salada    |    R$4.50\n" +
                "3    |    Torrada Simples    |    R$2.000\n" +
                "4    |    X-Bacon    |    R$5.00\n" +
                "5    |    Refrigerante    |    R$1.50";

            Console.WriteLine(apresentacao);
            Console.WriteLine(texto);
            int opcao, quantidade;
            double valorTotal = 0;
            opcao = int.Parse(Console.ReadLine());
            quantidade = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                valorTotal = quantidade * 4.00;
            }
            else if (opcao == 2)
            {
                valorTotal = quantidade * 4.50;
            }
            else if (opcao == 3)
            {
                valorTotal = quantidade * 5;
            }
            else if (opcao == 4) 
            {
                valorTotal = quantidade * 2;
            }
            else if (opcao == 5)
            {
                valorTotal = quantidade * 1.5;
            } else
            {
                Console.WriteLine("Não temos essa opção disponível.");
            }

            Console.WriteLine($"Total: R$ {valorTotal:F2}");
        }

        }
    }