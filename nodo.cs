using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class nodo
    {
        public agentes_valorant agente { get; set; }
        public nodo izq { get; set; }
        public nodo der { get; set; }

        public nodo(agentes_valorant agente)
        {
            this.agente = agente;
            izq = null;
            der = null;
        }
    }
}
