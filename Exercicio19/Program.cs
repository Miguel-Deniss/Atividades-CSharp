using System;

class Program
{
    static void Main()
    {
        // Sistema profissional de cadastro de funcionários
        Console.WriteLine("==============================================");
        Console.WriteLine("       SISTEMA DE CADASTRO DE FUNCIONÁRIOS");
        Console.WriteLine("==============================================");

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

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Setor: ");
        string setor = Console.ReadLine();

        Console.Write("Inicial: ");
        char inicial = char.Parse(Console.ReadLine());

        Console.Write("Está ativo? (true/false): ");
        bool ativo = bool.Parse(Console.ReadLine());

        Console.Write("Anos na empresa: ");
        int anosEmpresa = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("              DADOS CADASTRADOS");
        Console.WriteLine("==============================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário: R$ {salario:F2}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Setor: {setor}");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine($"Anos na empresa: {anosEmpresa}");
        Console.WriteLine("==============================================");
    }
}