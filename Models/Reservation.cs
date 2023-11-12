using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication16.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int? CustomerId { get; set; }
        public decimal? TotalAmount { get; set; }
        [ForeignKey("Cars")]
        public int? CarId { get; set; }
        public string? Time { get; set; }

        public virtual Car? Car { get; set; }
        public virtual Customer? Customers { get; set; }
    }
}
