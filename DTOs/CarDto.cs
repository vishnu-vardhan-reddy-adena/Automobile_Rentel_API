using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication16.Models;

namespace WebApplication16.DTOs
{
    public class CarDto
    {
        [Key]
        public int CarId { get; set; }
        public string? Colour { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? SeatCapacity { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        
    }
}
