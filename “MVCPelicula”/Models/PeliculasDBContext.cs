using _MVCPelicula_.Models.Seeds;
using _MVCPelicula_.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCPelicula.Models
{
    public class PeliculasDBContext : DbContext
    {
        public PeliculasDBContext(DbContextOptions<PeliculasDBContext> options)
            : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new GeneroSeed());
            modelBuilder.ApplyConfiguration(new PeliculaSeed());
        }
    }
}



