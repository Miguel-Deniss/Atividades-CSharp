using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("========================================");
        Console.WriteLine("        ETIQUETA DE PATRIMÔNIO");
        Console.WriteLine("========================================");

        Console.Write("Equipamento: ");
        string equipamento = Console.ReadLine();

        Console.Write("Marca: ");
        string marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("Ano de aquisição: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Valor: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Número de patrimônio: ");
        int patrimonio = int.Parse(Console.ReadLine());

        Console.Write("Equipamento funcionando? (true/false): ");
        bool funcionando = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------- PATRIMÔNIO --------------");
        Console.WriteLine($"Equipamento: {equipamento}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Aquisição: {ano}");
        Console.WriteLine($"Valor: R$ {valor:F2}");
        Console.WriteLine($"Patrimônio: {patrimonio}");
        Console.WriteLine($"Funcionando: {funcionando}");
        Console.WriteLine("-----------------------------------------");
    }
}