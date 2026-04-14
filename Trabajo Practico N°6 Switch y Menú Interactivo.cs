string Ejercicio1(int n)
{
    string resultado;
    if (n > 0)
    {
        resultado = ("El numero es positivo");
        return resultado;
    }
    else if (n == 0)
    {
        resultado = ("El numero es 0");
        return resultado;
    }
    else
    {
        resultado = ("El numero es negativo");
        return resultado;
    }

}

string Ejercicio2(int nu)
{
    string res;
    if (nu >= 18)
    {
        res = ("¡Bienvenido a la fiesta!");
        return res;
    }
    else
    {
        res = ("Lo siento, eres muy joven");
        return res;
    }
}

string Ejercicio3(string contraseña)
{
    string res;
    if (contraseña == "python123")
    {
        res = ("¡Contraseña correcta! Acceso concedido.");
        return res;
    }
    else
    {
        res = ("¡Contraseña incorrecta, Autodestrucción en 5 minutos!");
        return res;
    }
}

string Ejercicio4(int numero)
{
    string res;
    if (numero % 2 == 0)
    {
        res = ("El numero es par");
        return res;
    }
    else
    {
        res = ("El numero es impar");
        return res;
    }
}

string Ejercicio5(int edad)
{
    string res;
    Console.WriteLine("Compro pochoclos?");
    string pochoclos = Console.ReadLine();
    if (edad >= 65 && pochoclos == "si")
    {
        res = ("¡Felicidades! Tienes entrada gratuita al cine.");
        return res;
    }
    else
    {
        res = ("Compra la entrada o raja de acá");
        return res;
    }
}

Console.WriteLine("Ingrese 1 para ejercicio 1 , 2 para ejercicio 2 , 3 para ejercicio 3 , 4 para ejercicio 4 , 5 para ejercicio 5 y 6 para salir");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero)
 { 
    case 1:
        Console.WriteLine("Ingrese un numero");
      Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
    break;
    
    case 2:
      Console.WriteLine("Ingrese su edad");
      Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
    break;
    
    case 3:
        Console.WriteLine("Ingrese una contraseña");
      Console.WriteLine(Ejercicio3(Console.ReadLine()));
    break;

    case 4:
        Console.WriteLine("Ingrese un numero");
      Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
      break;

    case 5:
      Console.WriteLine("Ingrese su edad");
      Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));
      break;
    
    default:
      Console.WriteLine("Saliendo");
    break;
}