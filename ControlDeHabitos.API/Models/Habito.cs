namespace ControlDeHabitos.API.Models
{
    public class Habito
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public string Frecuencia { get; set; } = string.Empty;

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin {  get; set; }
        public bool Completado { get; set; }


    }
}
