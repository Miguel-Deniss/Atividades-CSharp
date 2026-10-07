using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("             RESUMO DO PEDIDO");
        Console.WriteLine("========================================");

        Console.Write("Cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Produto: ");
        string produto = Console.ReadLine();

        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Tipo do pedido: ");
        string tipoPedido = Console.ReadLine();

        Console.Write("Pedido ativo? (true/false): ");
        bool ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------- PEDIDO --------------");
        Console.WriteLine($"Cliente: {cliente}");
        Console.WriteLine($"Produto: {produto}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Valor: R$ {valor:F2}");
        Console.WriteLine($"Tipo: {tipoPedido}");
        Console.WriteLine($"Ativo: {ativo}");
        Console.WriteLine("------------------------------------");
    }
}