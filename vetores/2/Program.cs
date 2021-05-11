using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            Console.WriteLine("Bem vindo ao inversor de Números...");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}ª Número:");
                numeros[(i)] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros em sequencia inversa: ");

            for (var i = (numeros.Length - 1); i >= 0; i--)
            {
                Console.WriteLine($"{numeros[i]}");
            }




        }
    }
}
