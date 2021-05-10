using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de Tabuadas...");
            int resultado = 0;
            for (var a = 0; a <= 10; a++)
            {
                Console.WriteLine("\n");
                for (var i = 0; i <= 10; i++)
                {
                    resultado = a * i;
                    Console.WriteLine($"{a} x {i} = {resultado}");
                }
            }
        }
    }
}
