using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("          CADASTRO DE VEÍCULO");
        Console.WriteLine("========================================");

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Ano: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Primeira letra da marca: ");
        char inicialMarca = char.Parse(Console.ReadLine());

        Console.Write("Disponível para venda? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("============= VEÍCULO =============");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Preço: R$ {preco:F2}");
        Console.WriteLine($"Categoria: {categoria}");
        Console.WriteLine($"Inicial: {inicialMarca}");
        Console.WriteLine($"Disponível: {disponivel}");
        Console.WriteLine("===================================");
    }
}