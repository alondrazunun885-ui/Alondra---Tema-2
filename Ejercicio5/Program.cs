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
        int opcion;

        do
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Agregar persona");
            Console.WriteLine("2. Mostrar personas");
            Console.WriteLine("3. Eliminar persona");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");

            try
            {
                opcion = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error: Ingresa un número válido.");
                opcion = 0;
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();

                    int edad = 0;
                    bool valido = false;

                    while (!valido)
                    {
                        try
                        {
                            Console.Write("Edad: ");
                            edad = int.Parse(Console.ReadLine());
                            valido = true;
                        }
                        catch
                        {
                            Console.WriteLine("Error: Ingresa un número válido.");
                        }
                    }

                    listaPersonas.Add(new Persona(nombre, edad));
                    Console.WriteLine("Persona agregada.");
                    break;

                case 2:
                    Console.WriteLine("\n--- Lista de Personas ---");
                    if (listaPersonas.Count == 0)
                    {
                        Console.WriteLine("No hay personas registradas.");
                    }
                    else
                    {
                        foreach (Persona p in listaPersonas)
                        {
                            p.MostrarDatos();
                        }
                    }
                    break;

                case 3:
                    Console.Write("Ingresa el nombre a eliminar: ");
                    string nombreEliminar = Console.ReadLine();

                    Persona encontrada = listaPersonas.Find(p => p.Nombre == nombreEliminar);

                    if (encontrada != null)
                    {
                        listaPersonas.Remove(encontrada);
                        Console.WriteLine("Persona eliminada.");
                    }
                    else
                    {
                        Console.WriteLine("Persona no encontrada.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 4);
    }
}