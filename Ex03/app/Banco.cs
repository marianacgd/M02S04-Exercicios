using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Banco
    {
        private double saldo;


        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
             if (valor <= saldo)
            {
                saldo -= valor;
            } else {
                Console.WriteLine("Seu saldo é insuficiente!!");
            }
        }

        public override string ToString()
        {
            return $"Saldo: {saldo}";
        }

    }
}