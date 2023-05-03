using app;
internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Valor de Pi: " + Calculadora.Pi);

        int a = 10;
        int b = 5;

        Console.WriteLine("Soma: " + Calculadora.Soma(a, b));
        Console.WriteLine("Subtração: " + Calculadora.Subtracao(a, b));
        Console.WriteLine("Multiplicação: " + Calculadora.Multiplicacao(a, b));
        Console.WriteLine("Divisão: " + Calculadora.Divisao(a, b));
    }
}