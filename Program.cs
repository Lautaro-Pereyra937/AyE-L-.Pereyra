using System.Net.NetworkInformation;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] argos)
        {
            using var db = new AppDbContext();

            AppDbContext context = new AppDbContext();

            tree arbolito = new tree();

            List<agentes_valorant> agentes = context.agentes_valorant.ToList();

            Console.WriteLine("Todos los agentes de la base de datos: ");
            foreach(agentes_valorant agente in agentes)
            {
                arbolito.insertar(agente);
                Console.WriteLine($"ID: {agente.id} Nombre agente {agente.nombre_agente} Tipo: {agente.tipo_agente} Fecha: {agente.fecha_lanzamiento} Nacionalidad: {agente.nacionalidad}");
            }

            Console.WriteLine("Ingrese un id para buscar un agente");
            int idbuscado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(arbolito.buscar(idbuscado));

            //await context.SaveChangesAsync();

            int decision = 0;

            while(decision != 5)
            {
                Console.WriteLine("Ingrese 1 para agregar un dato");
                Console.WriteLine("Ingrese 2 para eliminar un dato");
                Console.WriteLine("Ingrese 3 para actualizar un dato");
                Console.WriteLine("Ingrese 4 para consultar un dato");
                Console.WriteLine("Ingrese 5 para salir");
                decision = Convert.ToInt32(Console.ReadLine());

                switch(decision)
                {
                    case 1:
                        Console.WriteLine("Ingrese su id");
                        int iding = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ingrese su nombre_agente");
                        string nombreing = Console.ReadLine();

                        Console.WriteLine("Ingrese su tipo_agente");
                        string tipoing = Console.ReadLine();

                        Console.WriteLine("Ingrese su nacionalidad");
                        string nacionalidadIng = Console.ReadLine();

                        Console.WriteLine("Ingrese su fecha_lanzamiento");
                        string fechaIng = Console.ReadLine();

                        var nuevoing = new agentes_valorant(iding, nombreing,tipoing,nacionalidadIng,fechaIng);

                        context.agentes_valorant.Add(nuevoing);
                        Console.WriteLine("Agente agregado!");
                        await context.SaveChangesAsync();
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el id del agente a eliminar ;(");
                        int idEliminar = Convert.ToInt32(Console.ReadLine());

                        var datobuscado = await context.agentes_valorant.FindAsync(idEliminar);
                        context.agentes_valorant.Remove(datobuscado);

                        Console.WriteLine("Agente eliminado");
                        await context.SaveChangesAsync();

                        break;

                    case 3:
                        int decision2 = 0;

                        while (decision2 != 6)
                        {
                            Console.WriteLine("Ingrese 1 para actualizar su id");
                            Console.WriteLine("Ingrese 2 para actualizar su nombre");
                            Console.WriteLine("Ingrese 3 para actualizar su tipo");
                            Console.WriteLine("Ingrese 4 para actualizar su nacionalidad");
                            Console.WriteLine("Ingrese 5 para actualizar su fecha");
                            Console.WriteLine("Ingrese 6 para salir");
                            decision2 = Convert.ToInt32(Console.ReadLine());

                            switch(decision2)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese su id(el viejo asi lo buscamos)");
                                    int idviejo = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ingrese su nuevo id");
                                    int nuevoId = Convert.ToInt32(Console.ReadLine());

                                    var agenteActualizar = await context.agentes_valorant.FindAsync(idviejo);

                                    agenteActualizar.id = nuevoId;
                                    await context.SaveChangesAsync();
                                    break;

                                case 2:
                                    Console.WriteLine("Ingrese su id(el viejo asi lo buscamos)");
                                    idviejo = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ingrese su nuevo nombre");
                                    string nuevoNombre = Console.ReadLine();

                                    agenteActualizar = await context.agentes_valorant.FindAsync(idviejo);

                                    agenteActualizar.nombre_agente = nuevoNombre;
                                    await context.SaveChangesAsync();
                                    break;

                                case 3:
                                    Console.WriteLine("Ingrese su id(el viejo asi lo buscamos)");
                                    idviejo = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ingrese su nuevo tipo");
                                    string nuevoTipo = Console.ReadLine();

                                    agenteActualizar = await context.agentes_valorant.FindAsync(idviejo);

                                    agenteActualizar.tipo_agente = nuevoTipo;
                                    await context.SaveChangesAsync();
                                    break;

                                case 4:
                                    Console.WriteLine("Ingrese su id(el viejo asi lo buscamos)");
                                    idviejo = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ingrese su nueva nacionalidad");
                                    string nuevaNacionalidad = Console.ReadLine();

                                    agenteActualizar = await context.agentes_valorant.FindAsync(idviejo);

                                    agenteActualizar.nacionalidad = nuevaNacionalidad;
                                    await context.SaveChangesAsync();
                                    break;

                                case 5:
                                    Console.WriteLine("Ingrese su id(el viejo asi lo buscamos)");
                                    idviejo = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Ingrese su nuevo fecha");
                                    string nuevoFecha = Console.ReadLine();

                                    agenteActualizar = await context.agentes_valorant.FindAsync(idviejo);

                                    agenteActualizar.fecha_lanzamiento = nuevoFecha;
                                    await context.SaveChangesAsync();
                                    break;

                                case 6:
                                    Console.WriteLine("saliendo del programa");
                                    break;

                                default:
                                    Console.WriteLine("No esta esa opcion");
                                    break;
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Ingrese el id del agente a buscar");
                        int idbusca = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(arbolito.buscar(idbusca));

                        break;

                    case 5:
                        Console.WriteLine("saliendo del programa");
                        break;

                    default:
                        Console.WriteLine("No esta esa opcion");
                        break;
                }
            }

            ordenamientoBurbuja();

            void ordenamientoBurbuja()
            {
                for(int j = 0;j < agentes.Count -1;j++)
                {
                    for (int i = 0; i < agentes.Count - 1; i++)
                    {
                        if(agentes[i].nombre_agente.CompareTo(agentes[i+1].nombre_agente) > 0)
                        {
                            agentes_valorant temp = agentes[i];
                            agentes[i] = agentes[i + 1];
                            agentes[i + 1] = temp;
                        }
                    }
                }

                Console.WriteLine($"Ordenado alfabeticamente: ");
                for(int u = 0; u < agentes.Count - 1; u++)
                {
                    Console.WriteLine($"Agente nombre: {agentes[u].nombre_agente}");
                }
            }
        }
    }
}
