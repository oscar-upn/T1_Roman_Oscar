using Microsoft.EntityFrameworkCore;
using T1_Roman_Oscar.Models;

namespace T1_Roman_Oscar.Datos
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Libro> Libro { get; set; }
    }
}
