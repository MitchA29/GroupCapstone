using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class ShoppingCart
    {
          [Key]
          public int Id { get; set; }

          public string Quantity { get; set; }

          public string ProductId { get; set; }

          [ForeignKey("User")]
          public string UserId { get; set; }
          public User User { get; set; }
        }
    }

