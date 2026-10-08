using MiBasesitadeDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();
            Tree arbolito = new Tree();

            AppDbContext context = new AppDbContext();

            List<goleadores_mundial> jugadores = context.goleadores_mundial.ToList();

            foreach (goleadores_mundial jugador in jugadores)
            {
                arbolito.Insertar(jugador);
            }

            Console.WriteLine("Ingrese el id del jugador a buscar");
            int idBuscado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(arbolito.buscar(idBuscado));

            int decision = 0;

            while (decision != 5)
            {
                Console.WriteLine("¿Que desea hacer?");
                Console.WriteLine("1- Agregar");
                Console.WriteLine("2- Eliminar");
                Console.WriteLine("3- Actualizar");
                Console.WriteLine("4- Buscar en el arbol");
                Console.WriteLine("5- Finalizar programa");
                decision = int.Parse(Console.ReadLine());

                switch (decision)
                {
                    case 1: 
                        Console.WriteLine("Ingrese el nombre:");
                        string nombreing = Console.ReadLine();

                        Console.WriteLine("Ingrese el apellido:");
                        string apellidoing = Console.ReadLine();

                        Console.WriteLine("Ingrese el país:");
                        string paising = Console.ReadLine();

                        Console.WriteLine("Ingrese la posición:");
                        string posicioning = Console.ReadLine();

                        Console.WriteLine("Ingrese la cantidad de goles:");
                        int golesing = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese la cantidad de mundiales jugados:");
                        int mundiales_jugadosing = int.Parse(Console.ReadLine());

                        var nuevoing = new goleadores_mundial(0, nombreing, apellidoing, paising, posicioning, golesing, mundiales_jugadosing);

                        context.goleadores_mundial.Add(nuevoing);
                        await context.SaveChangesAsync();
                        Console.WriteLine("¡Jugador agregado con éxito!");
                        break; // Cierra el case 1

                    case 2: 
                        Console.WriteLine("Ingrese el id del jugador que desea eliminar:");
                        int id = int.Parse(Console.ReadLine());

                        var datoBuscado = await context.goleadores_mundial.FindAsync(id);

                        if (datoBuscado != null)
                        {
                            context.goleadores_mundial.Remove(datoBuscado);
                            await context.SaveChangesAsync();
                            Console.WriteLine("¡Jugador eliminado de la base de datos con éxito!");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró ningún jugador con el ID {id}.");
                        }
                        break; 

                    case 3:
                        int modificar = 0;
                        string modificars = "";

                        Console.WriteLine("Ingrese el id del jugador que desea modificar:");
                        int id2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Qué campo desea modificar?");
                        Console.WriteLine("1- Nombre");
                        Console.WriteLine("2- Apellido");
                        Console.WriteLine("3- País");
                        Console.WriteLine("4- Posición");
                        Console.WriteLine("5- Goles");
                        Console.WriteLine("6- Mundiales jugados");
                        int decision2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el nuevo valor:");

                        if (decision2 >= 1 && decision2 <= 4)
                        {
                            modificars = Console.ReadLine();
                        }
                        else
                        {
                            modificar = int.Parse(Console.ReadLine());
                        }

                        var jugadorBuscado = await context.goleadores_mundial.FindAsync(id2);

                        if (jugadorBuscado != null)
                        {
                            switch (decision2)
                            {
                                case 1:
                                    jugadorBuscado.nombre = modificars;
                                    break;
                                case 2:
                                    jugadorBuscado.apellido = modificars;
                                    break;
                                case 3:
                                    jugadorBuscado.pais = modificars;
                                    break;
                                case 4:
                                    jugadorBuscado.posicion = modificars;
                                    break;
                                case 5:
                                    jugadorBuscado.goles = modificar;
                                    break;
                                case 6:
                                    jugadorBuscado.mundiales_jugados = modificar;
                                    break;
                            }

                            await context.SaveChangesAsync();
                            Console.WriteLine("¡Jugador modificado con éxito en la base de datos!");
                        }
                        else
                        {
                            Console.WriteLine($"No se encontró ningún jugador con el ID {id2}.");
                        }
                        break; 

                    case 4:
                        Console.WriteLine("Ingrese el id del jugador a buscar");
                        int idBuscado1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(arbolito.buscar(idBuscado1));
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                } 
            } 


            ordenamientoBurbuja1();

            ordenamientoBurbuja2();

            void ordenamientoBurbuja1()
            {
                for (int j = 0; j < jugadores.Count - 1; j++)
                {
                    for (int i = 0; i < jugadores.Count - 1; i++)
                    {
                        if (jugadores[i].nombre.CompareTo(jugadores[i + 1].nombre) > 0)
                        {
                            goleadores_mundial temp = jugadores[i];

                            jugadores[i] = jugadores[i + 1];
                            jugadores[i + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Ordenamiento burbuja alfabeticamente");
                for (int u = 0; u < jugadores.Count; u++)
                {
                    Console.WriteLine(jugadores[u].nombre);
                }
            }
            
            void ordenamientoBurbuja2()
            {
                for (int j = 0; j < jugadores.Count - 1; j++)
                {
                    for (int i = 0; i < jugadores.Count - 1; i++)
                    {
                        if (jugadores[i].mundiales_jugados < jugadores[i + 1].mundiales_jugados)
                        {
                            goleadores_mundial temp = jugadores[i];

                            jugadores[i] = jugadores[i + 1];
                            jugadores[i + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Ordenamiento burbuja por mundiales jugados");
                for(int u = 0;u < jugadores.Count; u++)
                {
                    Console.WriteLine(jugadores[u].mundiales_jugados);
                }
            }
        }
    }
}
