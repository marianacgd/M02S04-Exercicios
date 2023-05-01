using app;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaBancaria(2222, 200);

            //Deposito
            conta1.depositar(1000);

            //Saque
            conta1.sacar(600);

            //Verifica Saldo
            Console.WriteLine($"Saldo: {conta1.getSaldo()}");
        }
    }
