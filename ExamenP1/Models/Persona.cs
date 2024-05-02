using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenP1.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string? Nombre { get; set; }
        [Range(0, 10)]
        public decimal? Promedio { get; set; }
        public bool? esEcuatoriano { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [ForeignKey ("CarreraId")]
        public int? CarreraId { get; set; }
        public Carrera? Carrera { get; set; }

    }
}
