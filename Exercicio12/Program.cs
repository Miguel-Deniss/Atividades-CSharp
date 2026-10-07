using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       EVENTO TECNOLÓGICO SENAI");
        Console.WriteLine("========================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Console.Write("Código do participante: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Ingresso: ");
        string ingresso = Console.ReadLine();

        Console.Write("Valor da inscrição: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Participação confirmada? (true/false): ");
        bool confirmada = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("------------- PARTICIPANTE -------------");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Ingresso: {ingresso}");
        Console.WriteLine($"Valor: R$ {valor:F2}");
        Console.WriteLine($"Confirmada: {confirmada}");
        Console.WriteLine("----------------------------------------");
    }
}