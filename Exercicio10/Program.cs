using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       INSCRIÇÃO EM DESENVOLVIMENTO");
        Console.WriteLine("========================================");

        Console.Write("Nome completo: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("E-mail: ");
        string email = Console.ReadLine();

        Console.Write("Telefone: ");
        string telefone = Console.ReadLine();

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Console.Write("Turno: ");
        string turno = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("          INSCRIÇÃO REALIZADA");
        Console.WriteLine("========================================");
        Console.WriteLine("DADOS DO CANDIDATO");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"E-mail: {email}");
        Console.WriteLine($"Telefone: {telefone}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Turno: {turno}");
        Console.WriteLine("========================================");
    }
}