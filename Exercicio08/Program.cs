using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("       CADASTRO DA BIBLIOTECA");
        Console.WriteLine("========================================");

        Console.Write("Título: ");
        string titulo = Console.ReadLine();

        Console.Write("Autor: ");
        string autor = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Disponível para empréstimo? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------- LIVRO --------------");
        Console.WriteLine($"Título: {titulo}");
        Console.WriteLine($"Autor: {autor}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Preço: R$ {preco:F2}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Disponível: {disponivel}");
        Console.WriteLine("-----------------------------------");
    }
}