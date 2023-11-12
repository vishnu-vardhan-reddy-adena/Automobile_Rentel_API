using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace WebApplication16.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string? Colour { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int? SeatCapacity { get; set; }
        [ForeignKey("Categories")]
        public int CategoryId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Category? Category { get; set; }
    }
}
