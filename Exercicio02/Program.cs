using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("        FICHA PROFISSIONAL");
        Console.WriteLine("========================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Cargo: ");
        string cargo = Console.ReadLine();

        Console.Write("Salário: ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Inicial: ");
        char inicial = char.Parse(Console.ReadLine());

        Console.Write("Está ativo? (true/false): ");
        bool ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("           DADOS DO FUNCIONÁRIO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário: R$ {salario:F2}");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("========================================");
    }
}