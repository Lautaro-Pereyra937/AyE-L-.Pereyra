using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Producto
    {
        public string Nombre { get;set; }

        public int Codigo { get; set; }

        public double Precio { get; set; }
        
        public Producto(string Nombre,int Codigo,double Precio)
        {
            this.Nombre = Nombre;
            this.Codigo = Codigo;
            this.Precio = Precio;
        }
    }
}
