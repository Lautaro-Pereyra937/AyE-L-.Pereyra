void ejercicio1()
{
    string[,] equipo1 = new string[23, 1];

    string[,] equipo2 = new string[23, 3];

    string[] nombres = ["jorge", "messi", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge", "jorge",];

    string[] posicion = ["delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero", "delantero", "mediocampista", "defensa", "arquero"];

    Random rendimiento = new Random();

    int puntuacionequipo1 = 0;

    for(int fila = 0; fila < equipo1.GetLength(0); fila++)
    {
        int rendi = rendimiento.Next(50, 101);
        for (int columna = 0; columna < equipo1.GetLength(1); columna++)
        {                                             
            Console.Write($" Nombre: {nombres[fila]} Posicion: {posicion[fila]} Rendimiento: {rendi}", " ");
            puntuacionequipo1 += rendi;
        } 
        Console.WriteLine();
    }
    puntuacionequipo1 = puntuacionequipo1 / 23;
    Console.WriteLine($"La puntuacion total del equipo es: {puntuacionequipo1}");
}
ejercicio1();