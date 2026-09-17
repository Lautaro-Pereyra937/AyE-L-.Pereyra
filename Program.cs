using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MiBasesitadeDatos
{
    internal class Program
    {
        static void Mostrar(Punto2D punto)
        {
            Console.WriteLine($"Coordenada X: {punto.X} Coordenada Y: {punto.Y}");
        }
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();

            Console.WriteLine("Ingrese coordenada n°1 en X ");
            int corx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada n°1 en Y");
            int cory = Convert.ToInt32(Console.ReadLine());

            Punto2D punto1 = new Punto2D(corx,cory);

            Console.WriteLine("Ingrese coordenada n°2 en X ");
            corx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada n°2 en Y");
            cory = Convert.ToInt32(Console.ReadLine());
            Punto2D punto2 = new Punto2D(corx,cory);

            Console.WriteLine("Ingrese coordenada n°3 en X ");
            corx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada n°3 en Y");
            cory = Convert.ToInt32(Console.ReadLine());
            Punto2D punto3 = new Punto2D(corx,cory);

            Mostrar(punto1);
            Mostrar(punto2);
            Mostrar(punto3);


            //insertar

            var dato1 = new puntos
            {
                X = punto1.X,
                Y = punto1.Y
            };

            db.puntos.Add(dato1);

            var dato2 = new puntos
            {
                X = punto2.X,
                Y = punto2.Y
            };

            db.puntos.Add(dato2);

            var dato3 = new puntos
            {
                X = punto3.X,
                Y = punto3.Y
            };

            db.puntos.Add(dato3);

            await db.SaveChangesAsync();

            Console.WriteLine("Ingrese coordenada X(nueva) para el punto 3");
            int newcorx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese coordenada Y(nueva) para el punto 3");
            int newcory = Convert.ToInt32(Console.ReadLine());

            int id = 18;
            var datoBuscado = await db.puntos.FindAsync(id);

            //Update

            if(datoBuscado != null)
            {
                datoBuscado.X = newcorx;
                datoBuscado.Y = newcory;

                await db.SaveChangesAsync();
            }

            if(datoBuscado != null)
            {
                db.puntos.Remove(datoBuscado);
                await db.SaveChangesAsync();
            }

            var todos = await db.puntos.ToListAsync();
            foreach(var e in todos)
            {
                Console.WriteLine($"{e.X} / {e.Y}");
            }
        }
    }
}
