using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct ubicacion
    {
        public int x { get; set; }
        public int y { get; set; }

        public string nombre_zona { get; set; }

        public ubicacion(int x, int y, string nombre_zona)
        {
            this.x = x;
            this.y = y;
            this.nombre_zona = nombre_zona;
        }
    }
}
