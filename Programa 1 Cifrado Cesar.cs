string abedecedario = "abcdefghijklmnñopqrstuvwxyz";
void funcion1()
{
    bool esValido = false;
    string guardado = "";
    while (!esValido)
    {
        Console.WriteLine("Ingrese el mensaje");
        string texto = Console.ReadLine().ToLower();

        bool contieneerror = false;

        for (int i = 0; i < texto.Length; i++)
        {
            char caracterUsuario = texto[i];
            bool encontrado = false;

            for (int num = 0; num < abedecedario.Length; num++)
            {
                if (caracterUsuario == abedecedario[i])
                {
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                contieneerror = true;
                break;
            }
        }
        if (contieneerror)
        {
            Console.WriteLine("Ingreselo sin caracteres");
        }
        else
        {
            esValido = true;
        }
        Console.WriteLine(texto);
    }
}
funcion1();
void cifrado(string texto,string abecedario)
{
    
    Console.WriteLine("Ingrese la clave(numero entero)");
    int clave = Convert.ToInt32(Console.ReadLine());

    string textoactualizado = "";

    for (int x = 0; x < texto.Length; x++)
    {
        for(int num = 0;num < abecedario.Length; x++)
        {
            if (texto[x] == abecedario[num])
            {
                textoactualizado = textoactualizado + abecedario[num+clave];
            }
        }
    }
    Console.WriteLine(textoactualizado);
}

void funcion2()
{
    funcion1();
    bool ejecutando = true;

    while (ejecutando == true)
    {
        Console.WriteLine("Ingrese 1 para cifrar 1 , 2 para descifrar 2 , 3 para salir");
        int numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine(cifrado);
                break;
            case 2:
                Console.WriteLine("hola");
                
                
                break;
            case 3:
                Console.WriteLine("Terminando");
                ejecutando = false;
                break;
            default:
                Console.WriteLine("Esa opcion no esta disponible");
                break;
        }
    }
    funcion2();
}