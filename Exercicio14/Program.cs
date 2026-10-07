using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("           REGISTRO DE LOCAÇÃO");
        Console.WriteLine("========================================");

        Console.Write("Cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Equipamento: ");
        string equipamento = Console.ReadLine();

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de dias: ");
        int dias = int.Parse(Console.ReadLine());

        Console.Write("Valor da locação: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Equipamento disponível? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------- LOCAÇÃO --------------");
        Console.WriteLine($"Cliente: {cliente}");
        Console.WriteLine($"Equipamento: {equipamento}");
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Dias: {dias}");
        Console.WriteLine($"Valor: R$ {valor:F2}");
        Console.WriteLine($"Disponível: {disponivel}");
        Console.WriteLine("-------------------------------------");
    }
}