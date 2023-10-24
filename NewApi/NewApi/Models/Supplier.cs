using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace NewApi.Models
{
    public class Supplier
    {
        [Key]

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }

        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
 