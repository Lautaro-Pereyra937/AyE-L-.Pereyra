using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Tree
    {
        public Nodo raiz { get; set; }

        public Tree()
        {
            raiz = null;
        }

        public void insertar(int Valor)
        {
            raiz = insertarRecursivo(Valor, raiz);
        }
        public Nodo insertarRecursivo(int Valor, Nodo nodoActual)
        {
            if(nodoActual == null)
            {
                return new Nodo(Valor);
            }

            if(Valor < nodoActual.Valor)
            {
                nodoActual.nodoIzquierdo = insertarRecursivo(Valor, nodoActual.nodoIzquierdo);
            }
            else if (Valor > nodoActual.Valor)
            {
                nodoActual.nodoDerecho = insertarRecursivo(Valor, nodoActual.nodoDerecho);
            }

            return nodoActual;
        }

        public bool buscar(int Valor)
        {
             return buscarRecursiva(raiz, Valor);
        }

        public bool buscarRecursiva(Nodo nodoActual, int Valor)
        {
            if(nodoActual == null)
            {
                return false;
            }

            if(nodoActual.Valor == Valor)
            {
                return true;
            }
            if(nodoActual.Valor > Valor)
            {
                return buscarRecursiva(nodoActual.nodoIzquierdo, Valor);
            }
            else
            {
                return buscarRecursiva(nodoActual.nodoDerecho, Valor);
            }
        }

        public int obtenerMinimo()
        {
            if (raiz == null)
            {
                throw new InvalidOperationException("El árbol está vacío.");
            }
            return obtenerMinimoRecursiva(raiz);
        }

        public int obtenerMinimoRecursiva(Nodo nodoActual)
        {
            if(nodoActual.nodoIzquierdo == null)
            {
                return nodoActual.Valor;
            }

            return obtenerMinimoRecursiva(nodoActual.nodoIzquierdo);
        }

        public int obtenerMaximo()
        {
            if (raiz == null)
            {
                throw new InvalidOperationException("El árbol está vacío.");
            }
            return obtenerMaximoRecursiva(raiz);
        }

        public int obtenerMaximoRecursiva(Nodo nodoActual)
        {
            if (nodoActual.nodoDerecho == null)
            {
                return nodoActual.Valor;
            }

            return obtenerMaximoRecursiva(nodoActual.nodoDerecho);
        }


        public int ObtenerCantidadNodos()
        {
            return ObtenerCantidadNodosRecursiva(raiz);
        }
        public int ObtenerCantidadNodosRecursiva(Nodo nodoActual)
        {
            int cont = 0;

            if(nodoActual != null) 
            {
                cont++;

                cont += ObtenerCantidadNodosRecursiva(nodoActual.nodoIzquierdo);

                cont += ObtenerCantidadNodosRecursiva(nodoActual.nodoDerecho);

                return cont;
            }

            if(nodoActual == null)
            {
                return cont;
            }
            
            return ObtenerCantidadNodosRecursiva(nodoActual);
        }
        
        public int ObtenerAltura()
        {
            return ObtenerAlturaRecursiva(raiz);
        }

        public int ObtenerAlturaRecursiva(Nodo nodoActual)
        { 
            if(nodoActual == null)
            {
                return 0;
            }

            int alturaIzq = ObtenerAlturaRecursiva(nodoActual.nodoIzquierdo);

            int alturaDer = ObtenerAlturaRecursiva(nodoActual.nodoDerecho);

            if(alturaDer < alturaIzq)
            {
                return alturaIzq +1;
            }
            else
            {
                return alturaDer +1;
            }
        }

        public int ContarHojas()
        {
            return ContarHojasRecursiva(raiz);
        }

        public int ContarHojasRecursiva(Nodo nodoActual)
        {
            if(nodoActual == null){return 0;}

            if(nodoActual.nodoIzquierdo == null && nodoActual.nodoDerecho == null)
            {
                return 1;
            }

            return ContarHojasRecursiva(nodoActual.nodoIzquierdo) + ContarHojasRecursiva(nodoActual.nodoDerecho);
        }

        public void Eliminar()
        {
            Console.Write("Ingrese un valor para eliminar: ");
            int numEliminar = Convert.ToInt32(Console.ReadLine());

            raiz = eliminarRecursiva(raiz, numEliminar);
        }


        public Nodo eliminarRecursiva(Nodo nodoActual, int numEliminar)
        {
            if(nodoActual == null)
            {
                Console.WriteLine("No esta ese valor");
                return null;
            }
            
            if(nodoActual.Valor == numEliminar)
            {
                nodoActual = null;
                return nodoActual;
            }

            if(numEliminar < nodoActual.Valor)
            {
               nodoActual.nodoIzquierdo = eliminarRecursiva(nodoActual.nodoIzquierdo, numEliminar);
            }
            else
            {
                nodoActual.nodoDerecho = eliminarRecursiva(nodoActual.nodoDerecho, numEliminar);
            }
            
            return nodoActual;
        }

        public bool EsValido()
        {
            return EsValidoRecursiva(raiz);
        }

        public bool EsValidoRecursiva(Nodo nodoActual)
        {
            if (nodoActual == null)
            {
                return true;
            }

            if(nodoActual.nodoIzquierdo != null && nodoActual.nodoIzquierdo.Valor > nodoActual.Valor)
            {
                return false;
            }

            if(nodoActual.nodoDerecho != null && nodoActual.nodoDerecho.Valor < nodoActual.Valor)
            {
                return false;
            }

            return EsValidoRecursiva(nodoActual.nodoIzquierdo) && EsValidoRecursiva(nodoActual.nodoDerecho);
        }
    }
}
