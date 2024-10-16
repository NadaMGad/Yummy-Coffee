using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YummyCoffee.Models
{
    public class Order
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public  string Email { get; set; }
        [Required]
        public string MobilePhone { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public string OrderDetails { get; set; }





    }
}
