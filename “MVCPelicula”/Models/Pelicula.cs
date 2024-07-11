using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _MVCPelicula_.Models
{
    public class Pelicula
    {
        public int ID { get; set; }

        [StringLength(250)]
        [Required]
        public string Titulo { get; set; }

        [Required]
        public DateTime FechaLanzamiento { get; set; }

        // Propiedad para la llave foránea
        [Required]
        [ForeignKey("Genero")]
        public int? GeneroId { get; set; }

        // Propiedad de navegación
        public Genero Genero { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [StringLength(250)]
        [Required]
        public string Director { get; set; }

    }

}
