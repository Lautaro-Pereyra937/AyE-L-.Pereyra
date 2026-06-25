void ejercicio1()
{

    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3,},
        new int[] { 4, 5, 6},
        new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            Console.Write(matrizIrregular[i][x] + " ");
        }
        Console.WriteLine(" ");
    }
}
ejercicio1();

Console.WriteLine("-------------------");
void ejercicio2()
{
    int cont = 0;

    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3,},
        new int[] { 4, 5, 6},
        new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            cont++;
        }

    }
    Console.WriteLine($"Hay {cont} elementos");
}
ejercicio2();

Console.WriteLine("--------------------");

void ejercicio3()
{
    int elementos = 0;
    int indice = 0;

    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3,},
        new int[] { 4, 5, 6},
        new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            if (matrizIrregular[i].Length > elementos)
            {
                elementos = matrizIrregular[i].Length;
                indice = i;
            }
        }
    }
    Console.WriteLine($"La fila que tiene mas elementos es {indice}  y tiene: {elementos}");
}
ejercicio3();

Console.WriteLine("------------------");
void ejercicio4()
{
    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3, },
        new int[] { 4, 5, 6 },
        new int[] { 7, 8, 9, 10 }
    };

    int[] sumasfila = new int[matrizIrregular.Length];

    for (int x = 0; x < matrizIrregular.Length; x++)
    {
        int sumafila = 0;

        for (int y = 0; y < matrizIrregular[x].Length; y++)
        {
            sumafila += matrizIrregular[x][y];
        }
        sumasfila[x] = sumafila;
    }
    for (int i = 0; i < sumasfila.Length; i++)
    {
        Console.WriteLine($"La fila {i} da {sumasfila[i]}");
    }
}
ejercicio4();

Console.WriteLine("------------------");
void ejercicio5()
{
    int numeromayor = 0;

    int posx = 0;
    int posy = 0;

    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3, },
        new int[] { 4, 5, 6 },
        new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            if (matrizIrregular[i][x] > numeromayor)
            {
                numeromayor = matrizIrregular[i][x];
                posx = i;
                posy = x;
            }
        }
    }
    Console.WriteLine($"Numero mas grande: {numeromayor} , posicion {posx};{posy}");
}
ejercicio5();

void ejercicio6()
{
    int[][] matrizIrregular =
    {
        new int[] { 1, },
        new int[] { 2, 3, },
        new int[] { 4, 5, 6 },
        new int[] { 7, 8, 9, 10 }
    };

    for (int i = 0; i < matrizIrregular.Length; i++)
    {
        int suma = 0;
            
        for (int x = 0; x < matrizIrregular[i].Length; x++)
        {
            suma += matrizIrregular[i][x];
        }
        double promedio = (double)suma / matrizIrregular[i].Length;

        Console.WriteLine($"El promedio de los alumnos: {promedio}");
    }
}
ejercicio6();

bool ejercicio7(int[][] matriz, int x)
{
    for (int i = 0; i < matriz.Length; i++)
    {
        for (int j = 0; j < matriz[i].Length; j++)
        {
            if (matriz[i][j] == x)
            {
                return true;
            }
        }
    }

    return false;
}

int[][] matrizIrregular =
{
    new int[] { 1 },
    new int[] { 2, 3 },
    new int[] { 4, 5, 6 },
    new int[] { 7, 8, 9, 10 }
};

Console.WriteLine("Ingrese un numero para ver si existe en la matriz irregular:");
int numeroABuscar = Convert.ToInt32(Console.ReadLine());

bool resultado = ejercicio7(matrizIrregular, numeroABuscar);

Console.WriteLine($"El numero esta en la matriz?: {resultado}");