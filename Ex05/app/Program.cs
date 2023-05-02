using app;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa();

        pessoa1.Nome = "João";
        pessoa1.DefinirIdade(18);

        Console.WriteLine($"Nome: {pessoa1.Nome}");
        Console.WriteLine($"Idade: {pessoa1.Idade}");
    }
}