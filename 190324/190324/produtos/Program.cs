using System;

namespace AnaliseProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[5];
            double[] precos = new double[5];
            int countMenorQue50 = 0;
            string produtosEntre50e100 = "";
            double somaPrecosSuperiorA100 = 0;
            int countPrecosSuperiorA100 = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome do produto " + (i + 1) + ": ");
                produtos[i] = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto " + (i + 1) + ": ");
                precos[i] = Convert.ToDouble(Console.ReadLine());

                if (precos[i] < 50)
                {
                    countMenorQue50++;
                }
                else if (precos[i] >= 50 && precos[i] <= 100)
                {
                    if (produtosEntre50e100 != "")
                    {
                        produtosEntre50e100 += ", ";
                    }
                    produtosEntre50e100 += produtos[i];
                }
                else if (precos[i] > 100)
                {
                    somaPrecosSuperiorA100 += precos[i];
                    countPrecosSuperiorA100++;
                }
            }

            Console.WriteLine("\nQuantidade de produtos com preço inferior a R$ 50,00: " + countMenorQue50);
            Console.WriteLine("Nome dos produtos com preço entre R$ 50,00 e R$ 100,00: " + produtosEntre50e100);

            if (countPrecosSuperiorA100 > 0)
            {
                double mediaPrecosSuperiorA100 = somaPrecosSuperiorA100 / countPrecosSuperiorA100;
                Console.WriteLine("Média dos preços dos produtos com preço superior a R$ 100,00: " + mediaPrecosSuperiorA100.ToString("C"));
            }
            else
            {
                Console.WriteLine("Não há produtos com preço superior a R$ 100,00.");
            }
            Console.ReadKey();
        }
    }
}
