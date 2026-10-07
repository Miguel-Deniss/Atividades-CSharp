using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("          PRODUTO CADASTRADO");
        Console.WriteLine("========================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Inicial da categoria: ");
        char inicialCategoria = char.Parse(Console.ReadLine());

        Console.Write("Disponível para venda? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------- PRODUTO ---------------");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Preço: R$ {preco:F2}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Categoria - inicial: {inicialCategoria}");
        Console.WriteLine($"Disponível: {disponivel}");
        Console.WriteLine("--------------------------------------");
    }
}