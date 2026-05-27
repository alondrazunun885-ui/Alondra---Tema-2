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
        string nombre;
        int edad = 0;
        bool datoCorrecto = false;

        Console.Write("Ingresa tu nombre: ");
        nombre = Console.ReadLine();

        // Validation with try-catch
        while (!datoCorrecto)
        {
            try
            {
                Console.Write("Ingresa tu edad: ");
                edad = int.Parse(Console.ReadLine());
                datoCorrecto = true;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Debes ingresar un número válido.");
            }
        }

        Persona persona1 = new Persona(nombre, edad);
        persona1.MostrarDatos();
    }
}