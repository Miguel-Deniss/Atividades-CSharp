using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("          FICHA DE CLIENTE");
        Console.WriteLine("========================================");

        Console.Write("Identificação: ");
        string identificacao = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Situação do cliente: ");
        string situacao = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("-------------- CLIENTE --------------");
        Console.WriteLine($"Identificação: {identificacao}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Situação: {situacao}");
        Console.WriteLine("-------------------------------------");
    }
}