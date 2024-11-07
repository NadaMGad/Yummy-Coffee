using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YummyCoffee.Models
{
    public class Order
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        [Required]
        public string OrderDetails { get; set; }





    }
}
