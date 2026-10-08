using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Nodo
    {
        public goleadores_mundial jugador { get; set; }

        public Nodo nodoIzquierdo { get; set; }

        public Nodo nodoDerecho { get; set; }

        public Nodo(goleadores_mundial jugador)
        {
            this.jugador = jugador;
            nodoDerecho = null;
            nodoIzquierdo = null;
        }
    }
}
