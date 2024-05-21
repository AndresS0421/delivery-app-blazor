using System.ComponentModel.DataAnnotations;

namespace _3Parcial.Models
{
    public class Stops
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
             
        [Required(ErrorMessage = "La ubicación es necesaria")]
        virtual public Location? Location { get; set; }

        virtual public ICollection<DeliveryRoute> Routes { get; set; }
    }
}
