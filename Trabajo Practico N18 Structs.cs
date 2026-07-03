using System;
using TP18.EjercicioStruct3;

namespace TP18
{
    public struct Punto2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Posición: ({X}, {Y})");
        }
    }

    public struct Dimensiones
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Dimensiones(int ancho, int alto)
        {
            Ancho = ancho;
            Alto = alto;
        }
    }

    namespace EjercicioStruct3
    {
        public struct Producto
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public double Precio { get; set; }

            public Producto(string nombre, int codigo, double precio)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;
            }
        }


    }

    public struct Estudiante
    {
        public string Nombre { get; set; }
        public double[] Notas { get; set; }

        public Estudiante(string nombre, int cantidadNotas)
        {
            Nombre = nombre;
            Notas = new double[cantidadNotas];
        }

        public double CalcularPromedio()
        {
            double cont = 0;
            foreach (double not in Notas)
            {
                cont += not;
            }
            double promedio = cont / Notas.Length;
            Console.WriteLine($"El promedio del alumno {Nombre} es: {promedio}");
            return promedio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Punto2D punto1 = new Punto2D(5, 10);
            punto1.Mostrar();
            Console.WriteLine();

            Console.WriteLine("Ejercicio 2");
            Dimensiones d1 = new Dimensiones(10, 20);
            Dimensiones d2 = d1;
            d2.Ancho = 99;
            Console.WriteLine($"D1: Ancho: {d1.Ancho}, Alto: {d1.Alto}");
            Console.WriteLine($"D2: Ancho: {d2.Ancho}, Alto: {d2.Alto}");
            Console.WriteLine();

            Console.WriteLine("Ejercicio 3");

            Producto[] array = new Producto[3];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Producto {i + 1}");

                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el código (entero): ");
                int codigo = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio (decimal): ");
                double precio = double.Parse(Console.ReadLine());
                array[i] = new Producto(nombre, codigo, precio);
            }

            foreach (Producto produ in array)
            {
                Console.WriteLine($"Nombre del producto: {produ.Nombre} Precio: ${produ.Precio}");
            }

            Console.WriteLine("Ejercicio 4");
            Estudiante alumno = new Estudiante("Juan", 3);
            alumno.Notas[0] = 8.5;
            alumno.Notas[1] = 9.0;
            alumno.Notas[2] = 7.5;
            alumno.CalcularPromedio();
            Console.WriteLine();
        }
    }
}