using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alunosMatricula
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] logica = new int[15];
            int[] programacao = new int[10];
            string[] matriculas = new string[10];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Digite o número de matrícula do aluno de lógica: " + logica[i]);
                logica[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o número de matrícula do aluno de Linguagem de Programação: " + programacao[i]);
                programacao[i] = Convert.ToInt32(Console.ReadLine());

                if (logica[i] == programacao[i])
                {
                    matriculas[i] = Console.ReadLine();
                }
            }

            Console.WriteLine("Os alunos que estão matriculados nas duas matérias são: " + matriculas);
            Console.ReadKey();
        }
    }
}
