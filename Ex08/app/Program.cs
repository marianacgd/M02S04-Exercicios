using app;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();

        cachorro.Nome = "Rex";
        cachorro.Idade = 2;
        cachorro.EmitirSom();

        Gato gato = new Gato();

        gato.Nome = "Garfield";
        gato.Idade = 3;
        gato.EmitirSom();
    }
}