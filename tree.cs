using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class tree
    {
        public nodo raiz { get; set; }

        public tree()
        {
            raiz = null;
        }

        public void insertar(agentes_valorant nuevoA)
        {
            raiz = insertarR(nuevoA, raiz);
        }

        public nodo insertarR(agentes_valorant nuevoA,nodo actual)
        {
            if(actual == null)
            {
                return new nodo(nuevoA);
            }

            if(nuevoA.id < actual.agente.id)
            {
                actual.izq = insertarR(nuevoA, actual.izq);
            }
            else if (nuevoA.id > actual.agente.id)
            {
                actual.der = insertarR(nuevoA, actual.der);
            }

            return actual;
        }

        public string buscar(int idbuscado)
        {
            if(raiz == null)
            {
                return "Arbol vacio";
            }

            return buscarR(raiz, idbuscado);
        }

        public string buscarR(nodo actual,int idbuscado)
        {
            if(actual ==null)
            {
                return "no esta ese id";
            }

            if(actual.agente.id == idbuscado)
            {
                return $"Agente encontrado {actual.agente.nombre_agente} Tipo: {actual.agente.tipo_agente} Fecha: {actual.agente.fecha_lanzamiento} Nacionalidad: {actual.agente.nacionalidad}";
            }

            if(actual.agente.id < idbuscado)
            {
                return buscarR(actual.der, idbuscado);
            }
            else
            {
                return buscarR(actual.izq, idbuscado);
            }
        }
    }
}
