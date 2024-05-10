using System;

namespace alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aluno = new string[7];
            double[] mediaF = new double[7];
            double maiorMedia = 0;
            string alunoMaiorMedia = "";

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("\nDigite o nome do aluno: ");
                aluno[i] = Console.ReadLine();

                Console.WriteLine("\nDigite a média final desse aluno: ");
                mediaF[i] = Convert.ToDouble(Console.ReadLine());

                if (mediaF[i] < 7)
                {
                    Console.WriteLine("Aluno " + aluno[i] + " Reprovado! Em recuperação.");
                }

                if (mediaF[i] > maiorMedia)
                {
                    maiorMedia = mediaF[i];
                    alunoMaiorMedia = aluno[i];
                }
            }

            Console.WriteLine("O aluno com a maior média é " + alunoMaiorMedia + " com média de: " + maiorMedia);
            Console.ReadKey();
        }
    }
}
