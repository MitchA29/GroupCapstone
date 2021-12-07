using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {   [Key]

        public string UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        [ForeignKey("ShoppingCart")]
        public string Id { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
