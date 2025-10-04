using System;

class Persona
{
    // Campo de cada objeto Persona que almacena su nombre
    public string Nombre;

    // Campo de cada objeto Persona que almacena su edad
    public int Edad;

    // Campo de cada objeto Persona que almacena su NIF
    public string NIF;

    // Constructor de Persona
    public Persona(string nombre, int edad, string nif)
    {
        Nombre = nombre;
        Edad = edad;
        NIF = nif;
    }

    // Incrementa en uno la edad del objeto Persona
    public void Cumpleaños()
    {
        Edad++;
    }
}