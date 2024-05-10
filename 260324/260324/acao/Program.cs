using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acao
{
    class Program
    {
        static void Main(string[] args)
        {
            double compra, venda, lucro;
            int quant1000=0, quant200=0, lucroTotal=0;
            string acao;

            Console.WriteLine("Digite o nome da ação: ");
            acao = Console.ReadLine();

            Console.WriteLine("Digite o valor de compra da ação declarada: ");
            compra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor de venda da ação declarada: ");
            venda = Convert.ToDouble(Console.ReadLine());

            lucro = venda - compra;

            Console.WriteLine("O lucro dessa operação foi de: " + lucro);

            if (lucro > 1000)
            {
                quant1000 = quant1000 + 1;
            }
            if (lucro < 200)
            {
                quant200 = quant200 + 1;
            }
            Console.WriteLine("A quantidade de ações com lucro superior a R$1000.00 foi de: " + quant1000);
            Console.WriteLine("A quantidade de ações com lucro inferior a R$200.00 foi de: " + quant200);

            Console.WriteLine("O lucro total da empresa foi de: " + lucroTotal);

            if (acao == "F")
            {
                Console.WriteLine("Término do programa.");
            }
            Console.ReadKey();
        }
    }
}
