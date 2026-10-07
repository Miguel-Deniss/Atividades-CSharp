using System;

class Program
{
    static void Main()
    {
        // Situação escolhida: oficina mecânica
        Console.WriteLine("========================================");
        Console.WriteLine("        CADASTRO DE OFICINA");
        Console.WriteLine("========================================");

        Console.Write("Nome do cliente: ");
        string nomeCliente = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Veículo: ");
        string veiculo = Console.ReadLine();

        Console.Write("Ano do veículo: ");
        int anoVeiculo = int.Parse(Console.ReadLine());

        Console.Write("Quilometragem: ");
        int quilometragem = int.Parse(Console.ReadLine());

        Console.Write("Serviço solicitado: ");
        string servico = Console.ReadLine();

        Console.Write("Valor estimado: ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Orçamento aprovado? (true/false): ");
        bool aprovado = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------- ORDEM --------------");
        Console.WriteLine($"Cliente: {nomeCliente}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Veículo: {veiculo}");
        Console.WriteLine($"Ano: {anoVeiculo}");
        Console.WriteLine($"Quilometragem: {quilometragem} km");
        Console.WriteLine($"Serviço: {servico}");
        Console.WriteLine($"Valor estimado: R$ {valor:F2}");
        Console.WriteLine($"Aprovado: {aprovado}");
        Console.WriteLine("-----------------------------------");
    }
}