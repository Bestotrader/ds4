class Pago
{
    public void Solicitar()
    {
        Console.Write("Ingrese el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());

        if (precio <= 0)
        {
            Console.WriteLine("El precio debe ser positivo.");
            return;
        }

        Console.Write("Forma de pago (efectivo/tarjeta): ");
        string forma = Console.ReadLine().ToLower();

        if (forma == "tarjeta")
        {
            Console.Write("Ingrese el número de cuenta (16 dígitos): ");
            string cuenta = Console.ReadLine();

            if (cuenta.Length == 16 && long.TryParse(cuenta, out _))
                Console.WriteLine("Pago con tarjeta aceptado.");
            else
                Console.WriteLine("Número de cuenta inválido.");
        }
        else if (forma == "efectivo")
        {
            Console.WriteLine("Pago en efectivo aceptado.");
        }
        else
        {
            Console.WriteLine("Forma de pago no reconocida.");
        }
    }
}