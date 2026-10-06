using System.Collections;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        //¿Que condiciones se deben de cumplir para poder utilizar ese tipo de ordenamiento?
        //Busqueda Secuencial simple: ninguna
        //Busqueda secuencial optimizada: lista ordenada
        //Busqueda binaria: lista ordenada

        //¿Cual creen que es la búsqueda mas eficiente?
        //La busqueda mas eficiente en mi opinion , depende si la lista esta desordenada u ordenada , para listar ordenadas la mas eficiente es la binaria, ya que si estas buscando
        //el 4 y lo compara con un 5 descarta del 5 para delante, lo mismo con la parte menor. Si la lista esta desordenada solo podemos usar la busqueda secuencial.

        //¿Cual creen que es el ordenamiento mas eficiente?
        //Para el ordenamiento mas eficiente es el QuickSort ; complejidad temporal(promedio):O(nn)	Complejidad temporal por caso:O(n2)
        //

        //¿Que es la complejidad algoritmica?
        //La complejidad algorítmica es una medida teórica que evalúa cuántos recursos (tiempo de ejecución o espacio en memoria) necesita un algoritmo para resolverse en función
        //del tamaño de los datos de entrada.
        static void Main(string[] args)
        {
            int[] numbers = [35, 2, 33, 32, 16, 1, 7, 37, 48, 6, 5, 28, 23, 36, 15, 13, 42, 44, 4, 39, 17, 18, 26, 9, 12, 21, 30, 27, 43, 3, 19, 45, 11, 20, 34, 40, 49, 38, 50, 31, 47, 29, 22, 8, 14, 41, 25, 24, 46, 10];
            int[] numbersOrdenados = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };

            bool encontrado = false;
            bool encontrado1 = false;

            ordenamientoBurbuja();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            ordenamientoBurbujaOptimizado();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            ordenamientoSeleccion();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Inserción();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            Quicksort(numbers, 0, numbers.Length - 1);

            Console.WriteLine("Arreglo ordenado: " + string.Join(", ", numbers));

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            ordenamientoStalin();

            Console.WriteLine("--------------------------------------------------------------------------------------------------");

            ordenamientoBogo();

            Console.WriteLine("Ingrese un numero de la lista a buscar con busqueda secuencial: ");
            int numeroAbuscar = Convert.ToInt32(Console.ReadLine());

            BusquedaSecuencial(numeroAbuscar);

            Console.WriteLine("Ingrese un numero de la lista a buscar con busqueda secuencial optimizada: ");
            int numeroAbuscar1 = Convert.ToInt32(Console.ReadLine());

            BusquedaSecuencialOptimizada(numeroAbuscar1);

            Console.WriteLine("Ingrese un numero de la lista a buscar con busqueda binaria : ");
            int numeroAbuscar2 = Convert.ToInt32(Console.ReadLine());

            BusquedaBinaria(numeroAbuscar2);

            void BusquedaSecuencial(int numeroAbuscar)
            {
                //recorremos todo el array
                for (int n = 0; n < numbers.Length; n++)
                {
                    if (numeroAbuscar == numbers[n])
                    {
                        //mostramos el id , y como lo encontramos cambiamos encontrado a true
                        Console.WriteLine($"El numero si estaba en la lista: {numbers[n]} ; id: {n}");
                        encontrado = true;
                        break;
                    }
                }

                //si no se encontró mostramos que no estaba en la lista
                if (!encontrado)
                {
                    Console.WriteLine("No estaba en la lista");
                }
            }

            void BusquedaSecuencialOptimizada(int numeroAbuscar1)
            {
                for (int nu = 0; nu < numbersOrdenados.Length; nu++)
                {
                    if (numbersOrdenados[nu] == numeroAbuscar1)
                    {
                        Console.WriteLine($"Numero encontrado: {numbersOrdenados[nu]} , Id: {nu}");
                        encontrado1 = true;
                        break;
                    }

                    if (numbersOrdenados[nu] > numeroAbuscar1)
                    {
                        Console.WriteLine($"Numero no encontrado");
                        break;
                    }
                }

                if (!encontrado1)
                {
                    Console.WriteLine("No estaba en la lista");
                }
            }

            void BusquedaBinaria(int numeroAbuscar2)
            {
                int inicio = 0;
                int fin = 0;
                int medio = (inicio + fin) / 2;

                while (inicio <= fin)
                {
                    if (numbers[medio] == numeroAbuscar2)
                    {
                        Console.WriteLine($"Numero encontrado: {numbers[medio]} , Id: {medio}");
                        encontrado1 = true;
                        break;
                    }

                    else if (numeroAbuscar2 < numbers[medio])
                    {
                        fin = medio - 1;
                    }
                    else
                    {
                        inicio = medio + 1;
                    }
                }
            }

            void ordenamientoBurbuja()
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            int cambio = 0;
                            cambio = numbers[i];
                            numbers[i] = numbers[i + 1];
                            numbers[i + 1] = cambio;
                        }
                    }
                }

                Console.WriteLine("Ordenamiento burbuja:");
                for (int u = 0; u < numbers.Length; u++)
                {
                    Console.WriteLine(numbers[u]);
                }
            }

            void ordenamientoBurbujaOptimizado()
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    bool cambio = false;

                    for (int i = 0; i < numbers.Length - 1 - j; i++)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            int cambio1 = 0;
                            cambio1 = numbers[i];
                            numbers[i] = numbers[i + 1];
                            numbers[i + 1] = cambio1;

                            cambio = true;
                        }
                    }
                    if (cambio == false)
                    {
                        break;
                    }
                }

                Console.WriteLine("Ordenamiento burbuja optimizado");
                for (int u = 0; u < numbers.Length; u++)
                {
                    Console.WriteLine(numbers[u]);
                }
            }

            void ordenamientoSeleccion()
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    int indiceMin = j;
                    for (int i = j + 1; i < numbers.Length - 1; i++)
                    {
                        if (numbers[indiceMin] > numbers[i])
                        {
                            indiceMin = i;
                            int cambiotemp = 0;

                            cambiotemp = numbers[j];
                            numbers[j] = numbers[indiceMin];

                            numbers[indiceMin] = cambiotemp;
                        }
                    }
                }

                Console.WriteLine("Ordenamiento seleccion");
                for (int u = 0; u < numbers.Length; u++)
                {
                    Console.WriteLine(numbers[u]);
                }
            }

            void Inserción()
            {
                for (int i = 1; i < numbers.Length; i++)
                {
                    int clave = numbers[i];

                    int j = i - 1;

                    while (j >= 0 && numbers[j] > clave)
                    {
                        numbers[j + 1] = numbers[j];
                        j = j - 1;
                    }

                    numbers[j + 1] = clave;
                }

                Console.WriteLine("Ordenamiento insercion");
                for (int u = 0; u < numbers.Length; u++)
                {
                    Console.WriteLine(numbers[u]);
                }
            }

            static void Quicksort(int[] arr, int izquierdo, int derecho)
            {
                if (izquierdo < derecho)
                {
                    int indicePivote = Particionar(arr, izquierdo, derecho);

                    Quicksort(arr, izquierdo, indicePivote - 1);

                    Quicksort(arr, indicePivote + 1, derecho);
                }
            }

            static int Particionar(int[] arr, int izquierdo, int derecho)
            {
                int pivote = arr[derecho];
                int i = izquierdo - 1;

                for (int j = izquierdo; j < derecho; j++)
                {
                    if (arr[j] <= pivote)
                    {
                        i++;
                        Intercambiar(arr, i, j);
                    }
                }

                Intercambiar(arr, i + 1, derecho);

                return i + 1;
            }

            static void Intercambiar(int[] arr, int a, int b)
            {
                int temporal = arr[a];
                arr[a] = arr[b];
                arr[b] = temporal;
            }

            void ordenamientoStalin()
            {
                List<int> noBorrados = new List<int>();

                if (numbers.Length > 0)
                {
                    noBorrados.Add(numbers[0]);

                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] >= noBorrados[noBorrados.Count - 1])
                        {
                            noBorrados.Add(numbers[i]);
                        }
                    }
                }

                Console.WriteLine("Ordenamiento Stalin");
                foreach (int num in noBorrados)
                {
                    Console.WriteLine(num);
                }
            }

            void ordenamientoBogo()
            {
                Random rand = new Random();
                bool ordenado = false;

                while(!ordenado)
                {
                    for (int i = numbers.Length - 1; i > 0; i--)
                    {
                        int j = rand.Next(0, i + 1);

                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }

                    ordenado = true; 
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        if (numbers[i] > numbers[i + 1])
                        {
                            ordenado = false;
                            break;
                        }
                    }
                }

                Console.WriteLine("Ordenamiento bogosort");
                for (int u = 0; u < numbers.Length; u++)
                {
                    Console.WriteLine(numbers[u]);
                }
            }
        }
    }
}