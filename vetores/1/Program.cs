using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int[] nomes = null;
            Console.WriteLine("Bem vindo ao buscador por nomes em arquivo...");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º nome que você deseja cadastrar:");
                nomes[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Digite o nome que você deseja procurar: ");
            Console.WriteLine(nomes[1]);
        }
    }
}
