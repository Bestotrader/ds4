class PruebaVector1
{
    private int[] sueldos; // Declaramos un vector
    public void Cargar()
    {
        sueldos = new int[6]; // Inicializamos el vector con 6 posiciones (usamos de la 1 a la 5)
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operador " + f + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // Asignamos los sueldos al vector
        }
    }
    public void Imprimir()
    {
        Console.WriteLine("Los 5 sueldos de los operarios \n");
        for (int f = 1; f <= 5; f++)
        {
            Console.WriteLine(sueldos[f]);
        }
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.Cargar();
        pv.Imprimir();
    }
}