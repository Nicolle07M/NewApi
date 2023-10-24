using System.ComponentModel.DataAnnotations;

namespace NewApi.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public string Country { get; set; }

        public string Phone { get; set; }

        public  ICollection<Order>? Orders { get; set; }

    }
}
