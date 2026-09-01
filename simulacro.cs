using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<ubicacion> historial_ubicaciones = new Stack<ubicacion>();

            ubicacion ubicacion1 = new ubicacion(10, 13, "bosque");
            historial_ubicaciones.Push(ubicacion1);

            ubicacion ubicacion2 = new ubicacion(50, 33, "savana");
            historial_ubicaciones.Push(ubicacion2);

            ubicacion ubicacion3 = new ubicacion(1, 93, "desierto");
            historial_ubicaciones.Push(ubicacion3);

            foreach(ubicacion ubi in historial_ubicaciones)
            {
                Console.WriteLine($"Coordenada x: {ubi.x} Coordenada y: {ubi.y} nombre zona: {ubi.nombre_zona}");
            }

            ubicacion retroceso = historial_ubicaciones.Pop();
            Console.WriteLine($"Ubicacion removida: {retroceso.nombre_zona} - {retroceso.x} - {retroceso.y}");

            ubicacion actual = historial_ubicaciones.Peek();
            Console.WriteLine($"Ubicacion que quedo en la cima: {actual.nombre_zona} - {actual.x} - {actual.y}");
        }
    }
}
