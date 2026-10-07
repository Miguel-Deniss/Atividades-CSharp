using System;

class Program
{
    static void Main()
    {
        // PARTE 1 — Primeiro aluno
        string nome1 = "João";
        int idade1 = 17;
        string cidade1 = "Brotas";
        double altura1 = 1.75;
        string curso1 = "Desenvolvimento de Sistemas";
        bool ativo1 = true;

        // PARTE 2 — Segundo aluno
        string nome2 = "Maria";
        int idade2 = 18;
        string cidade2 = "Jaú";
        double altura2 = 1.65;
        string curso2 = "Desenvolvimento de Sistemas";
        bool ativo2 = true;

        // PARTE 3 — Terceiro aluno
        string nome3 = "Pedro";
        int idade3 = 16;
        string cidade3 = "São Carlos";
        double altura3 = 1.72;
        string curso3 = "Desenvolvimento de Sistemas";
        bool ativo3 = false;

        Console.WriteLine("========================================");
        Console.WriteLine("        ALUNOS CADASTRADOS");
        Console.WriteLine("========================================");

        Console.WriteLine($"Aluno 1: {nome1} | {idade1} anos | {cidade1} | {curso1} | Ativo: {ativo1}");
        Console.WriteLine($"Aluno 2: {nome2} | {idade2} anos | {cidade2} | {curso2} | Ativo: {ativo2}");
        Console.WriteLine($"Aluno 3: {nome3} | {idade3} anos | {cidade3} | {curso3} | Ativo: {ativo3}");

        Console.WriteLine();
        Console.WriteLine("ANÁLISE");
        Console.WriteLine("a) Foram criadas 18 variáveis para três alunos.");
        Console.WriteLine("b) Com 10 alunos, a quantidade de variáveis aumentaria muito.");
        Console.WriteLine("c) Com 100 alunos, o código ficaria muito grande e repetitivo.");
        Console.WriteLine("d) Não seria fácil entender e manter o código.");
        Console.WriteLine("e) Alterações ficariam mais trabalhosas.");
        Console.WriteLine("f) As informações não estão agrupadas em uma estrutura.");
        Console.WriteLine("g) Surge o problema de organizar muitos dados relacionados.");

        Console.WriteLine();
        Console.WriteLine("PROPOSTA");
        Console.WriteLine("Uma estrutura chamada Aluno poderia agrupar:");
        Console.WriteLine("Nome, Idade, Cidade, Altura e Curso.");
        Console.WriteLine("Isso facilitaria representar vários alunos sem repetir");
        Console.WriteLine("uma variável para cada informação de cada pessoa.");
    }
}