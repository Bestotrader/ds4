using System;
class Program
{
    static void Main(string[] args)
    {
        int suma = 0, cant = 0, valor;
        string linea;
        do
        {
            Console.Write("Ingrese un número (0 para finalizar): ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            if (valor != 0)
            {
                suma += valor;
                cant++;
            }
        } while (valor != 0);

        if (cant != 0)
        {
            int promedio = suma / cant;
            Console.WriteLine("El promedio de los valores ingresados es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron valores.");
        }

        Console.ReadLine();
    }
}