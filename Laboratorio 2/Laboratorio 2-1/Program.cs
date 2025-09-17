internal class Program
{
    private static void Main()
    {
        //Asignando valor a variable estatica.
        MyClass.Valor = 1;
        Console.WriteLine(MyClass.Valor);
    }
}
public class MyClass
{
    //Declarando variable estatica.
    public static int Valor;
}