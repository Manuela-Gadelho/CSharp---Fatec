using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe2_2702
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, novoSal;

            Console.WriteLine("Digite o salário inicial do funcionário: ");
            sal = Convert.ToInt32(Console.ReadLine());

            novoSal = sal * 1.25;

            Console.WriteLine("O novo salário deste funcionário com acréscimo de 25% fica: " + novoSal);
            Console.ReadLine();
        }
    }
}
