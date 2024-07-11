using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _MVCPelicula_.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string Nombre { get; set; }

        // Propiedad de navegación
        public ICollection<Pelicula> Peliculas { get; set; } = new List<Pelicula>();
    }
}

