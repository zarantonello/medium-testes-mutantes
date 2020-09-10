using System;

namespace LabNotas
{
    public static class Program
    {
        private const string aprovado = "Aprovado";
        private const string reprovado = "Reprovado";

        static void Main(string[] args)
        {
            string resultado = ValidaNotaFrequencia(4, 0.7);
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        public static string ValidaNotaFrequencia(short nota, double frequencia)
        {
            if (nota >= 5 && frequencia >= 0.6)
                return aprovado;
            else
            {
                return reprovado;
            }
        }
    }
}
