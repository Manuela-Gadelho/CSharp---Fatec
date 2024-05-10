using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        Console.WriteLine("Digite 0 (zero) para parar");

        while (true)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                break;
            }

            if (numero >= 100 && numero <= 200)
            {
                contador ++;
            }
        }

        Console.WriteLine($"Foram digitados {contador} números entre 100 e 200.");
    }
}
