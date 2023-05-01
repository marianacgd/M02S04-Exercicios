using System;
using app;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Mariana", 31, "Rua ABCDario");

        pessoa1.saudacao();
    }
}