using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("         PROGRAMA CORRIGIDO");
        Console.WriteLine("========================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Altura: " + altura);
    }
}