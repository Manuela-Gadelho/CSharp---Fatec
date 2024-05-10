using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe1_2702
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, soma, resul; 
            Console.WriteLine("Digite um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            soma = num1 + num2 + num3 + num4;

            Console.WriteLine("A soma dos quatro números digitados é " + soma);
            Console.ReadKey();
        }
    }
}
