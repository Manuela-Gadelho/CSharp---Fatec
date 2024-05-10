using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[7];
            int  mult2=0, mult3=0;

            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("\nDigite um número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());

                if (vetor[i] % 2 == 0)
                {
                    mult2 = mult2 + 1;
                    Console.WriteLine(vetor[i] + " é múltiplo de 2!");
                }
                if (vetor[i] % 3 == 0)
                {
                    mult3 = mult3 + 1;
                    Console.WriteLine(vetor[i] + " é múltiplo de 3!");
                }
                if (vetor[i] % 2 == 0 && vetor[i] % 3 ==0)
                {
                    Console.WriteLine(vetor[i] + " é múltiplo de 2 e 3!");
                }
                else
                {
                    Console.Write("Não é múltiplo de nenhum dos dois.");
                }
            }
            Console.ReadKey();
        }
    }
}
