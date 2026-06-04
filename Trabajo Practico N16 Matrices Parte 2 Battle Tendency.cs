using System.Security.Principal;

void ejercicio1()
{
    int[,] matriz1 = { { 11, 22, 31, 43 },
                       { 64, 85, 76, 65 }, 
                       { 67, 58, 91, 24 }, 
                       { 72, 38, 49, 94 } };

    int suma = 0;

    Console.WriteLine("matriz: ");
    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            Console.Write(matriz1[fila, columna] + " ");
        }
        Console.WriteLine();
    }

    suma += matriz1[0, 0] + matriz1[3, 0] + matriz1[0, 3] + matriz1[3, 3];

    Console.WriteLine($"La suma de las esquinas de la matriz es: {suma}");
}
ejercicio1();

void ejercicio2()
{
    int[,] matriz1 = { { 11, 22, 31},
                       { 64, 85, 76},
                       { 67, 58, 91}};

    int principal = 0;

    int secundaria = 0;

    int resultado = 0;

    Console.WriteLine("Matriz: ");
    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            Console.Write(matriz1[fila, columna] + " ");
        }
        Console.WriteLine();
    }

    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            if (matriz1[fila, fila] == matriz1[columna, columna])
            {
                principal += matriz1[fila, columna];
            }
        }
    }
  
    for (int fila = 0; fila < matriz1.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz1.GetLength(1); columna++)
        {
            resultado = fila+columna;

            if(resultado == 2)
            {
                secundaria += matriz1[fila, columna];
            }
        }
    }

    Console.WriteLine($"La suma de la diagonal principal de la matriz es: {principal}");

    Console.WriteLine($"La suma de la diagonal secundaria de la matriz es: {secundaria}");
}
ejercicio2();

void ejercicio3()
{
    Console.WriteLine("Ingrese un numero para el tamaño de una matriz identidad");
    int tamaño = Convert.ToInt32(Console.ReadLine());

    int[,] creada = new int[tamaño, tamaño];

    for (int fila = 0; fila < creada.GetLength(0); fila++)
    {
        for (int columna = 0; columna < creada.GetLength(1); columna++)
        {
            if(fila == columna)
            {
                creada[fila, columna] = 1;
            }
            else 
            {
                creada[fila, columna] = 0;
            }
        }
    }
    for (int fila = 0; fila < creada.GetLength(0); fila++)
    {
        for (int columna = 0; columna < creada.GetLength(1); columna++)
        {
            Console.Write(creada[fila, columna] + " ");
        }
        Console.WriteLine();
    }

}
ejercicio3();