

namespace OopNotas
{
    class Aluno
    {
        public string Nome;
        public double[] Notas;

        public double CalculaMedia(double[] Notas)
        {
            double soma = 0;
            foreach (var nota in Notas)
            {
                soma += nota;
            }
            return soma;
        }

        public bool Aprovado()
        {
            if (CalculaMedia(Notas) < 60)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
