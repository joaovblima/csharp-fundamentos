namespace ForInOut
{
    class Program
    {
        static void Main(string[] args) 
        {
            int inIntervalo = 0;
            int outIntervalo = 0; 
            int quantidadeNumeros, numero;
            quantidadeNumeros = int.Parse(Console.ReadLine());
            for(int i = 0; i< quantidadeNumeros; i++)
            {
                numero = int.Parse(Console.ReadLine());

                if (numero>10 && numero <=20)
                {
                    inIntervalo += 1;
                } else
                {
                    outIntervalo += 1;
                }
            }
            Console.WriteLine("in:" + inIntervalo);
            Console.WriteLine("out: "+ outIntervalo);
            
        }
    }
}