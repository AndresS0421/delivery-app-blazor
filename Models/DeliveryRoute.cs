using System.ComponentModel.DataAnnotations;

namespace _3Parcial.Models
{
    public class DeliveryRoute
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La distancia es requerida")]
        public float? Distance { get; set; }

        [Required(ErrorMessage = "La duración estimada es requerida y en minutos")]
        public int? EstimatedDuration { get; set; }

        [Required(ErrorMessage = "El tiempo de inicio es requerido")]
        public DateTime? StartAt { get; set; }

        [Required(ErrorMessage = "El tiempo de finalización es requerido")]
        public DateTime? EndAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        virtual public Location? Origin { get; set; }

        virtual public Location? Destination { get; set; }
    }
}
