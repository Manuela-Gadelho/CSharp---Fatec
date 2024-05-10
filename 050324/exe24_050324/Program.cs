using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe050324
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            double sal;
            Console.WriteLine("1 - Imposto");
            Console.WriteLine("2 - Novo Salário");
            Console.WriteLine("3 - Classificação");
            Console.WriteLine("4 - Finalizar o programa");
            Console.WriteLine("Digite a opção desejada");
            menu = Int32.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.WriteLine("Digite o salário do funcionário: ");
                    sal = Convert.ToDouble(Console.ReadLine());
                    if (sal < 500)
                    {
                        Console.WriteLine("O imposto é de 5%");
                        sal = sal * 1.05;
                        Console.WriteLine("O novo salário é: " + sal);
                        Console.ReadKey();
                    }
                    if (sal >= 500 && sal < 850)
                    {
                        Console.WriteLine("O imposto é de 10%");
                        sal = sal * 1.10;
                        Console.WriteLine("O novo salário é: " + sal);
                        Console.ReadKey();
                    }
                    if (sal > 840)
                        Console.WriteLine("O imposto é de 15%");
                        sal = sal * 1.15;
                    Console.WriteLine("O novo salário é: " + sal);
                        Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Digite o salário do funcionário: ");
                    sal = Convert.ToInt32(Console.ReadLine());
                    if (sal > 1500)
                    {
                        sal = sal + 25;
                        Console.WriteLine("O novo salário é de: " + sal);
                        Console.ReadKey();
                    }
                    if (sal >=750 && sal <= 1500)
                    {
                        sal = sal + 50;
                        Console.WriteLine("O novo salário é de: " + sal);
                        Console.ReadKey();
                    }
                    if (sal >= 450 && sal < 750)
                    {
                        sal = sal + 75;
                        Console.WriteLine("O novo salário é de: " + sal);
                        Console.ReadKey();
                    }
                    if (sal < 450)
                    {
                        sal = sal + 100;
                        Console.WriteLine("O novo salário é de: " + sal);
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    Console.WriteLine("Digite o salário do funcionário: ");
                    sal = Convert.ToInt32(Console.ReadLine());
                    if (sal < 700)
                    {
                        Console.WriteLine("Mal remunerado!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Bem remunerado");
                        Console.ReadKey();
                    }
                    break;
                default:
                    Console.WriteLine("Escolha default");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
