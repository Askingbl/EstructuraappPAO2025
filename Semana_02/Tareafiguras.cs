using System;

namespace FigurasGeometricas
{
    // Clase Circulo que encapsula el radio de un círculo
    public class Circulo
    {
        // Campo privado que almacena el radio del círculo
        private double radio;

        // Constructor que inicializa el radio del círculo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // CalcularArea es una función que devuelve un valor double
        // Se utiliza para calcular el área de un círculo
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // CalcularPerimetro es una función que devuelve un valor double
        // Se utiliza para calcular el perímetro (circunferencia) de un círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase Rectangulo que encapsula el ancho y alto de un rectángulo
    public class Rectangulo
    {
        // Campos privados que almacenan el ancho y alto del rectángulo
        private double ancho;
        private double alto;

        // Constructor que inicializa el ancho y alto del rectángulo
        public Rectangulo(double ancho, double alto)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // CalcularArea es una función que devuelve un valor double
        // Se utiliza para calcular el área de un rectángulo
        public double CalcularArea()
        {
            return ancho * alto;
        }

        // CalcularPerimetro es una función que devuelve un valor double
        // Se utiliza para calcular el perímetro de un rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (ancho + alto);
        }
    }

    // Clase principal Program que contiene el método Main para ejecutar el programa
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un objeto Circulo con radio 5
            Circulo miCirculo = new Circulo(5);

            Console.WriteLine("Círculo:");
            Console.WriteLine($"Área: {miCirculo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {miCirculo.CalcularPerimetro()}");

            // Crear un objeto Rectangulo con ancho 4 y alto 3
            Rectangulo miRectangulo = new Rectangulo(4, 3);

            Console.WriteLine("\nRectángulo:");
            Console.WriteLine($"Área: {miRectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {miRectangulo.CalcularPerimetro()}");

            // Esperar a que el usuario presione una tecla para cerrar la consola
            Console.ReadKey();
        }
    }
}
