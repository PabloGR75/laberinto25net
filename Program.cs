using System;

namespace HolaMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");

            // Crear una instancia de la clase Persona
            Persona persona = new Persona("Juan", 30);
            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }
    }

    // Definición de la clase Persona con atributos (propiedades)
    class Persona
    {
        // Propiedades (atributos) de la clase
        public string Nombre { get; set; }
        public int Edad { get; set; }

        // Constructor para inicializar la clase
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
