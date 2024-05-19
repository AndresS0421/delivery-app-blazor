using System.ComponentModel.DataAnnotations;

namespace _3Parcial.Models
{
    public class Vehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El modelo es requerido")]
        public string? Model { get; set; }

        [Required(ErrorMessage = "El color es requerido")]
        public string? Color { get; set; }

        [Required(ErrorMessage = "La marca es requerida")]
        public string? Brand { get; set; }

        [Required(ErrorMessage = "El año es requerido")]
        //[Range(1900, 2100, ErrorMessage = "El año debe de ser válido")]
        public string? Year { get; set; }

        [Required(ErrorMessage = "El kilometraje es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El kilometraje debe de ser válido")]
        public int? Kilometrage { get; set; }

        public VehicleType Type { get; set; }
        public VehicleStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public enum VehicleType
    {
        CAR,
        TRUCK,
        PICKUP,
        VAN,
        OTHER
    }
    public enum VehicleStatus
    {
        ACTIVE,
        DAMAGED,
        OFF_DUTY,
        IN_SERVICE
    }
}
