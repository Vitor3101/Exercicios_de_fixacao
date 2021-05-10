using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i}ª Número");
                numeros[(i - 1)] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine($"O menor e maior número, são respectivamente: {numeros[0]} e {numeros[9]}");
        }
    }
}
