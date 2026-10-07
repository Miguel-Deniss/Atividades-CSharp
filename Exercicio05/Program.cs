using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("                 PERFIL");
        Console.WriteLine("========================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Inicial: ");
        char inicial = char.Parse(Console.ReadLine());

        Console.Write("Trabalha? (true/false): ");
        bool trabalha = bool.Parse(Console.ReadLine());

        Console.Write("Estuda? (true/false): ");
        bool estuda = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Altura: {altura:F2} m");
        Console.WriteLine($"Inicial: {inicial}");
        Console.WriteLine($"Trabalha: {trabalha}");
        Console.WriteLine($"Estuda: {estuda}");
        Console.WriteLine("========================================");
    }
}