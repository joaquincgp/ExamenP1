namespace ExamenP1.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Promedio { get; set; }
        public bool esEcuatoriano { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Carrera Carrera { get; set; }

    }
}
