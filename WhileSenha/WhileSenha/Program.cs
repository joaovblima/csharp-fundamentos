namespace WhileSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 2002;
            int senhaUsuario;
            Console.WriteLine("Digite a senha: ");
            senhaUsuario = int.Parse(Console.ReadLine());
            while (senha != senhaUsuario) {
                Console.WriteLine("Acesso negado! Tente novamente: ");
                senhaUsuario= int.Parse(Console.ReadLine());
                if (senhaUsuario == senha)
                {
                    break;
                }
            }
            Console.WriteLine("Acesso permitido.");
        }
    }
}