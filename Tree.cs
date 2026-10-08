using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Tree
    {
        public Nodo raiz { get; set; }

        public Tree()
        {
            raiz = null;
        }
        public void Insertar(goleadores_mundial nuevoJugador)
        {
            raiz = insertarRecursivo(nuevoJugador, raiz);
        }
        public Nodo insertarRecursivo(goleadores_mundial nuevoJugador, Nodo nodoActual)
        {
            if (nodoActual == null)
            {
                return new Nodo(nuevoJugador);
            }

            if (nuevoJugador.id < nodoActual.jugador.id)
            {
                nodoActual.nodoIzquierdo = insertarRecursivo(nuevoJugador, nodoActual.nodoIzquierdo);
            }
            else if (nuevoJugador.id > nodoActual.jugador.id)
            {
                nodoActual.nodoDerecho = insertarRecursivo(nuevoJugador, nodoActual.nodoDerecho);
            }

            return nodoActual;
        }

        public string buscar(int idBuscado)
        {
            if(raiz == null)
            {
                return "El árbol está vacío.";
            }

            return BuscarRecursivo(raiz, idBuscado);
        }

        private string BuscarRecursivo(Nodo nodoActual, int idBuscado)
        {

            if (nodoActual == null)
            {
                return $"No se encontró ningún jugador con el ID {idBuscado}.";
            }

            if(idBuscado == nodoActual.jugador.id)
            {
                return $"Jugador encontrado: {nodoActual.jugador.nombre} {nodoActual.jugador.apellido} Pais: {nodoActual.jugador.pais} Posicion: {nodoActual.jugador.posicion} Goles: {nodoActual.jugador.goles} Mundiales Jugados: {nodoActual.jugador.mundiales_jugados}";
            }


            if(idBuscado < nodoActual.jugador.id)
            {
                return BuscarRecursivo(nodoActual.nodoIzquierdo, idBuscado);
            }

            else
            {
                return BuscarRecursivo(nodoActual.nodoDerecho, idBuscado);
            }
        }
    }
}
