using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce el primer numero (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        int resultado = CalculosMatematicos.Calcular(a, b);

        Console.WriteLine("El resultado de ({0}+{1})*({0}-{1}) es: {2}", a, b, resultado);
    }
}
public class CalculosMatematicos
{
    public static int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }
}