namespace ConsoleApp1;
using System;
using System.IO;

internal class Program
{
    static void Main(string[] args)
    {
        string rutaEntrada = "archivo.txt";
        
        using (StreamWriter writer = new StreamWriter(rutaEntrada))
        {

            int ej1()
            {
                Console.WriteLine("Ingrese un número de dos cifras:");
                int numero = int.Parse(Console.ReadLine());

                int unidades = numero % 10;
                Console.WriteLine("Unidades: " + unidades);

                return unidades;
            }
            int resultado1 = ej1(); 
            writer.WriteLine("Resultado Ejercicio 1 (Unidades): " + resultado1); 

            int ej2()
            {
                Console.WriteLine("Indicar un número de tres cifras:");
                int numero1 = int.Parse(Console.ReadLine());

                int cifraCentral = (numero1 / 10) % 10;
                Console.WriteLine("Cifra central: " + cifraCentral);

                return cifraCentral;
            }
            int resultado2 = ej2();
            writer.WriteLine("Resultado Ejercicio 2 (Cifra Central): " + resultado2);

            int ej3()
            {
                Console.WriteLine("Ingrese el precio de la prenda:");
                int precio = int.Parse(Console.ReadLine());

                int descuento = (precio * 18) / 100;
                int precioFinal = precio - descuento;
                Console.WriteLine("Precio con descuento: " + precioFinal);

                return precioFinal;
            }
            int resultado3 = ej3();
            writer.WriteLine("Resultado Ejercicio 3 (Precio Final): " + resultado3);


            int ej4()
            {
                Console.WriteLine("Indicar un número de dos cifras para permutar:");
                int num = int.Parse(Console.ReadLine());

                int cifra1 = num % 10;
                int cifra2 = num / 10;
                int resultado = (cifra1 * 10) + cifra2;
                Console.WriteLine("Valor permutado: " + resultado);

                return resultado;
            }
            int resultado4 = ej4();
            writer.WriteLine("Resultado Ejercicio 4 (Permutado): " + resultado4);

            int ej5()
            {
                Console.WriteLine("Indicar una fecha de 6 dígitos:");
                int fecha = int.Parse(Console.ReadLine());

                int meses = fecha / 100;
                int mes = meses % 100;
                Console.WriteLine("Mes: " + mes);

                return mes;
            }
            int resultado5 = ej5();
            writer.WriteLine("Resultado Ejercicio 5 (Mes): " + resultado5);

            int ej6()
            {
                Console.WriteLine("Ingrese un lado de su cuadrado:");
                int lado = int.Parse(Console.ReadLine());

                int superficie = lado * lado;
                Console.WriteLine("Superficie: " + superficie);

                return superficie; 
            }
            int resultado6 = ej6();
            writer.WriteLine("Resultado Ejercicio 6 (Superficie): " + resultado6);

            int ej7()
            {
                Console.WriteLine("Ingrese cuánto gana por hora:");
                int hora = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cuántas horas trabaja:");
                int canthoras = int.Parse(Console.ReadLine());

                int sueldobruto = hora * canthoras;
                Console.WriteLine("Su sueldo bruto es: " + sueldobruto);

                return sueldobruto;
            }
            int resultado7 = ej7();
            writer.WriteLine("Resultado Ejercicio 7 (Sueldo Bruto): " + resultado7);

            double ej8()
            {
                Console.WriteLine("Ingrese la temperatura en Fahrenheit:");
                int fahrenheit = int.Parse(Console.ReadLine());

                double centigrados = (fahrenheit - 32) * 5.0 / 9.0;
                Console.WriteLine("En Celsius es: " + centigrados);

                return centigrados;
            }
            double resultado8 = ej8();
            writer.WriteLine("Resultado Ejercicio 8 (Celsius): " + resultado8);

            int ej9()
            {
                Console.WriteLine("Ingrese las horas del primer instante:");
                int hora1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los minutos del primer instante:");
                int minutos1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los segundos del primer instante:");
                int segundos1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese las horas del segundo instante:");
                int hora2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los minutos del segundo instante:");
                int minutos2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese los segundos del segundo instante:");
                int segundos2 = int.Parse(Console.ReadLine());

                int primerins = (hora1 * 3600) + (minutos1 * 60) + segundos1;
                int segundoinst = (hora2 * 3600) + (minutos2 * 60) + segundos2;

                int intervalo = Math.Abs(primerins - segundoinst);
                Console.WriteLine("Intervalo en segundos: " + intervalo);

                return intervalo;
            }
            int resultado9 = ej9();
            writer.WriteLine("Resultado Ejercicio 9 (Segundos): " + resultado9);

            int ej10()
            {
                Console.WriteLine("Indicar un número de tres cifras:");
                int numero3 = int.Parse(Console.ReadLine());

                int centenas = numero3 / 100;
                Console.WriteLine("Centenas: " + centenas);

                return centenas; 
            }
            int resultado10 = ej10();
            writer.WriteLine("Resultado Ejercicio 10 (Centenas): " + resultado10);

        }

        using (StreamReader reader = new StreamReader("archivo.txt"))
        {
            string contenidoDelArchivo = reader.ReadToEnd();

            Console.WriteLine(contenidoDelArchivo);
        }
    }
}