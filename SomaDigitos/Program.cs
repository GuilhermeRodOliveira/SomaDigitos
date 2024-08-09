using System;

namespace ESTRUTURA_LOOP_DE_REPETIÇÃO_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 - Escreva um programa que peça ao usuário para inserir um número e, em seguida, imprima a soma de seus dígitos usando um loop while.
            Console.WriteLine("Insira um numero.");
            string input = Console.ReadLine();

            int num;
            if (int.TryParse(input, out num))
            {
                int somaDigitos = 0;
                int numeroRestante = Math.Abs(num);

                while (numeroRestante > 0)
                {
                    int digito = numeroRestante % 10;
                    somaDigitos += digito;
                    numeroRestante /= 10;
                }

                Console.WriteLine($"A soma dos dígitos de {num} é {somaDigitos}");
            }
            else
            {
                Console.WriteLine("Pfvr, insira um numero valido");
            }
        }
    }
}
