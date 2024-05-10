using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Console.WriteLine("Valor de pi " + pi.ToString("#.00"));

            int valorx, valory;
            valorx = 2;
            valory = 3;
            double valor = Math.Pow(valorx, valory);
            Console.WriteLine("2 elevado a 3 = " + valor);

            double raiz = Math.Sqrt(25);
            Console.WriteLine("a raiz de 25 = " + raiz);

            int maior = Math.Max(19, 24);
            Console.WriteLine("O maior valor é " + maior);

            int menor = Math.Min(19, 24);
            Console.WriteLine("O menor valor é " + menor);

            Console.ReadKey();
        }
    }
}
