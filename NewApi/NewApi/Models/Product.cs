using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewApi.Models
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        public string ProductId { get; set; }

        public int SupplierId { get; set; }

        public decimal UnitPrice { get; set; } = 0;
        public string Package { get; set; }

        public bool IsDiscontinued { get; set; } = false;
        [ForeignKey("SupplierId")]

        public Supplier Supplier { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}