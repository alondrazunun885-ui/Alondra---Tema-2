using System;

class Persona
{
    private string nombre;
    private int edad;

    public Persona() { }

    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

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

    public void MostrarDatos()
    {
        Console.WriteLine("\n--- Datos de la Persona ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input from user
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        // Object creation
        Persona persona1 = new Persona(nombre, edad);

        // Show data
        persona1.MostrarDatos();
    }
}