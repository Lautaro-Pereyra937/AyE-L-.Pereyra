using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public struct Personaje
    {
        public int vidatotal { get; set; }
        public int vidaactual { get; set; }
        public string ultimaaccion { get; set; }

        public Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();

        public Personaje(int vidatotal, int vidaactual, string ultimaaccion)
        {
            this.vidatotal = vidatotal;
            this.vidaactual = vidaactual;
            this.ultimaaccion = ultimaaccion;
        }
    }
}
