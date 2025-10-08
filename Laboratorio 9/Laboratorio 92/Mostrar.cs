class Mostrar
{
    public void Filtrar()
    {
        Console.WriteLine("Números pares o divisibles entre 3:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}