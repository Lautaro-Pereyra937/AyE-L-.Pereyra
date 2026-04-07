void ejercicio1()
{
    string contraseña = ("ratas");
    Console.WriteLine("Ingrese la contraseña");
    string usuario = Console.ReadLine();
    while(contraseña != usuario)
    {
        Console.WriteLine("intentalo de nuevo");
        Console.ReadLine();
    }
    Console.WriteLine("entrando");
}
ejercicio1();

void ejercicio2()
{
    bool sapo = true;
    while (sapo != true)
    {
        Console.WriteLine("no");
    }
    Console.WriteLine("5");
    Console.WriteLine("4");
    Console.WriteLine("3");
    Console.WriteLine("2");
    Console.WriteLine("1");
    Console.WriteLine("¡Listo para despegar!");
    Console.WriteLine("¡Despegue!");
}
ejercicio2();

void ejercicio3()
{
    int numerose = 7;
    
    Console.WriteLine("Adivine el numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    while(numero != numerose)
    { 
        Console.WriteLine("intentalo de nuevo");
        numero = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("¡Felicidades! Adivinaste el número.");
}
ejercicio3();

void ejercicio4()
{
    int numero = 1;
    int acum = 0;
    while (numero != 0)
    {
        Console.WriteLine("Ingrese numeros");
        numero = Convert.ToInt32(Console.ReadLine());
        
        acum = acum + numero;
    }
    Console.WriteLine("La suma de los numeros es: " + acum);
}
ejercicio4();