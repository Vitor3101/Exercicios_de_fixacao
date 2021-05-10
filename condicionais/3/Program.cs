using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Validador de Compras...");
            Console.WriteLine("Digite o nome do Produto");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de produtos:");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto:");
            double valorProduto = double.Parse(Console.ReadLine());
            double totalSemJuros = 0;
            double total = 0;


            if (quantidadeProduto <= 5)
            {
                totalSemJuros = quantidadeProduto * valorProduto;
                total = totalSemJuros * 0.98;
            }
            if (quantidadeProduto > 5 && quantidadeProduto <= 10)
            {
                totalSemJuros = quantidadeProduto * valorProduto;
                total = totalSemJuros * 0.97;
            }
            if (quantidadeProduto > 10)
            {
                totalSemJuros = quantidadeProduto * valorProduto;
                total = totalSemJuros * 0.95;
            }
            Console.WriteLine($"O produto {nomeProduto} com o preço de: {valorProduto} Reais cada. Resultaram num total de:\n {totalSemJuros} Reais sem desconto\n {total} Reais com desconto");
        }
    }
}
