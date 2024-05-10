using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int soma = 0;

        Console.WriteLine("Digite números positivos!");

        while (true)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            soma += numero;
            contador++;
        }

        if (contador > 0)
        {
            double media = (double)soma / contador;
            Console.WriteLine($"A média dos números digitados é: {media}");
        }
        else
        {
            Console.WriteLine("Nenhum número positivo foi digitado.");
        }
    }
}
