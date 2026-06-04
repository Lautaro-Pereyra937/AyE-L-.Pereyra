using System.ComponentModel;

try
{
    void ejercicio1()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Ingrese el numero n°{i + 1}");

            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Los numeros ingresados fueron: ");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
    ejercicio1();
}
catch (System.FormatException)
{
    Console.WriteLine("Ingrese numeros");
}

void ejercicio2()
{
    string[] frutas = { "banana", "pera", "manzana" };

    Console.WriteLine("Ingrese el nombre de una fruta");
    string fruta = Console.ReadLine().ToLower();

    for (int i = 0; i < frutas.Length; i++)
    {
        if (fruta == frutas[i])
        {
            Console.WriteLine($"Su posicion es:{i}");
            break;
        }
    }
}
ejercicio2();

try
{
    void ejercicio3()
    {
        int[] notas = new int[10];

        int suma_total = 0;

        int promedio = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Ingrese la nota n°{i + 1}");

            notas[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Los numeros ingresados fueron: ");
        foreach (int nota in notas)
        {
            suma_total = suma_total + nota;
            promedio = promedio + nota;
        }
        Console.WriteLine($"La suma total de las notas es:{suma_total}");
        Console.WriteLine($"El promedio es:{promedio / 10}");
    }
    ejercicio3();
}
catch (System.FormatException)
{
    Console.WriteLine("Ingrese numeros");
}

void ejercicio4()
{
    int[] temperaturas = { 38, 42, 31, 40, 35, 20, 23, 50, 13, 42, 56, 25 };

    int temp_alta = 0;
    int temp_baja = temperaturas[0];

    foreach(int temp in temperaturas)
    {
        if(temp > temp_alta)
        {
            temp_alta = temp;
        }
    }
    Console.WriteLine($"La temperatura mas alta registrada es: {temp_alta}");

    foreach(int tempu in temperaturas)
    {
        if(tempu < temp_baja)
        {
            temp_baja = tempu;
        }
    }
    Console.WriteLine($"La temperatura mas baja registrada es: {temp_baja}");
}
ejercicio4();

void ejercicio5()
{
    int[] desordenados = { 38, 42, 31, 40, 35 };

    Console.WriteLine("Ordenados de forma ascendente queda tal que asi: ");
    for (int pasada = 0; pasada < desordenados.Length; pasada++)
    {
        for (int u = 0; u < desordenados.Length - 1; u++)
        {
            if (desordenados[u] > desordenados[u + 1])
            {
                int temporal = desordenados[u];
                desordenados[u] = desordenados[u + 1];
                desordenados[u + 1] = temporal;
            }
        }
    }

    foreach (int numero in desordenados)
    {
        Console.Write(numero + " ");
    }
}
ejercicio5();

void ejercicio6()
{
    int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

    int pares = 0;
    int impares = 0;

    Console.WriteLine("Lista");
    foreach (int nu in numeros)
    {
        Console.WriteLine(nu);
    }

    foreach (int num in numeros)
    {
        if (num % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }
    }
    Console.WriteLine($"Cant numeros pares: {pares}");

    Console.WriteLine($"Cant numeros impares: {impares}");
}
ejercicio6();