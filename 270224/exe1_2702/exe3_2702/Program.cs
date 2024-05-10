using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe3_2702
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool verificacao = true;

            Console.WriteLine("Digite um número qualquer: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                verificacao = Convert.ToBoolean(num);
                Console.WriteLine("Esse número é positivo!");
            }
            else
            {
                Console.WriteLine("Esse número é negativo!");
            }
            Console.ReadKey();
        }
    }
}
