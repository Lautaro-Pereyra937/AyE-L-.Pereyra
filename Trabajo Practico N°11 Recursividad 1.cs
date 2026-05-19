bool ejercicio1(int n)
{

    if (n == 0)
    {

        return false;
    }
    else
    {
        ejercicio1(n - 1);
        Console.WriteLine(n);
        return true;
    }

}
ejercicio1(10);

bool ejercicio2(int n)
{

    if (n == 0)
    {

        return false;
    }
    else
    {

        Console.WriteLine("¡Hola mundo!");
        ejercicio2(n - 1);
        return true;
    }
}
ejercicio2(5);
bool ejercicio3(int n)
{
    if (n > 20)
    {
        return false;
    }
    else
    {

        Console.WriteLine(n);
        ejercicio3(n + 2);
        return true;
    }
}
ejercicio3(2);
bool ejercicio4(int n)
{
    if (n > 70)
    {
        return false;
    }
    else
    {
        Console.WriteLine(n);
        ejercicio4(n + 7);
        return true;
    }
}
ejercicio4(7);
int aux = 0;
int ejercicio5(int n)
{
    if (n == 0)
    {
        return aux;
    }
    else
    {
        aux = aux + n;
        ejercicio5(n - 1);
        return aux;
    }
}

aux = ejercicio6(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(aux);
string ejercicio6(string contra)
{
    string secreta = "caine";

    if(secreta == contra)
    {
        Console.WriteLine("La contraseña es correcta");
        return contra;
    }
    else
    {
        Console.WriteLine("Intentelo de nuevo");
        ejercicio6(Console.ReadLine());
        return contra;

    }
}
ejercicio6(Console.ReadLine());

int ejercicio7(int despegar)
{
    if (despegar == 0)
    {
        Console.WriteLine("Listos para despegar");
        Console.WriteLine("Despegue");
        return despegar;
    }
    else
    {
        despegar = despegar - 1;
        Console.WriteLine(despegar);
        ejercicio7(despegar);
        return despegar;
    }
}
ejercicio7(6);
int ejercicio8(int maquina)
{
    Console.WriteLine("Adivine el numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    if (numero == maquina)
    {
        Console.WriteLine("¡Felicidades! Adivinaste el número.");
        return maquina;
    }
    else
    {
        Console.WriteLine("intentelo de vuelta");
        ejercicio8(maquina);
        return maquina;
    }
}
ejercicio8(7);
int acum = 0;
int ejercicio9()
{
    Console.WriteLine("Ingrese un numero");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num == 0)
    {
        Console.WriteLine("La suma de los numeros es: " + acum);
        return acum;
    }
    else
    {
        acum = acum + num;
        Console.WriteLine("Ingrese otro numero");
        ejercicio9();
    }
    return acum;

}
ejercicio9();