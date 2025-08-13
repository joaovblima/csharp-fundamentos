namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] aluno = new Aluno[10];
            Console.Write("How many rooms will be rented? ");
            int roomNums = int.Parse(Console.ReadLine());



            for (int i = 1; i <= roomNums; i++)
            {
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                aluno[room] = new Aluno(name, email);



            }
            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < aluno.Length; i++)
            {
                if (aluno[i] != null)
                {
                    Console.WriteLine(i + ": " + aluno[i]);
                }
            }
        }
    }
}