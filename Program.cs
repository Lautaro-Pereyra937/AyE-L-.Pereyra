namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();

            Personaje accion1 = new Personaje(100, 100, "Volar");
            historialDelPersonaje.Push(accion1);

            Personaje accion2 = new Personaje(100, 77, "Golpear");
            historialDelPersonaje.Push(accion2);

            Personaje accion3 = new Personaje(100, 14, "Tomar");
            historialDelPersonaje.Push(accion3);

            foreach (Personaje acciones in historialDelPersonaje)
            {
                Console.WriteLine($"Todos los cambios almacenados en el historial: Vida total: {acciones.vidatotal} Vida actual: {acciones.vidaactual} Accion: {acciones.ultimaaccion}");
            }

            if (historialDelPersonaje.TryPop(out Personaje personajeactual))
            {
                Console.WriteLine($"Ultima accion borrada: {personajeactual.ultimaaccion}");
            }
            else
            {
                Console.WriteLine("No hay acciones para borrar");
            }
            int dañogolpe = 20;

            Personaje accion4 = new Personaje(100,68, "Golpe recibido");
            historialDelPersonaje.Push(accion4);

            Console.WriteLine($"vida total: {accion4.vidatotal} Vida actual: {accion4.vidaactual-dañogolpe} Accion: {accion4.ultimaaccion}");

        }
    }
}