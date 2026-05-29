void ejercicioprueba()
{
    Console.WriteLine("Ingrese su nombre");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingrese su edad");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("¿Tiene entrada fisica?");
    bool tieneEntrada = Convert.ToBoolean(Console.ReadLine());

    if (edad >= 18 && tieneEntrada == true)
    {
        Console.WriteLine($"Bienvenido {nombre}");
    }
    else { Console.WriteLine("adios"); }

    bool validarIngreso(int edad, bool tieneEntrada)
    {
        bool res;
        if (edad >= 18 && tieneEntrada == true)
        {
            res = true;
            return res;
        }
        else
        {
            res = false;
            return res;
        }
    }

    bool puedepasar = validarIngreso(edad, tieneEntrada);

    if(puedepasar == true)
    {
        Console.WriteLine("Acceso concedido. ¡Bienvenido!");
    }
    else
    { 
       Console.WriteLine("Acceso denegado.No cumple los requisitos");
    }
}
ejercicioprueba();
