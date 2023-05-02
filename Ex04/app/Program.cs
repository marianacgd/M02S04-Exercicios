using app;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();

        // Depositar
        conta.Depositar(1000);

        Console.WriteLine("Saldo após o depósito: " + conta.Saldo);

        // Tentativa saque valor maior q o saldo disponível
        bool saque1 = conta.Sacar(2000);

        Console.WriteLine("Saque de R$ 2000.00" + (saque1 ? " realizado com sucesso!" : " não foi possível realizar o saque."));

        // Saque valor menor q o saldo disponível

        bool saque2 = conta.Sacar(500);

        Console.WriteLine("Saque de R$ 500,00" + (saque2 ? " realizado com sucesso!" : " não foi possível realizar o saque."));


        Console.WriteLine("Saldo após os saques: " + conta.Saldo);
    }
}