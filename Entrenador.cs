using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Entrenador
    {
        // propiedades

        public string nombre { get; set; }
        public int pokedolares { get; set; }
        public Pokemon[] equipo { get; set; }

        //constructor

        public Entrenador(string nombre, int pokedolares, Pokemon[] equipo)
        { 
            this.nombre = nombre;
            this.pokedolares = pokedolares;
            this.equipo = equipo;
        }

        //funciones

        //funcion dame nivel recorre la lista de pokemons y suma todos sus niveles

        public bool perdio()
        {
            // si perdio es verdadero si no perdio es falso
            int contador = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (equipo[i].psa > 0)
                {
                    contador++;
                }
            }
            if (contador > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
