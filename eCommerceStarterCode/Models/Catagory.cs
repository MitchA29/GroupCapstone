using System.ComponentModel.DataAnnotations;

namespace eCommerceStarterCode.Models
{
    public class Catagory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
