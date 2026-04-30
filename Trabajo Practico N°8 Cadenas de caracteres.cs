void ejercicio1()
{
    Console.WriteLine("Ingrese una frase");
    string frase = Console.ReadLine();

    string vocales = "aeiouAEOIU";
    int contador = 0;

    foreach (char M in frase)
    {
        foreach (char L in vocales) //creamos dos foreach para recorrer primero la frase y despues vocales , si una letra de la frase es igual a una vocal el cont suma 1
        {
            if (M == L)
                contador++;
        }
    }
    Console.WriteLine("Hay " + contador + " vocales");
}
ejercicio1();

void ejercicio2()
{
    Console.WriteLine("Ingrese una palabra para invertirla");
    string palabra = Console.ReadLine();

    string textoinvertido = "";

    for (int num = palabra.Length - 1; num >= 0; num--) //este for va cambiando la ultima letra por su paralela y las va guardando(hola-aloh)
    {
        textoinvertido += palabra[num];
    }
    Console.WriteLine("Palabra invertida: " + textoinvertido);
}
ejercicio2();

void ejercicio3()
{
    Console.WriteLine("Ingrese un numero entero");
    string numero = Console.ReadLine();

    int contador = 0;

    for (int num = 0; num < numero.Length; num++)//vamos sumando por indice, ese - '0' para que no tire numeros enormes
    {
        contador += (numero[num] - '0');
    }
    Console.WriteLine("Suma de los digitos: " + contador);
}
ejercicio3();

void ejercicio4()
{
    string parrafo = "El colegio es mucho más que un edificio con aulas y pizarrones; es el escenario donde se empieza a construir nuestra identidad y nuestra visión del mundo. Desde los primeros años, cuando el juego es la herramienta principal de aprendizaje, hasta la adolescencia, donde las materias se vuelven más complejas y los debates más intensos, la escuela actúa como un microcosmos de la sociedad.";
    Console.WriteLine(parrafo);

    Console.WriteLine("Ingrese una palabra prohibida");
    string prohibida = Console.ReadLine();

    Console.WriteLine("Ingrese una palabra para reemplazar la prohibida");
    string reemplazo = Console.ReadLine();

    string textoactual = parrafo.Replace(prohibida, reemplazo);//solo reemplazo la palabra prohibida por la de reemplazo
    Console.WriteLine("Texto actualizado" + textoactual);
}
ejercicio4();

void ejercicio5()
{
    Console.WriteLine("Ingrese su nombre y apellido");
    string nombreap = Console.ReadLine();

    string iniciales = nombreap[0].ToString();

    for (int num = 0; num < nombreap.Length; num++)//agarro la primer inicial y despues cuando encuentre un espacio guarda la siguiente(Juan Perez)
    {
        if (nombreap[num] == ' ')
        {
            iniciales += nombreap[num + 1];
            break;
        }
    }
    Console.WriteLine("Iniciales: " + iniciales.ToUpper());
}
ejercicio5();

void ejercicio6()
{
    Console.WriteLine("Ingrese una palabra y veremos si es un palindromo");
    string palindromo = Console.ReadLine().ToLower();
    string verificado = "";

    for (int num = palindromo.Length - 1; num >= 0; num--)//como en el segundo ejercicio invierto la palabra y si queda igual es un palindromo
    {
        verificado += palindromo[num];
    }
    if (verificado == palindromo)
    {
        Console.WriteLine("Si es un palindromo");
    }
    else
    {
        Console.WriteLine("No es un palindromo");
    }
}
ejercicio6();