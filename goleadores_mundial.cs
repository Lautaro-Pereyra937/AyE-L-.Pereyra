using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class goleadores_mundial
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string pais { get; set; }
        public string posicion { get; set; }
        public int goles { get; set; }
        public int mundiales_jugados { get; set; }

        public goleadores_mundial(int id, string nombre, string apellido, string pais, string posicion, int goles, int mundiales_jugados)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.pais = pais;
            this.posicion = posicion;
            this.goles = goles;
            this.mundiales_jugados = mundiales_jugados;
        }
    }
}
