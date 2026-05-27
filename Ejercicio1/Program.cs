using System;

// Class definition
class Persona
{
    // Attributes (encapsulation)
    private string nombre;
    private int edad;

    // Empty constructor
    public Persona() { }

    // Full constructor
    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    // Getters and Setters
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    // Method to show data
    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Object creation
        Persona persona1 = new Persona("yami", 18);

        // Calling method
        persona1.MostrarDatos();
    }
}