internal class Program
{
    private static void Main(string[] args)
    {
        Numeros todos = new Numeros();
        todos.MostrarTodos();

        Mostrar filtrados = new Mostrar();
        filtrados.Filtrar();
    }
}