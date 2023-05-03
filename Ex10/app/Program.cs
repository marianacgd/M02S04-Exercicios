using app;
internal partial class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();

        conta.Deposito(1000);
        Console.WriteLine($"Saldo: {conta.VerificarSaldo()}");

        conta.Retirada(500);
        Console.WriteLine($"Saldo: {conta.VerificarSaldo()}");

        conta.Deposito(200);
        Console.WriteLine($"Saldo: {conta.VerificarSaldo()}");

        Console.WriteLine("Transações:");

        foreach (string transacao in conta.VerificarTransacoes())
        {
            Console.WriteLine(transacao);
        }
    }
}