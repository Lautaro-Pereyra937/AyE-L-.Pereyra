using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Producto[] productos = new Producto[3];

            productos[0] = new Producto("Panchito", 24, 1300);
            productos[1] = new Producto("Arroz", 234, 1700);
            productos[2] = new Producto("Ceboolla", 346124624, 300);

            foreach (Producto produ in productos)
            {
                Console.WriteLine($"Nombre: {produ.Nombre} Precio: {produ.Precio}");
            }

            using var db = new AppDbContext();

            var producto1 = new productos
            {
                Nombre = productos[0].Nombre,
                Codigo = productos[0].Codigo,
                Precio = productos[0].Precio
            };

            db.productos.Add(producto1);

            var producto2 = new productos
            {
                Nombre = productos[1].Nombre,
                Codigo = productos[1].Codigo,
                Precio = productos[1].Precio
            };

            db.productos.Add(producto2);

            var producto3 = new productos
            {
                Nombre = productos[2].Nombre,
                Codigo = productos[2].Codigo,
                Precio = productos[2].Precio
            };

            db.productos.Add(producto3);
            await db.SaveChangesAsync();
        }
    }
}
