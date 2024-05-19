using System.ComponentModel.DataAnnotations;

namespace _3Parcial.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La calle es requerida")]
        public string? Street { get; set; }

        [Required(ErrorMessage = "El número es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El número no es válido")]
        public int? ExtNumber { get; set; }

        public int? IntNumber { get; set; }

        [Required(ErrorMessage = "La colonia es requerida")]
        public string? Neighborhood { get; set; }

        [Required(ErrorMessage = "El código postal es requerido")]
        [Length(5, 5, ErrorMessage = "El código postal no es válido")]
        public string? ZipCode { get; set; }

        [Required(ErrorMessage = "La ciudad es requerida")]
        public string? City { get; set; }

        [Required(ErrorMessage = "El Estado es requerido")]
        public string? State { get; set; }

        [Required(ErrorMessage = "El país es requerido")]
        public string? Country { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
