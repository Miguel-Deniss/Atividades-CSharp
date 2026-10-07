using System;

class Program
{
    static void Main()
    {
        // INFORMAÇÕES IDENTIFICADAS:
        // 1. Nome do funcionário
        // 2. Idade
        // 3. Cidade
        // 4. Cargo
        // 5. Salário
        // 6. Código
        // 7. Funcionário ativo
        // 8. Inicial do nome

        // VARIÁVEIS:
        // nome -> string
        // idade -> int
        // cidade -> string
        // cargo -> string
        // salario -> double
        // codigo -> int
        // ativo -> bool
        // inicial -> char

        Console.WriteLine("========================================");
        Console.WriteLine("       CADASTRO DE FUNCIONÁRIO");
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

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Funcionário ativo? (true/false): ");
        bool ativo = bool.Parse(Console.ReadLine());

        Console.Write("Inicial: ");
        char inicial = char.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("------------- FUNCIONÁRIO -------------");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário: R$ {salario:F2}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine("---------------------------------------");
    }
}