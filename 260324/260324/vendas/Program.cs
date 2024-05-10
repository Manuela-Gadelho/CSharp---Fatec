using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] totalVendas = new double[10];
            double[] comissao = new double[10];
            string[] nomes = new string[10];
            double maiorValor = 0;
            double menorValor = 0;
            double totalVendedores=0;
            double[] valorFinal = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o número total de vendas do vendedor: ");
                totalVendas[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o percentual de comissão: ");
                comissao[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o nome dos vendedores: ");
                nomes[i] = Console.ReadLine();

                totalVendedores = totalVendedores + totalVendas[i];

                valorFinal[i] = totalVendas[i] * comissao[i];
            }

            Console.WriteLine("O número total de vendas de todos os vendedores juntos é de: " + totalVendedores);
            Console.WriteLine("O maior valor a receber é do vendedor " + maiorValor);
            Console.WriteLine("O menor valor a receber é do vendedor " + menorValor);
            Console.WriteLine("O relatório de nomes e valores a receber dos vendedores: \n" + nomes[0] + " " + valorFinal[0] +
            "\n" + nomes[1] + " " + valorFinal[1] + nomes[2] + " " + valorFinal[2] + nomes[3] + " " + valorFinal[3] + "\n"+ 
            nomes[4] + " " + valorFinal[4] + "\n" + nomes[5] + " " + valorFinal[5] + "\n" + nomes[6] + " " + valorFinal[6] + "\n" + 
            nomes[7] + " " + valorFinal[7] + "\n" + nomes[8] + " " + valorFinal[8] + "\n" + nomes[9] + " " + valorFinal[9] + "\n");

            Console.ReadKey(); 
        }
    }
}
