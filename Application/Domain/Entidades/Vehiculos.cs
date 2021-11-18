using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Vehiculos
{
    public class Vehiculo
    {
        [Required]
        [StringLength(30)]
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string Linea { get; set; }
        [Range(1, 2,
    ErrorMessage = "El valor para {0} debde de ser {1} entre {2}.")]
        public int Equipamiento { get; set; }
        public decimal Precio { get; set; }
    }
}
