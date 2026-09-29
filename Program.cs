using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<mago> hechizosquetiro = new Stack<mago>();


            //creo las 3 instancias y las agrego a la pila con push
            mago hechizo1 = new mago(100, 80, "Bola de nieve");
            hechizosquetiro.Push(hechizo1);

            mago hechizo2 = new mago(100, 40, "Bola de fuego");
            hechizosquetiro.Push(hechizo2);

            mago hechizo3 = new mago(100, 1, "Bola de hielo");
            hechizosquetiro.Push(hechizo3);

            recorrer(hechizosquetiro);

            Console.WriteLine($"---------------------------------");

            volverEnElTiempo(hechizosquetiro);

            golpear(hechizosquetiro, 80);

            Console.WriteLine($"---------------------------------");

            recorrer(hechizosquetiro);

            void golpear(Stack<mago> hechizosquetiro, int vidaActual)
            {
                mago nuevaAccion = new mago(100, vidaActual - 20, "espinas");
                hechizosquetiro.Push(nuevaAccion);
            }

            void recorrer(Stack<mago> hechizosquetiro)
            {
                foreach(mago mago in hechizosquetiro)
                {
                    Console.WriteLine($"Vida total: {mago.vidaTotal} Vida actual: {mago.vidaActual} Ultimo Hechizo: {mago.ultimoHechizo}");
                }
            }

            void volverEnElTiempo(Stack<mago> hechizosquetiro)
            {
                //me fijo con trypop primero ya que si la pila esta vacia va a tirar un error
                if(hechizosquetiro.TryPop(out mago retroceder))
                {
                    Console.WriteLine($"Ultimo hechizo borrado: {retroceder.ultimoHechizo}");
                }
                else
                {
                    Console.WriteLine("No hay hechizos cargados");
                }
            }
        }
    }
}
