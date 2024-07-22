using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace _MVCPelicula_.Models.Seeds
{
    public class GeneroSeed : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasData(
                new Genero { Id = 1, Nombre = "Comedia" },
                new Genero { Id = 2, Nombre = "Romance" },
                new Genero { Id = 3, Nombre = "Aventura" },
                new Genero { Id = 4, Nombre = "Acción" },
                new Genero { Id = 5, Nombre = "Ficción" },
                new Genero { Id = 6, Nombre = "Drama" }
            );
        }
    }
}
