void Ejercicio2()
{
    int acumulador = 1;

    int intentos = 0;

    bool resetear = true;

    while(intentos < 3)
    {
        Console.WriteLine("Ingrese un numero entero no negativo para su factorial(max intentos es 3)");
        int numero = Convert.ToInt32(Console.ReadLine());

        intentos++;

        if(intentos >= 3)
        {
            Console.WriteLine("no tiene mas intentos");
            break;
        }
        if (numero < 0)
        {
            Console.WriteLine("Ingrese numeros positivos,numeros de intentos " +intentos);
        }
        else if(numero > 0)
        {
            for (int num = 1; num <= numero; num++)
            {
                acumulador *= num;
            }
            Console.WriteLine("El factorial de su numero es: " + acumulador);
            resetear = false;
            if(resetear == false)
            {
                Ejercicio2();
            }
        }
    }
}