using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("           CADASTRO DE ALUNO");
        Console.WriteLine("========================================");

        Console.Write("Nome completo: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Primeira letra do nome: ");
        char inicial = char.Parse(Console.ReadLine());

        Console.Write("Está matriculado? (true/false): ");
        bool matriculado = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("              FICHA DO ALUNO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Altura: {altura:F2} m");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine($"Matriculado: {matriculado}");
        Console.WriteLine("========================================");
    }
}