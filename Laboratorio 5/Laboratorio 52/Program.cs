class Matriz
{
    private int[,] mat;
    public void Ingresar()
    {
        mat = new int[3, 4]; // Matriz de 3 filas y 4 columnas
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write("Ingrese posicion [" + f + "," + c + "]: ");
                string linea = Console.ReadLine();
                mat[f, c] = int.Parse(linea); // Asignamos el valor ingresado
            }
        }
    }
    public void Imprimir()
    {
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write(mat[f, c] + " ");
            }
            Console.WriteLine(); // Salto de línea por fila
        }
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        Matriz ma = new Matriz();
        ma.Ingresar();
        ma.Imprimir();
    }
}