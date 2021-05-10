using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao programa calculador de combustíveis!");
            Console.WriteLine("Digite o tipo de combustível que você deseja usar (a-Alcool / g-Gasolina)");
            string combustivel = Console.ReadLine().ToLower().Substring(0, 1);
            Console.WriteLine($"Quantos Litros você deseja comprar?");
            int litros = int.Parse(Console.ReadLine());
            double precoAlcool = 4.90;
            double precoGasolina = 5.30;
            double totalSemJuros = 0;
            double total = 0;

            if (combustivel == "a")
            {
                if (litros > 20)
                {
                    totalSemJuros = litros * precoAlcool;
                    total = totalSemJuros * 0.95;
                }
                else
                {
                    totalSemJuros = litros * precoAlcool;
                    total = totalSemJuros * 0.97;
                }
            }
            else if (combustivel == "g")
            {
                if (litros > 20)
                {
                    totalSemJuros = litros * precoGasolina;
                    total = totalSemJuros * 0.95;
                }
                else
                {
                    totalSemJuros = litros * precoGasolina;
                    total = totalSemJuros * 0.97;
                }
            }
            if (combustivel == "a")
            {
                combustivel = "Alcool";
            }
            if (combustivel == "g")
            {
                combustivel = "Gasolina";
            }

            Console.WriteLine($"\nO preço total da compra de {combustivel} foi de: \n {totalSemJuros} Reais Sem desconto\n {total} Reais Com desconto ");
        }
    }
}
