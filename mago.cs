using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class mago
    {
        public int vidaTotal { get; set; }
        public int vidaActual { get; set; }

        public string ultimoHechizo { get; set; }

        public mago(int vidaTotal, int vidaActual , string ultimoHechizo)
        {
            this.vidaTotal = vidaTotal;
            this.vidaActual = vidaActual;
            this.ultimoHechizo = ultimoHechizo;
        }
    }
}
