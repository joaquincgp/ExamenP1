using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExamenP1.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Carrera")]
        public string NombreCarrera { get; set; }
        [Required]
        public string Campus { get; set; }
        [DisplayName("Nivel")]
        public int? NumeroSemestres { get; set; }

    }
}
