using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("          SISTEMA DE ATENDIMENTO");
        Console.WriteLine("========================================");

        Console.Write("Identificação do cliente: ");
        string identificacao = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Motivo do atendimento: ");
        string motivo = Console.ReadLine();

        Console.Write("Código do atendimento: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Atendimento concluído? (true/false): ");
        bool concluido = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------- ATENDIMENTO --------------");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Cliente: {identificacao}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Motivo: {motivo}");
        Console.WriteLine($"Concluído: {concluido}");
        Console.WriteLine("------------------------------------------");
    }
}