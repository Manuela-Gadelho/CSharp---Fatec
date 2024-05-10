using System;

namespace CinemaOpinioes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[15];
            int[] opinioes = new int[15];

            int somaIdadesOtimo = 0;
            int countOtimo = 0;
            int countRegular = 0;
            int countBom = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite a idade do espectador " + (i + 1) + ": ");
                idades[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a opinião do espectador " + (i + 1) + " (ótimo: 3, bom: 2, regular: 1): ");
                opinioes[i] = Convert.ToInt32(Console.ReadLine());

                if (opinioes[i] == 3)
                {
                    somaIdadesOtimo += idades[i];
                    countOtimo++;
                }
                else if (opinioes[i] == 1)
                {
                    countRegular++;
                }
                else if (opinioes[i] == 2)
                {
                    countBom++;
                }
            }

            double mediaIdadesOtimo = countOtimo > 0 ? (double)somaIdadesOtimo / countOtimo : 0;

            double percentagemBom = ((countBom * 100) / 15); 

            Console.WriteLine("\nMédia das idades das pessoas que responderam ótimo: " + mediaIdadesOtimo);
            Console.WriteLine("Quantidade de pessoas que responderam regular: " + countRegular);
            Console.WriteLine("Percentagem de pessoas que responderam bom: " + percentagemBom + "%");
            Console.ReadKey();
        }
    }
}
