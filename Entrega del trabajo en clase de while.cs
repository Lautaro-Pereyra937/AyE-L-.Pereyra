void ejercicio1()
{
    bool incorrecto = false;
    Console.WriteLine("Ingrese 0 o 1");

    while (incorrecto == false)
    {
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero != 1 || numero != 0)
        {
            Console.WriteLine("Ingrese 0 o 1");
        }
        else
        {
            Console.WriteLine("bien");
            incorrecto = true;
        }
    }
}

void ejercicio2()
{
    bool incorrecto2 = false;
    Console.WriteLine("Ingrese un numero de dos cifras");

    while (incorrecto2 == false)
    {
        int numero2 = Convert.ToInt32(Console.ReadLine());
        if ((numero2 >= 10 && numero2 <= 99) || (numero2 <= -10 && numero2 >= -99))
        {
            Console.WriteLine("Bien");
            incorrecto2 = true;
        }
        else
        {
            Console.WriteLine("Ingrese un numero de dos cifras");
        }
    }
}
