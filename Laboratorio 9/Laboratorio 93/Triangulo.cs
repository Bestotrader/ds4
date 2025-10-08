class Triangulo
{
    public void Clasificar()
    {
        Console.Write("Ingrese lado A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Ingrese lado B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Ingrese lado C: ");
        int c = int.Parse(Console.ReadLine());

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("No se puede formar un triángulo.");
            return;
        }

        if (a == b && b == c)
            Console.WriteLine("Triángulo equilátero");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Triángulo isósceles");
        else
            Console.WriteLine("Triángulo escaleno");
    }
}