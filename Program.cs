namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();

            Personaje dato1 = new Personaje(100, 100, "manzana");
            historialDelPersonaje.Push(dato1);

            Personaje dato2 = new Personaje(100, 100, "banana");
            historialDelPersonaje.Push(dato2);

            Personaje dato3 = new Personaje(100, 100, "pera");
            historialDelPersonaje.Push(dato3);

            RecorrerPila(historialDelPersonaje);
            VolverEnElTiempo(historialDelPersonaje);
            Golpéar(historialDelPersonaje,90);
            RecorrerPila(historialDelPersonaje);

            void RecorrerPila(Stack<Personaje> historialDelPersonaje)
            {
                foreach (Personaje dato in historialDelPersonaje)
                {
                    Console.WriteLine($"Vida total{dato.VidaTotal} Vida actual: {dato.VidaActual} Ultima accion: {dato.UltimaAccion}");
                }
            }

            void VolverEnElTiempo(Stack<Personaje> historialDelPersonaje)
            {
                if(historialDelPersonaje.TryPop(out Personaje sacarUltimaAccion))
                {
                    Console.WriteLine($"Ultima accion borrada: {sacarUltimaAccion.UltimaAccion}");
                }
                else
                {
                    Console.WriteLine($"No hay acciones");
                }
            }

            void Golpéar(Stack<Personaje> historialDelPersonaje, int VIdaActual)
            {
                Personaje nuevaAccion = new Personaje(100, VIdaActual - 20, "Golpe recibido");
                historialDelPersonaje.Push(nuevaAccion);
            }
        }
    }
}
