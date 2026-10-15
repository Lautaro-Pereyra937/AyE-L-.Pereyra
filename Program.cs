using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main()
        {
            string ruta = "inventario.json";

            // Si quedó alguna copia vieja oculta en la computadora, la borramos
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }

            Console.WriteLine("Conectando a la base de datos SQL y generando JSON...");

            try
            {
                // Nos conectamos a tu base de datos real usando tu DbContext
                using (var context = new AppDbContext())
                {
                    var listaDesdeSQL = context.pokemon.ToList();

                    // Guardamos los datos reales de phpMyAdmin en el archivo JSON
                    string jsonBD = JsonSerializer.Serialize(listaDesdeSQL, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(ruta, jsonBD);

                    Console.WriteLine($"¡Éxito! Se exportaron {listaDesdeSQL.Count} pokémones reales.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n[ERROR] No se pudo conectar a la base de datos SQL:");
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Detalle: " + ex.InnerException.Message);
                }
                return; // Frenamos aquí si la base de datos no responde
            }

            // LEEMOS EL ARCHIVO JSON RECIÉN GENERADO
            string contenidoJson = File.ReadAllText(ruta);

            var opciones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };

            try
            {
                List<pokemon>? pokemones = JsonSerializer.Deserialize<List<pokemon>>(contenidoJson, opciones);

                if (pokemones != null && pokemones.Count > 0)
                {
                    Console.WriteLine("\n--- MOSTRANDO DATOS DESDE EL ARCHIVO JSON ---");
                    foreach (var p in pokemones)
                    {
                        Console.WriteLine($"ID: {p.Id} - Nombre: {p.nombre} - Tipo 1: {p.tipo_1} - Tipo 2: {p.tipo_2} - HP: {p.hp} - Ataque: {p.ataque} - Defensa: {p.defensa}");
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Error al procesar el formato del JSON: " + ex.Message);
            }
        }
    }
}
