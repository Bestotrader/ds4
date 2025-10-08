internal class Program
{
    private static void Main(string[] args)
    {
        Aleatorios ale = new Aleatorios();
        int[] arreglo = ale.GenerarArreglo(5, 1, 10);

        Console.WriteLine("Arreglo generado:");
        foreach (int num in arreglo)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}