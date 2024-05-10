using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paresImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int quantPar = 0, quantImpar = 0;
            vetor = new int[6];

            for (int i = 0; i<6; i++)
            {
                Console.WriteLine("Digite um número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    quantPar = quantPar + 1;
                    Console.WriteLine(vetor[i] + " é par!");
                }
                if (vetor[i] % 2 != 0)
                {
                    quantImpar = quantImpar + 1;
                    Console.WriteLine(vetor[i] + " é ímpar!");
                }
            }
            Console.WriteLine("A quantidade de números pares é: " + quantPar);
            Console.WriteLine("A quantidade de números ímpares é: " + quantImpar);

            Console.ReadKey();
        }
    }
}
