using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalculosMatematicos.CalculoArea(radio);

        Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);
    }
}
public class CalculosMatematicos
{
    public static int Calcular(int a, int b)
    {
        return (a + b) * (a - b);
    }
    public static double CalculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }
}