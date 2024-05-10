using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            //condicional simples
            int numero = 10;
            if (numero == 10)
            {
                Console.WriteLine("teste");
            }

            int num = 20;
            if (num == 20)
            {
                Console.WriteLine("verdadeiro");
            }
            else
            {
                Console.WriteLine("falso");
            }

            // Alternativa para condicional composta com somente uma instrução
            int number1 = 6;
            Console.WriteLine(number1 > 6 ? "passou" : "reprovou");

            // estrutura encadeada
            num = 11;
            if (num == 20)
            {
                Console.WriteLine("igual a 20");
            }
            else if (num < 10)
            {
                Console.WriteLine("menor que 10");
            }
            else
            {
                Console.WriteLine("maior que 10");
            }
            // Estrutura condicional com mais de uma alternativa
            if (num <= 10 && num >= 0)
            {
                Console.WriteLine("Valor entre 0 e 10");
            }
            else if (num > 10 && num < 20)
            {
                Console.WriteLine("Valor entre 10 e 20");
            }
            else
            {
                Console.WriteLine("Nenhum dos valores");
            }

            //Estrutura condicional com mais de uma alternativa - Ou lógico
            if (num <= 10 || num >= 0)
            {
                Console.WriteLine("Valor entre 0 e 10");
            }
            else if (num > 10 || num < 20)
            {
                Console.WriteLine("Valor entre 10 e 20");
            }
            else
            {
                Console.WriteLine("Nenhum dos valores");
            }
            //
            if (num <= 10 ^ num >= 0)
            {
                Console.WriteLine("Valor entre 0 e 10");
            }
            if (!(num == 10))

                Console.ReadKey();
        }
    }
}