using static System.Net.WebRequestMethods;

void ejercicio1()
{
    int[,] matriz1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            Console.Write(matriz1[fila, columna] + " ");
        }
        Console.WriteLine();
    }
}
ejercicio1();

void ejercicio2()
{
    int[,] matriz1 = { { 10, 20, 35 }, { 44, 52, 61 }, { 75, 87, 99 } };

    int suma = 0;

    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            suma = suma + matriz1[fila, columna];
        }
        Console.WriteLine();
    }
    Console.WriteLine($"La suma de esta matriz 3x3 es: {suma}");
}
ejercicio2();

void ejercicio3()
{
    int[,] matriz1 = { { 10, 20, 35, 43 }, { 44, 52, 61, 1 }, { 75, 87, 99, 5 }, { 7, 8, 9, 1 } };

    Console.WriteLine("Ingrese la fila de una matriz 4x4 para ver sus elementos");
    int fila = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese la columna de una matriz 4x4 para ver sus elementos");
    int columna = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(matriz1[fila, columna]);
}
ejercicio3();

void ejercicio4()
{
    int[,] matriz1 = { { 10, 20, 35, 43 },
                       { 44, 52, 61, 1 },
                       { 75 , 87, 99, 5 },
                       { 7, 8, 9, 1 } };

    int grande = 0;

    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            if (grande < matriz1[fila, columna])
            {
                grande = matriz1[fila, columna];
            }
        }
    }
    Console.WriteLine($"El numero mas grande de la matriz es: {grande}");
}
ejercicio4();

void ejercicio5()
{
    int[,] matriz1 = { { 10, 20, 35, 43 }, 
                       { 44, 52, 61, 1 }, 
                       { 75 , 87, 99, 5 }, 
                       { 7, 8, 9, 1 } };

    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        int suma_filas = 0;
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            suma_filas += matriz1[fila, columna];
        }
        Console.WriteLine($"La suma de las filas es: {suma_filas}");
    }

    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        int suma_colu = 0;
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            suma_colu += matriz1[fila, columna];
        }
        Console.WriteLine($"La suma de las columnas son: {suma_colu}");
    }
}
ejercicio5();

void ejercicio6()
{
    int[,] matriz1 = { { 10, 20, 35, 43 },
                       { 44, 52, 61, 1 },
                       { 75 , 87, 99, 5 },
                       { 7, 8, 9, 1 } };

    Console.WriteLine("La matriz traspuesta es: ");

    for(int columna = 0; columna < matriz1.GetLength(1); columna++)
    {
        for(int fila = 0; fila < matriz1.GetLength(0); fila++)
        {
            Console.Write(matriz1[fila, columna] + " ");
        }
        Console.WriteLine();
    }
    int[,] matriz2 = new int[4,4];

    matriz2 = matriz1;

    Console.WriteLine("Matriz guardada: ");

    for (int fila = 0; fila < matriz2.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz2.GetLength(1); columna++)
        {
            Console.Write(matriz2[columna, fila] + " ");
        }
        Console.WriteLine();
    }
}
ejercicio6();