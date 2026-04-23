void Ejercicio1()
{
    Console.WriteLine("Ingrese un numero entero");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero < 2)
    {
        Console.WriteLine("El numero no es primo");
    }

    for (int num = 2; num <= numero; num++)
    {
        if (numero % num == 0)
        {
            Console.WriteLine("El numero no es primo");
            return;
        }
    }
    Console.WriteLine("El numero no es primo");
}
Ejercicio1();

void Ejercicio2()
{
    Console.WriteLine("Ingrese un numero entero no negativo para su factorial");
    int numero = Convert.ToInt32(Console.ReadLine());

    int acumulador = 1;

    if (numero < 0)
    {
        Console.WriteLine("Ingrese numeros positivos");
    }

    for (int num = 1; num <= numero; num++)
    {
        acumulador *= num;
    }
    Console.WriteLine("El factorial de su numero es: " + acumulador);
}
Ejercicio2();

void Ejercicio3()
{
    Console.WriteLine("Ingrese un numero entero no negativo , para su secuencia de fibonacci");
    int numero = Convert.ToInt32(Console.ReadLine());

    int acumulador = 0;
    int acumulador3 = 1;

    if (numero < 0)
    {
        Console.WriteLine("Ingrese numeros positivos");
    }
    else
    {

        for (int num = 1; num <= numero; num++)
        {
            int acumulador4 = acumulador += acumulador3;
            acumulador = acumulador3;
            acumulador3 = acumulador4;
            Console.WriteLine("La secuencia de fibonacci de su numero es: " + acumulador4);
        }
    }
}
Ejercicio3();


bool ejecutando = true;

while (ejecutando == true)
{
    Console.WriteLine("1Saludar 1 , 2Despedirse , 3Terminar programa");
    int numero = Convert.ToInt32(Console.ReadLine());

    switch (numero)
    {
        case 1:
            Console.WriteLine("hola");
            break;

        case 2:
            Console.WriteLine("chau");
            break;

        case 3:
            Console.WriteLine("Saliendo");
            ejecutando = false;
            break;

        default:
            Console.WriteLine("Solo hay 3 opciones disponibles");
            break;
    }
}
