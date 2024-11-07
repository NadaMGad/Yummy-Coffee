using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace YummyCoffee.Models
{
    public class Customer : IdentityUser
    {
        public int LoyaltyPoints { get; set; }

    }
}
