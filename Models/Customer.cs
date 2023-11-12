using System.ComponentModel.DataAnnotations;

namespace WebApplication16.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }


        public string? Name { get; set; }

        public string? Address1 { get; set; }

        public string? License { get; set; }

        public int? Age { get; set; }
    }
}
