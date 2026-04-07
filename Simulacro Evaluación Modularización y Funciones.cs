void prueba()
{
    Console.WriteLine("ingrese su nombre");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese su promedio");
    float promedio = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese la distancia de su casa a la universidad");
    int distancia = Convert.ToInt32(Console.ReadLine());

    static bool DeterminarBeca(float promedio, int distancia)
    {
        bool resultado = DeterminarBeca(promedio, distancia);
        if (resultado == true)
        {
            Console.Write("Felicidades ");
            Console.Write(nombre);
            Console.Write(", ");
            Console.WriteLine("tu beca ha sido aprobada");
            return true;
        }
        else
        {
            Console.WriteLine("Lo sentimos, no cumples con los requisitos mínimos");
            return false;
        }
    }
}
prueba();
