using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Nodo
    {
    public int Valor { get; set; }

        public Nodo nodoIzquierdo { get; set; }

        public Nodo nodoDerecho { get; set; }

        public Nodo(int Valor)
        {
            this.Valor = Valor;
            nodoDerecho = null;
            nodoIzquierdo = null;
        }
    }
}
