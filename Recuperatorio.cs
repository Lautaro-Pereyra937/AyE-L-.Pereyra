try
{
    int ejercicio1()
    {
        Console.WriteLine("Tiene horas extras?(1 si 2 no)");
        int respuesta = Convert.ToInt32(Console.ReadLine());

        int salario_semanal = 0;
        if (respuesta == 2)
        {
            Console.WriteLine("Ingrese las horas que trabaja semanalmente");
            int horas = Convert.ToInt32(Console.ReadLine());

            salario_semanal = horas * 16;
            Console.WriteLine($"Su salario semanal es de: {salario_semanal}");
            return salario_semanal;
        }
        else
        {
            Console.WriteLine("Ingrese SOLO las horas extras");
            int extras = Convert.ToInt32(Console.ReadLine());

            salario_semanal = 40 * 16;
            salario_semanal += extras * 20;

            Console.WriteLine($"Su salario semanal es de: {salario_semanal}");
            return salario_semanal;
        }
    }
    ejercicio1();
}
catch (System.FormatException)
{
    Console.WriteLine("Ingrese numeros");
}

try
{
    int ejercicio2()
    {
        int cont = 0;

        Console.WriteLine("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool seguir = true;

        while (seguir)
        {
            if (num != 0)
            {
                cont += num;
                Console.WriteLine("Ingrese otro numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"La suma de todos los numero es: {cont}");
                seguir = false;
                break;
            }
        }
        return cont;
    }
    ejercicio2();
}
catch(System.FormatException)
{
    Console.WriteLine("Ingrese numeros");
}

int ejercicio3()
{
    int cant_vocales = 0;

    string vocales = "aeiouAEIOU";

    Console.WriteLine("Ingrese una palabra: ");
    string palabra = Console.ReadLine();

    foreach(char letra in palabra)
    {
        foreach(char vocal in vocales)
        {
            if(letra == vocal)
            {
                cant_vocales += 1;
            }
        }
    }
    Console.WriteLine($"La cantidad de vocales es: {cant_vocales}");
    return cant_vocales;
}
ejercicio3();

string ejercicio4()
{
    string palindromo = "";

    Console.WriteLine("Ingrese una palabra: ");
    string palabra = Console.ReadLine();

    for(int i = palabra.Length-1;i > -1 ;i--)
    {
        palindromo += palabra[i];
    }
    if(palabra == palindromo)
    {
        Console.WriteLine($"Si es un palindromo: {palindromo}");
        return palindromo;
    }
    else
    {
        Console.WriteLine($"No es un palindromo: {palindromo}");
        return palindromo;
    }
}
ejercicio4(); //lol