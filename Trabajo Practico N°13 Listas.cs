void ejercicio1()
{
    string[] nombre = { "Ana", "Luis", "Fede", "Nacho", "jorge", "Raul", "Tomas", "Sofia", "Ignacio", "luna" };

    string palabramas = "";

    foreach(string U in nombre)
    {
        if(U.Length > palabramas.Length)
        {
            palabramas = U;
        }
    }
    Console.WriteLine("La palabra con mas letras de la lista es: " + palabramas);
}
ejercicio1();

Console.WriteLine("");
void ejercicio2()
{
    int vocales1 = 0;

    string[] nombre = { "Ana", "Luis", "Fede", "Nacho", "jorge", "Raul", "Tomas", "Sofia", "Ignacio", "luna" };

    string vocales = "aeiouAEIOU";

    foreach(string U in nombre)
    {
        foreach(char Y in U)
        {
            foreach(char E in vocales)
            {
                if(E == Y)
                {
                    vocales1++;
                }
            }
        }
    }
    Console.WriteLine($"La cantidad de vocales es: {vocales1}");
}
ejercicio2();

Console.WriteLine("");

try
{
    void ejercicio3()
    {
        int factor = 3;

        int[] numeros = new int[3];

        int[] resultados = new int[3];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Ingrese el numero {i + 1}");

            numeros[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Los numeros ingresados multiplicados por 3 son: ");

        for (int x = 0; x < numeros.Length; x++)
        {
            resultados[x] = numeros[x] * factor;
            Console.WriteLine(resultados[x]);
        }
    }
    ejercicio3();
}
catch(System.FormatException)
{
    Console.WriteLine("No ingrese letras");
}