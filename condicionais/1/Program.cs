using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input de informações do usuário
            Console.WriteLine("Validação de voto...");
            Console.WriteLine("Digite o Ano em que você nasceu no formato xxxx");
            int anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Mês em que você nasceu em formato numérico xx");
            int mesNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite em que dia você nasceu");
            int diaNascimento = int.Parse(Console.ReadLine());

            // Input de data atual
            string diaAtuals = DateTime.Now.Day.ToString();
            string mesAtuals = DateTime.Now.Month.ToString();
            string anoAtuals = DateTime.Now.Year.ToString();

            // Conversão de String para Int
            int diaAtual = Int16.Parse(diaAtuals);
            int mesAtual = Int16.Parse(mesAtuals);
            int anoAtual = Int16.Parse(anoAtuals);

            // Calculadora de idade
            int idadeDia = diaAtual - diaNascimento;
            int idadeMes = mesAtual - mesNascimento;
            int idadeAno = anoAtual - anoNascimento;

            if (mesAtual < mesNascimento)
            {
                idadeAno = idadeAno - 1;
            }

            if (idadeAno >= 16)
            {
                Console.WriteLine("\nVocê já pode escolher o futuro do seu País!!! Parabéns!");
            }
            else
            {
                Console.WriteLine("\nVocê não pode votar ainda. Pois, não possui idade suficiente (16 Anos)");
            }

        }
    }
}
