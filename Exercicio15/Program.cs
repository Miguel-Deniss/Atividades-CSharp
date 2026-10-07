using System;

class Program
{
    static void Main()
    {
        // Cadastro básico de uma pessoa
        Console.WriteLine("========================================");
        Console.WriteLine("          CADASTRO DE PESSOA");
        Console.WriteLine("========================================");

        Console.Write("Nome: ");
        string nomeCompleto = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        // Apresentação organizada dos dados
        Console.WriteLine();
        Console.WriteLine("========================================");
        Console.WriteLine("             DADOS CADASTRADOS");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome: {nomeCompleto}");
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Altura: {altura:F2} m");
        Console.WriteLine("========================================");

        // O programa funcionar não significa que esteja bem desenvolvido.
        // Organização, nomes claros, comentários e saída legível facilitam
        // manutenção, entendimento e futuras alterações.
    }
}