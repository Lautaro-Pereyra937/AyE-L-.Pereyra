using System.Runtime.CompilerServices;
using static ConsoleApp6.Program;

namespace ConsoleApp6
{
    internal class Program
    {
        public struct Pokemon
        {
            public string nombre { get; set; }
            public int nivel { get; set; }

            public int ps { get; set; }

            public int ataque { get; set; }

            public int defensa { get; set; }

            public int ae { get; set; }

            public int de { get; set; }

            public int velocidad { get; set; }

            public string estado { get; set; }

            public Pokemon(string nombre, int nivel, int ps, int ataque, int defensa, int ae, int de, int velocidad, string estado)
            {
                this.nombre = nombre;
                this.nivel = nivel;
                this.ps = ps;
                this.ataque = ataque;
                this.defensa = defensa;
                this.ae = ae;
                this.de = de;
                this.velocidad = velocidad;
                this.estado = estado;
            }
        }

        public struct Entrenador
        {
            public string nombre { get; set; }
            public int pokedolares { get; set; }
            public string[] medallas { get; set; }
            public Pokemon[] equipo { get; set; }


            public Entrenador(string nombre, int pokedolares, string[] medallas, Pokemon[] equipo)
            {
                this.nombre = nombre;
                this.pokedolares = pokedolares;
                this.medallas = medallas;
                this.equipo = equipo;
            }
            public int damenivel()
            {
                int retorno = 0;
                for (int i = 0; i <= 5; i++)
                {
                    retorno = retorno + equipo[i].nivel;
                }
                return retorno;
            }
        }

        int cant_pokemones_alterados1 = 0;

        int cant_pokemones_alterados2 = 0;

        static void Main(string[] args)
        {
            Pokemon[] equipo1 = new Pokemon[]
            {
                new Pokemon("Pikachu", 50, 150, 90, 55, 110, 50, 90, "Normal"),
                new Pokemon("Charizard", 55, 180, 84, 78, 109, 85, 100, "Normal"),
                new Pokemon("Blastoise", 52, 175, 83, 100, 85, 105, 78, "Normal"),
                new Pokemon("Venusaur", 51, 170, 82, 83, 100, 100, 80, "Normal"),
                new Pokemon("Snorlax", 48, 160, 110, 65, 55, 55, 45, "Normal"),
                new Pokemon("Gengar", 50, 130, 65, 60, 130, 110, 110, "Normal")
            };

            Pokemon[] equipo2 = new Pokemon[]
             {
                new Pokemon("Dragonite", 52, 160, 134, 95, 70, 100, 80, "Normal"),
                new Pokemon("Alakazam", 50, 140, 50, 70, 135, 115, 120, "Normal"),
                new Pokemon("Gyarados", 49, 200, 130, 60, 95, 85, 65, "Normal"),
                new Pokemon("Rhydon", 53, 155, 110, 96, 83, 85, 45, "Normal"),
                new Pokemon("Jolteon", 50, 135, 110, 100, 50, 70, 130, "Normal"),
                new Pokemon("Starmie", 51, 145, 105, 75, 100, 90, 115, "Congelado")
             };

            string[] medallas = new string[8]
            {
                "Medalla Roca",
                "Medalla Cascada",
                "Medalla Trueno",
                "Medalla Arcoíris",
                "Medalla Alma",
                "Medalla Pantano",
                "Medalla Volcán",
                "Medalla Tierra"
            };

            Entrenador entrenador1 = new Entrenador("Ash", 500, medallas, equipo1);
            Entrenador entrenador2 = new Entrenador("Pepe", 100, medallas, equipo2);

            if (entrenador1.damenivel() > entrenador2.damenivel())
            {
                Console.WriteLine(entrenador1.nombre + " Tiene mas nivel que: " + entrenador2.nombre);
            }
            else if (entrenador2.damenivel() > entrenador1.damenivel())
            {
                Console.WriteLine(entrenador2.nombre + " Tiene mas nivel que: " + entrenador1.nombre);
            }
            else
            {
                Console.WriteLine("Tienen el mismo nivel");
            }

            contar_medallas(entrenador1,entrenador2);
            comprar_pocion(entrenador1, entrenador2);
            mayor_cant_pokemones_alterados(entrenador1, entrenador2);
        }

        static int contar_medallas(Entrenador entrenador1, Entrenador entrenador2)
        {
            if(entrenador1.medallas.Length > entrenador2.medallas.Length)
            {
                Console.WriteLine(entrenador1.nombre + " Tiene mas medallas que: " + entrenador2.medallas.Length);
                return entrenador1.medallas.Length;
            }
            else if (entrenador2.medallas.Length > entrenador1.medallas.Length)
            {
                Console.WriteLine(entrenador2.medallas.Length + " Tiene mas medallas que: " + entrenador1.medallas.Length);
                return entrenador2.medallas.Length;
            }
            else
            {
                Console.WriteLine("Tienen la misma cantidad de medallas");
                return entrenador1.medallas.Length;
            }
        }

        static int mayor_cant_pokemones_alterados(Entrenador entrenador1, Entrenador entrenador2)
        {
            int cant_pokemones_alterados1 = 0;

            int cant_pokemones_alterados2 = 0;

            for (int i = 0; i < entrenador1.equipo.Length; i++)
            {
                if(entrenador1.equipo[i].estado != "Normal")
                {
                    cant_pokemones_alterados1 += 1;
                }
                if(entrenador2.equipo[i].estado != "Normal")
                {
                    cant_pokemones_alterados2 += 1;
                }
            }
            if(cant_pokemones_alterados1 > cant_pokemones_alterados2)
            {
                Console.WriteLine(entrenador1.nombre + " Tiene mas pokemones alterados que " + entrenador2.nombre);
            }
            else
            {
                Console.WriteLine(entrenador2.nombre + " Tiene mas pokemones alterados que " + entrenador1.nombre);
            }
            return cant_pokemones_alterados1;
            return cant_pokemones_alterados2;
        }

        static void comprar_pocion(Entrenador entrenador1, Entrenador entrenador2)
        {
            Console.WriteLine("Ingrese 1 si el entrenador 1 quiere comprar la pocion o 2 si el entrenador quiere comprar la pocion(3 para salir)");
            bool ejecutando = true;

            while (ejecutando == true)
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        if (entrenador1.pokedolares > 200)
                        {
                            entrenador1.pokedolares -= 200;
                            Console.WriteLine("La pocion ya es suya");
                        }
                        else{ Console.WriteLine("No pudo comprarla"); }
                        break;

                    case 2:
                        if (entrenador2.pokedolares > 200)
                        {
                            entrenador2.pokedolares -= 200;
                            Console.WriteLine("La pocion ya es suya");
                        }
                        else { Console.WriteLine("No pudo comprarla"); }
                        break;

                    case 3:
                        Console.WriteLine("Saliendo");
                        ejecutando = false;
                        break;

                    default:
                        Console.WriteLine("no ingrese eso");
                        break;
                }
            }
        }
    }
}
