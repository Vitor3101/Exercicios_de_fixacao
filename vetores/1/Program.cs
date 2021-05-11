using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            Console.WriteLine("$Bem vindo ao gerenciador de nomes...");
            Console.WriteLine($"Digite o nome de {nomes.Length} pessoas:");

            for (var i = 1; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i}ª Nome:");
                nomes[(i)] = Console.ReadLine();
            }

            Console.WriteLine($"Digite o nome que deseja buscar:");
            string nomeBusca = Console.ReadLine();
            int error = 0;

            foreach (var cadaNome in nomes)
            {
                {
                    if (nomeBusca == cadaNome)
                        error = 1;
                }
            }

            if (error == 1)
            {
                Console.WriteLine("Nome encontrado");
            }
            if (error == 0)
            {
                Console.WriteLine("Não encontrado");
            }

        }
    }
}
