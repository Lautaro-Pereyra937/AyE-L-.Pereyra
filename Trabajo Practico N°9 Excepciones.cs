try
{
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
    Console.WriteLine(Ejercicio1(Convert.ToInt32(Console.ReadLine())));
}
catch(FormatException)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
}
catch (OverFlowExcepction)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
}
try
{
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
    Console.WriteLine(Ejercicio2(Convert.ToInt32(Console.ReadLine())));
}
catch (FormatException)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
}
catch (OverFlowExcepction)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
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
    Console.WriteLine(Ejercicio3(Console.ReadLine()));

try
{
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
    Console.WriteLine(Ejercicio4(Convert.ToInt32(Console.ReadLine())));
}
catch (FormatException)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
}
catch (OverFlowExcepction)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
}

try
{
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
    Console.WriteLine(Ejercicio5(Convert.ToInt32(Console.ReadLine())));
}
catch(FormatException)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
}
catch(OverFlowExcepction)
{
    Console.WriteLine("no puede ingresar palabras, solo numeros");
}
