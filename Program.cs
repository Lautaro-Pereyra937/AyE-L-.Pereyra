namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree arbolito = new Tree();

            arbolito.insertar(7);
            arbolito.insertar(50);
            arbolito.insertar(45);
            arbolito.insertar(2);
            arbolito.insertar(8);
            arbolito.insertar(12); 
            arbolito.insertar(9);
            arbolito.insertar(87);
            arbolito.insertar(26);
            arbolito.insertar(36);
            arbolito.insertar(026);
            arbolito.insertar(598);
            arbolito.insertar(48);
            arbolito.insertar(9);

            Console.WriteLine(arbolito.buscar(24));

            Console.WriteLine("Valor minimo: ");
            Console.WriteLine(arbolito.obtenerMinimo());
            Console.WriteLine("Valor maximo: ");
            Console.WriteLine(arbolito.obtenerMaximo());

            Console.WriteLine("Cantidad nodos: ");
            Console.WriteLine(arbolito.ObtenerCantidadNodos());

            Console.WriteLine("Altura: ");
            Console.WriteLine(arbolito.ObtenerAltura());

            Console.WriteLine("Cant hojas: ");
            Console.WriteLine(arbolito.ContarHojas());

            arbolito.Eliminar();
            Console.WriteLine("Numero eliminado");

            Console.WriteLine(arbolito.EsValido());
        }
    }
}
