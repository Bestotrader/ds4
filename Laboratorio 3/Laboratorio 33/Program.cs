using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introduce la base del rectángulo: ");
        double lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce la altura del rectángulo: ");
        double lado2 = Convert.ToDouble(Console.ReadLine());

        double perimetro = CalculosMatematicos.CalculoPerimetroRectangulo(lado1, lado2);

        Console.WriteLine("El perímetro del rectángulo es: {0}", perimetro);
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
    public static double CalculoPerimetroRectangulo(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }
}