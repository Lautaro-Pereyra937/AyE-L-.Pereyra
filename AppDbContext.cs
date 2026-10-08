using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

namespace MiBasesitadeDatos
{
    internal class AppDbContext : DbContext
    {
        public DbSet<goleadores_mundial> goleadores_mundial => Set<goleadores_mundial>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost;Port=3307;Database=mundial;Uid=root;pwd=";
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}
