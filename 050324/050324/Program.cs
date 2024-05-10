using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_05_03_case
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int teste = 1;
            Console.WriteLine("1 - Inclusão");
            Console.WriteLine("2 - Alteração");
            Console.WriteLine("3 - Exclusão");
            Console.WriteLine("Digite a opção desejada");
            teste = Int32.Parse(Console.ReadLine());
            // Estrutura de controle switch/case
            switch (teste)
            {
                case 1:
                    Console.WriteLine("Você escolheu a Inclusão");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a Alteração");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a Exclusão");
                    break;
                default:
                    Console.WriteLine("Escolha default");
                    break;
                    */

            // laço de repetição while
            int total = 0, gradeCounter = 0, gradeValue = 0;
            total = total + gradeValue;
            gradeCounter = gradeCounter + 1;

            Console.WriteLine("Enter Integer Grade, -1 to Quit: ");
            gradeValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("A soma dos valores: " + total);

            // laço de repetição For
            for (int counter = 1; counter <= 5; counter++)
                Console.WriteLine("Mensagem");

            //laço de repetição do-while 
            int cont = 1;
            do
            {
                Console.WriteLine(cont);
                cont++;
            } while (cont <= 5);

            // uso do break 
            // Break: Usado quando precisamos de uma saída imediata 
            string output = "";
            for (int count =1; count <= 10; count++)
            {
                if (count == 5) //pula o código restando no laço 
                    break;

                output += count + " ";
                Console.WriteLine("Valor: " + output);

            }
            Console.ReadKey();
        }

    }
}
