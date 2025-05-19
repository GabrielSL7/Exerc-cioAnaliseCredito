using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o valor do empréstimo: ");
        decimal valor = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a quantidade de parcelas: ");
        int parcelas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a renda mensal comprovada: ");
        decimal renda = Convert.ToDecimal(Console.ReadLine());

        decimal valorParcela = valor / parcelas;

        if (valorParcela <= renda * 0.3m)
        {
            Console.WriteLine("Empréstimo aprovado.");
        }
        else
        {
            Console.WriteLine("Empréstimo negado. Parcela excede 30% da renda.");
        }
    }
}
