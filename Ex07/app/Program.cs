using app;

internal partial class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();

        conta.NumeroConta = 123;
        conta.Depositar(1000);
        conta.Sacar(500);
        conta.Depositar(6000);
        conta.Sacar(4000);
    }
}