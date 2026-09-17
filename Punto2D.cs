using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBasesitadeDatos
{
    public struct Punto2D 
    {
       public int X { get; set; }
       public int Y { get; set; }

        public Punto2D(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}