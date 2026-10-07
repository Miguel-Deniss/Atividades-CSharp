using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=========== MATRÍCULA ===========");

        Console.Write("Nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Número de matrícula: ");
        int matricula = int.Parse(Console.ReadLine());

        Console.Write("Turno: ");
        string turno = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        bool ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=========== MATRÍCULA ===========");
        Console.WriteLine($"Aluno: {nome}");
        Console.WriteLine($"Matrícula: {matricula}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Turno: {turno}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("=================================");
        Console.WriteLine("MATRÍCULA REGISTRADA COM SUCESSO");
        Console.WriteLine("=================================");
    }
}