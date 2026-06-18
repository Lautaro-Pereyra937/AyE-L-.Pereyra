string[,] equipo1 = new string[23, 3];

string[,] equipo2 = new string[23, 3];

string[] nombres = [ "Romario", "Bergkamp", "Zidane", "Simeone", "Kaka",
    "Maldini", "Totti", "Ronaldo Fenomeno", "Gattuso", "Iniesta",
    "Xavi", "Schweinsteiger", "Pirlo", "Buffon", "Cannavaro",
    "Ronaldo Nazario", "Ronaldinho", "Kluivert", "Dugarry", "Veron",
    "Scolari", "Van Nistelrooy", "Maldini"];

string[] posicion = ["delantero", "mediocampista", "defensa", "arquero"];

Random rendimiento = new Random();

Random aleatorio = new Random();

int puntuacionequipo1 = 0;

int puntuacionequipo2 = 0;
void loop()
{
    crearequipo1(equipo1);
    Console.WriteLine("Real Mandril:");
    mostrarequipo1(equipo1);

    Console.WriteLine("------");

    crearequipo2(equipo2);
    Console.WriteLine("Frosta Juniors");
    mostrarequipo2(equipo2);

    puntuacionequipo1 = puntuacionequipo1 / 23;
    puntuacionequipo2 = puntuacionequipo2 / 23;

    ganador(puntuacionequipo2, puntuacionequipo1);
}
loop();

string[,] crearequipo1(string[,] equipo)
{
    for (int fila = 0; fila < equipo.GetLength(0); fila++)
    {
        int rendi = rendimiento.Next(50, 101);

        puntuacionequipo1 += rendi;

        equipo[fila, 0] = nombres[aleatorio.Next(0, nombres.Length)];

        equipo[fila, 1] = posicion[aleatorio.Next(0, posicion.Length)];

        equipo[fila, 2] = rendi.ToString();
    }
    return equipo;
}

void mostrarequipo1(string[,] equipo)
{
    for (int fil = 0; fil < equipo.GetLength(0); fil++)
    {
        Console.WriteLine($"{equipo[fil, 0]} - {equipo[fil, 1]} - {equipo[fil, 2]}"+ " ");
    }
}

string[,] crearequipo2(string[,] equipo)
{
    for (int fila = 0; fila < equipo.GetLength(0); fila++)
    {
        int rendi = rendimiento.Next(50, 101);

        equipo[fila, 0] = nombres[aleatorio.Next(0, nombres.Length)];

        equipo[fila, 1] = posicion[aleatorio.Next(0, posicion.Length)];

        equipo[fila, 2] = rendi.ToString();

        puntuacionequipo2 += rendi;
    }
    return equipo;
}

void mostrarequipo2(string[,] equipo)
{
    for (int fil = 0; fil < equipo.GetLength(0); fil++)
    {
        Console.WriteLine($"{equipo[fil, 0]} - {equipo[fil, 1]} - {equipo[fil, 2]}"+ " ");
    }
}

void ganador(int puntuacionequipo2, int puntuacionequipo1)
{
    if (puntuacionequipo2 > puntuacionequipo1)
    {
        Console.WriteLine($"El ganador es el equipo 2 con {puntuacionequipo2} de puntuacion promedio");
    }
    else if (puntuacionequipo2 < puntuacionequipo1)
    {
        Console.WriteLine($"El ganador es el equipo 1 con {puntuacionequipo1} de puntuacion promedio");
    }
    else if (puntuacionequipo2 == puntuacionequipo1)
    {
        Console.WriteLine($"Han empatado con una puntuacion de {puntuacionequipo1}");
    }
}

Console.WriteLine("Ingrese el numero a elevar");
int elevar = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese su potencia");
int potencia = Convert.ToInt32(Console.ReadLine());

int potenciadeunnumero(int elevar, int potencia)
{
    if (potencia == 0)
    {
        return 1;
    }
    else
    {
        return elevar * potenciadeunnumero(elevar, potencia - 1);
    }
}
Console.WriteLine(Convert.ToInt32(potenciadeunnumero(elevar,potencia)));
