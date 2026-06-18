using System.ComponentModel.Design;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

string[] nombres = ["Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew"];

string[] tipos = ["Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic"];

string[,] equipoRed = new string[6,3];

string[,] equipoGreen = new string[6, 3];

string[,] equipoBlue = new string[6, 3];

string[,] equipoYellow = new string[6, 3];

int mayornivelred = 0;

int mayornivelGreen = 0;

int mayornivelBlue = 0;

int mayornivelYellow = 0;

Random aleatorio = new Random();

Random rendimiento = new Random();

void loop()
{
    crearequipoRed(equipoRed);

    crearequipoGreen(equipoGreen);

    crearequipoBlue(equipoBlue);

    crearequipoYellow(equipoYellow);

    Console.WriteLine("Equipo Red: ");
    mostrarequipoRed(equipoRed);
    Console.WriteLine("------------------------");

    Console.WriteLine($"Puntuacion Red:{mayornivelred}");

    Console.WriteLine("------------------------");

    Console.WriteLine("Equipo Green: ");
    mostrarequipoGreen(equipoGreen);

    Console.WriteLine("------------------------");

    Console.WriteLine($"Puntuacion Green:{mayornivelGreen}");

    Console.WriteLine("------------------------");

    Console.WriteLine("Equipo Blue: ");
    mostrarequipoBlue(equipoBlue);

    Console.WriteLine("------------------------");

    Console.WriteLine($"Puntuacion Blue:{mayornivelBlue}");

    Console.WriteLine("------------------------");

    Console.WriteLine("Equipo Yellow: ");
    mostrarequipoYellow(equipoYellow);

    Console.WriteLine("------------------------");

    Console.WriteLine($"Puntuacion Yellow:{mayornivelYellow}");

    Console.WriteLine("------------------------");

    ganador(mayornivelred, mayornivelGreen, mayornivelBlue, mayornivelYellow);
}
loop();
void crearequipoRed(string[,] equipoRed)
{
    for(int fila = 0;fila < equipoRed.GetLength(0);fila ++)
    {
        int nivel = rendimiento.Next(50, 81);

        mayornivelred += nivel;

        equipoRed[fila, 0] = nombres[aleatorio.Next(0, nombres.Length)];

        equipoRed[fila, 1] = tipos[aleatorio.Next(0, tipos.Length)];

        equipoRed[fila, 2] = nivel.ToString();
    }
}

void mostrarequipoRed(string[,] equipoRed)
{
    for(int fil = 0;fil < equipoRed.GetLength(0);fil++)
    {
        Console.WriteLine($"{equipoRed[fil, 0]} - {equipoRed[fil, 1]} - {equipoRed[fil, 2]}");
    }
}

void crearequipoGreen(string[,] equipoGreen)
{
    for (int fila = 0; fila < equipoRed.GetLength(0); fila++)
    {
        int nivel = rendimiento.Next(50, 81);

        mayornivelGreen += nivel;

        equipoGreen[fila, 0] = nombres[aleatorio.Next(0, nombres.Length)];

        equipoGreen[fila, 1] = tipos[aleatorio.Next(0, tipos.Length)];

        equipoGreen[fila, 2] = nivel.ToString();
    }
}

void mostrarequipoGreen(string[,] equipoGreen)
{
    for (int fil = 0; fil < equipoGreen.GetLength(0); fil++)
    {
        Console.WriteLine($"{equipoGreen[fil, 0]} - {equipoGreen[fil, 1]} - {equipoGreen[fil, 2]}");
    }
}

void crearequipoBlue(string[,] equipoBlue)
{
    for (int fila = 0; fila < equipoRed.GetLength(0); fila++)
    {
        int nivel = rendimiento.Next(50, 81);

        mayornivelBlue += nivel;

        equipoBlue[fila, 0] = nombres[aleatorio.Next(0, nombres.Length)];

        equipoBlue[fila, 1] = tipos[aleatorio.Next(0, tipos.Length)];

        equipoBlue[fila, 2] = nivel.ToString();
    }
}

void mostrarequipoBlue(string[,] equipoBlue)
{
    for (int fil = 0; fil < equipoBlue.GetLength(0); fil++)
    {
        Console.WriteLine($"{equipoBlue[fil, 0]}-{equipoBlue[fil, 1]}-{equipoBlue[fil, 2]}");
    }
}

void crearequipoYellow(string[,] equipoYellow)
{
    for (int fila = 0; fila < equipoRed.GetLength(0); fila++)
    {
        int nivel = rendimiento.Next(50, 81);

        mayornivelYellow += nivel;

        equipoYellow[fila, 0] = nombres[aleatorio.Next(0, nombres.Length)];

        equipoYellow[fila, 1] = tipos[aleatorio.Next(0, tipos.Length)];

        equipoYellow[fila, 2] = nivel.ToString();
    }
}

void mostrarequipoYellow(string[,] equipoYellow)
{
    for (int fil = 0; fil < equipoYellow.GetLength(0); fil++)
    {
        Console.WriteLine($"{equipoYellow[fil, 0]}-{equipoYellow[fil, 1]}-{equipoYellow[fil, 2]}");
    }
}

void ganador(int mayornivelred, int mayornivelGreen,int mayornivelBlue,int mayornivelYellow)
{
    if(mayornivelGreen < mayornivelred)
    {
        Console.WriteLine($"La pelea entre equipo Green y equipo Red la gano equipo Red con {mayornivelred} de puntuacion");
        Console.WriteLine("------------------------");
        if (mayornivelBlue < mayornivelYellow)
        {
            Console.WriteLine($"La pelea entre equipo Blue y equipo Yellow la gano equipo Yellow con {mayornivelYellow} de puntuacion");
            Console.WriteLine("------------------------");
            if (mayornivelYellow < mayornivelred)
            {
                Console.WriteLine($"El ganador del torneo es equipo Red con {mayornivelred} de puntuacion");
            }
            else if (mayornivelYellow < mayornivelred)
            {
                Console.WriteLine($"El ganador del torneo es equipo Yellow con {mayornivelYellow} de puntuacion");
            }
        }
        else if(mayornivelBlue > mayornivelYellow)
        {
            Console.WriteLine($"La pelea entre equipo Blue y equipo Yellow la gano equipo Blue con {mayornivelBlue} de puntuacion");
            Console.WriteLine("------------------------");
            if (mayornivelBlue < mayornivelred)
            {
                Console.WriteLine($"El ganador del torneo es equipo Red con {mayornivelred} de puntuacion");
            }
            else if (mayornivelBlue > mayornivelred)
            {
                Console.WriteLine($"El ganador del torneo es equipo Blue con {mayornivelBlue} de puntuacion");
            }
        }
    }
    else if(mayornivelGreen > mayornivelred)
    {
        Console.WriteLine($"La pelea entre equipo Green y equipo Red la gano equipo Green con {mayornivelGreen} de puntuacion");
        Console.WriteLine("------------------------");
        if (mayornivelBlue < mayornivelYellow)
        {
            Console.WriteLine($"La pelea entre equipo Blue y equipo Yellow la gano equipo Yellow con {mayornivelYellow} de puntuacion");
            Console.WriteLine("------------------------");
            if (mayornivelYellow > mayornivelGreen)
            {
                Console.WriteLine($"El ganador del torneo es equipo Yellow con {mayornivelYellow} de puntuacion");
            }
            else if(mayornivelYellow < mayornivelGreen)
            {
                Console.WriteLine($"El ganador del torneo es equipo Green con {mayornivelGreen} de puntuacion");
            }
        }
        else if(mayornivelBlue > mayornivelYellow)
        {
            Console.WriteLine($"La pelea entre equipo Blue y equipo Yellow la gano equipo Blue con {mayornivelBlue} de puntuacion");
            Console.WriteLine("------------------------");
            if (mayornivelBlue < mayornivelGreen)
            {
                Console.WriteLine($"El ganador del torneo es equipo Green con {mayornivelGreen} de puntuacion");
            }
            else if(mayornivelBlue > mayornivelGreen)
            {
                Console.WriteLine($"El ganador del torneo es equipo Blue con {mayornivelBlue} de puntuacion");
            }
        }
    }
    else if(mayornivelred == mayornivelGreen)
    {
        Console.WriteLine($"La pelea entre equipo Green y equipo Red quedo empatada con {mayornivelGreen} de puntuacion");
        Console.WriteLine("------------------------");
        if (mayornivelBlue == mayornivelYellow)
        {
            Console.WriteLine($"La pelea entre equipo Blue y equipo Yellow quedo empatada con {mayornivelBlue} de puntuacion");
            Console.WriteLine("------------------------");
            if (mayornivelYellow < mayornivelred)
            {
                Console.WriteLine($"Los equipos Red y Green han ganado el torneo , los dos con la misma puntuacion{mayornivelred}");
            }
            else if(mayornivelYellow > mayornivelred)
            {
                Console.WriteLine($"Los equipos Blue y Yellow han ganado el torneo , los dos con la misma puntuacion{mayornivelYellow}");
            }
        }
    }
}

int numero = 50;
int recursiva(int numero)
{
    if (numero == 0)
    {
        return 0;
    }
    else
    {
        return numero - recursiva(5);
    }
}
Console.WriteLine(Convert.ToInt32(recursiva(numero)));