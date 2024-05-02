using System.ComponentModel.DataAnnotations;

namespace ExamenP1.Models
{
    public class Carrera
    {

        public string Id { get; set; }
        [Required]
        public string NombreCarrera { get; set; }
        public string Campus { get; set; }
        public int NumeroSemestres { get; set; }

    }
}
