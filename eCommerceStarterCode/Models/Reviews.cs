using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerceStarterCode.Models
{
    public class Reviews
    {
        [Key]
        public int Id { get; set; }

        public int Rating { get; set; }

        public string ReviewContent { get; set; }

        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public Products Product { get; set; }
    }
}
