using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe1_050324
{
    class Program
    {
        static void Main(string[] args)
        {
                int contador = 0;

                Console.WriteLine("Digite números positivos: ");

                while (true)
                {
                    Console.Write("Digite um número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    if (numero < 0)
                    {
                        break;
                    }

                    contador++;
                }

                Console.WriteLine($"Foram digitados {contador} números positivos.");
            
        }

    }
}

