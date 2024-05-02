using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenP1.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        public decimal? Promedio { get; set; }
        public bool? esEcuatoriano { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [ForeignKey ("CarreraId")]
        public int? CarreraId { get; set; }
        public Carrera Carrera { get; set; }

    }
}
