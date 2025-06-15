// Clase Estudiante para manejar los datos básicos y tres teléfonos

using System;

class Estudiante
{
    // Atributos del estudiante
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public string Direccion { get; set; }
    public string[] Telefonos { get; set; } // Array para guardar los tres teléfonos

    // Constructor
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        Id = id;
        Nombres = nombres;
        Apellidos = apellidos;
        Direccion = direccion;
        Telefonos = telefonos;
    }

    // Método para mostrar los datos del estudiante
    public void MostrarDatos()
    {
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Nombre: " + Nombres + " " + Apellidos);
        Console.WriteLine("Dirección: " + Direccion);
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < Telefonos.Length; i++)
        {
            Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
        }
    }
}

// Programa principal
class Program
{
    static void Main(string[] args)
    {
        // Array de teléfonos
        string[] telefonos = new string[3] { "0987654321", "0998765432", "0976543210" };

        // Crear una instancia del estudiante
        Estudiante estudiante1 = new Estudiante(1, "Carlos", "Pazmiño", "Nueva Loja, Sucumbíos", telefonos);

        // Mostrar los datos
        estudiante1.MostrarDatos();
    }
}
