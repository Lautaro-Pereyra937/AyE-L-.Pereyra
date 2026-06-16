string[,] equipo1 = new string[23, 3];

string[,] equipo2 = new string[23, 3];

string[] nombres = ["jorge", "messi", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge",];

string[] posicion = ["delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero"];

Random rendimiento = new Random();

Random aleatorio = new Random();

int puntuacionequipo1 = 0;

int puntuacionequipo2 = 0;
void ejercicio1()
{

    for (int fila = 0; fila < equipo1.GetLength(0); fila++)
    {
        int rendi = rendimiento.Next(50, 101);

        equipo1[fila, 0] = nombres[aleatorio.Next(1, 24)];

        equipo1[fila, 1] = posicion[aleatorio.Next(1, 4)];

        equipo1[fila, 2] = aleatorio.Next(50, 101).ToString();

        puntuacionequipo1 += rendi;

        Console.WriteLine();
    }

    for(int fil  = 0;fil< equipo1.GetLength(0); fil++)
    {
        Console.WriteLine(equipo1[fil, 0], equipo1[fil, 0], equipo1[fil, 2], " ");
    }

    puntuacionequipo1 = puntuacionequipo1 / 23;
    Console.WriteLine($"La puntuacion total del equipo es: {puntuacionequipo1}");
}
ejercicio1();

string[,] crearequipo1(string[,] equipo)
{
    for (int fila = 0; fila < equipo1.GetLength(0); fila++)
    {
        int rendi = rendimiento.Next(50, 101);

        equipo1[fila, 0] = nombres[aleatorio.Next(1, 24)];

        equipo1[fila, 1] = posicion[aleatorio.Next(1, 4)];

        equipo1[fila, 2] = aleatorio.Next(50, 101).ToString();

        puntuacionequipo1 += rendi;
    }
    return equipo1;
}

void mostrarequipo1()
{
    for()
}
string[,] crearequipo2(string[,] equipo)
{
    for (int fila = 0; fila < equipo2.GetLength(0); fila++)
    {
        int rendi = rendimiento.Next(50, 101);

        equipo2[fila, 0] = nombres[aleatorio.Next(1, 24)];

        equipo2[fila, 1] = posicion[aleatorio.Next(1, 4)];

        equipo2[fila, 2] = aleatorio.Next(50, 101).ToString();

        puntuacionequipo2 += rendi;
    }
    return equipo2;
}

void mostrarequipo2()
{

}
