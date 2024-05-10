using System;

namespace ReajusteSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[20];
            double[] salarios = new double[20];
            double[] novosSalarios = new double[20];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite o nome da pessoa " + (i + 1) + ": ");
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Digite o salário da pessoa " + (i + 1) + ": ");
                salarios[i] = Convert.ToDouble(Console.ReadLine());

                novosSalarios[i] = salarios[i] * 1.08;
            }

            Console.WriteLine("\nListagem dos novos salários:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + ". Nome: " + nomes[i] + " - Novo salário: " + novosSalarios[i].ToString("C"));
            }
            Console.ReadKey();
        }
    }
}
