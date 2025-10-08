class Aleatorios
{
    private Random generador = new Random();

    public int GenerarEntre(int min, int max)
    {
        return generador.Next(min, max + 1);
    }

    public int[] GenerarArreglo(int cantidad, int min, int max)
    {
        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = GenerarEntre(min, max);
        }
        return arreglo;
    }
}