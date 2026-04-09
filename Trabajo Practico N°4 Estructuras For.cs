using System.Diagnostics;

void Ejercicio1()
{
    for (int num = 0; num < 11; num++) 
    {
        Console.WriteLine(num);
    }
}
Ejercicio1();

Console.WriteLine("------------");
void Ejercicio2()
{
    for (int num = 0; num < 5; num++)
    {
        Console.WriteLine("Hola mundo!");
    }
}
Ejercicio2();

Console.WriteLine("------------");
void Ejercicio3()
{
    for (int num = 2; num < 21; num+= 2)
    {
        Console.WriteLine(num);
    } 
}
Ejercicio3();

Console.WriteLine("------------");
void Ejercicio4()
{
    for (int num = 0; num < 71; num += 7)
    {
        Console.WriteLine(num);
    }
}
Ejercicio4();

Console.WriteLine("------------");
void Ejercicio5()
{
    int sumatorio = 0;
    for (int num = 0; num < 6; num += 1)
    {
        Console.WriteLine(sumatorio += num);
    }
}
Ejercicio5();
