using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace eCommerceStarterCode.Models
{
    public class User : IdentityUser
    {   [Key]

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}
