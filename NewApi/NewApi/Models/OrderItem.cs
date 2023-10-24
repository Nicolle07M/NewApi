using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewApi.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public decimal UnitPrice { get; set; } = 0;

        public decimal Quantity { get; set; } = 1;
        [ForeignKey("OrderId")]
        public  Order Order { get; set; }
        [ForeignKey("ProductId")]
        public  Product Product { get; set; }
    
    }
}