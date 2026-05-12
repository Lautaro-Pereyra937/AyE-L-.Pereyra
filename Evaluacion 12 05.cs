int ejercicio1(int horas)
{
   int salario = 0;

   if(horas < 40)
   {
     salario = horas * 16;
     Console.WriteLine("Su salario semanal es: ");
     return salario;
   }

   else if (horas > 40)
   {
     salario = 40 * 16;
     Console.WriteLine("Ingrese las otras que trabaja mas de 40(si es 41 , 1 hora)");
     int horasextras = Convert.ToInt32(Console.ReadLine());

     salario += horasextras * 20;
     Console.WriteLine("Su salario semanal es: ");
     return salario;
   }
}
Console.WriteLine(ejercicio1(Convert.ToInt32(Console.ReadLine())));

try
{
    void ejercicio2()
    {
        int contador = 0;
        bool cero = false;
        while(cero == false)
        {
            Console.WriteLine("Ingrese un numero, termina al ser 0");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero != 0)
            {
                contador = contador + numero;
            }
            else if (numero == 0)
            {
                Console.WriteLine("La suma de todos los numeros es: " + contador);
                cero = true;
                return;
            }
        }
    }
    ejercicio2();
}
catch(System.FormatException)
{
    Console.WriteLine("No ingrese letras");
}
void ejercicio3()
{
    int vocales = 0;
    string voc = "aeiou";

    Console.WriteLine("Ingrese una palabra y veremos sus vocales");
    string palabra = Console.ReadLine();

    foreach(char Y in palabra)
    {
        foreach(char I in voc)
        {
            if(Y == I)
            {
                vocales += 1;
                Console.WriteLine("Cant vocales: " +vocales);
            }
        }
    }
}
ejercicio3();

void ejercicio4()
{
    string palindromo = "";

        Console.WriteLine("Ingrese una palabra para ver si es un palindromo");
        string palabra = Console.ReadLine().ToLower();

        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            palindromo += palabra[i];
        }
        if (palindromo == palabra)
        {
            Console.WriteLine("Si es un palindromo");
            Console.WriteLine("Palabra ingresada: " +palabra);
            return;
        }
        else
        {
            Console.WriteLine("no lo es");
            ejercicio4();
        }
}
ejercicio4();