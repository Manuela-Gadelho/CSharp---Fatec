using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade; 
            double[] peso;
            double media1=0, media2=0, media3=0, media4=0;
            double faixaEtaria010 = 0, faixaEtaria20=0, faixaEtaria21=0,faixaEtaria30=0;
            idade = new int[15];
            peso = new double[15];

            for (int i=0; i<14;i++)
            {
                Console.WriteLine("Digite a idade da pessoa " + i + ":");
                idade[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o peso da pessoa " + i + ":");
                peso[i] = Convert.ToDouble(Console.ReadLine());

                if (idade[i] >= 1 && idade[i] <= 10)
                {
                    faixaEtaria010++;
                    media1 = media1 + peso[i];
                }
                if (idade[i] >= 11 && idade[i] <= 20)
                {
                    faixaEtaria20++;
                    media2 = media2 + peso[i];
     
                }
                if (idade[i] >= 21 && idade[i] <= 30)
                {
                    faixaEtaria21++;
                    media3 = media3 + peso[i];
                }
                if (idade[i] > 30)
                {
                    faixaEtaria30++;
                    media4 = media4 + peso[i];
                }
            }
            media1 = media1 / faixaEtaria010;
            media2 = media2 / faixaEtaria20;
            media3 = media3 / faixaEtaria21;
            media4 = media4 / faixaEtaria30;
            
            Console.WriteLine("A média de peso das pessoas que estão na faixa etária 1 é de: " + media1);
            Console.WriteLine("A média de peso das pessoas que estão na faixa etária 2 é de: " + media2);
            Console.WriteLine("A média de peso das pessoas que estão na faixa etária 3 é de: " + media3);
            Console.WriteLine("A média de peso das pessoas que estão na faixa etária 4 é de: " + media4);

            Console.ReadKey();
        }
    }
}
