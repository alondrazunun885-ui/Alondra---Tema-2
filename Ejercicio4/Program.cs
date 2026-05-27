using System;
using System.Collections.Generic;

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
        Console.WriteLine("Nombre: " + nombre + " | Edad: " + edad);
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Persona> listaPersonas = new List<Persona>();

        string opcion;

        do
        {
            Console.Write("\nIngresa nombre: ");
            string nombre = Console.ReadLine();

            int edad = 0;
            bool valido = false;

            while (!valido)
            {
                try
                {
                    Console.Write("Ingresa edad: ");
                    edad = int.Parse(Console.ReadLine());
                    valido = true;
                }
                catch
                {
                    Console.WriteLine("Error: Ingresa un número válido.");
                }
            }

            Persona p = new Persona(nombre, edad);
            listaPersonas.Add(p);

            Console.Write("\n¿Deseas agregar otra persona? (s/n): ");
            opcion = Console.ReadLine().ToLower();

        } while (opcion == "s");

        Console.WriteLine("\n--- Lista de Personas ---");

        foreach (Persona p in listaPersonas)
        {
            p.MostrarDatos();
        }
    }
}