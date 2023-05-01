

namespace app
{
    public class ContaBancaria
    {
        private int NumeroConta;
        private double Saldo;

        public ContaBancaria(int numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public void depositar(double valor)
        {
            this.Saldo += valor;
        }

        public void sacar(double valor)
        {
            if (valor <= Saldo)
            {
                this.Saldo -= valor;
            } else {
                Console.WriteLine("Seu saldo é insuficiente!!");
            }
        }

        public double getSaldo()
        {
            return Saldo;
        }
    }
}