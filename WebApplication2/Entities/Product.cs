using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entities
{
    public class Product
    {
        [Key]
        public int  Id {get ; set;}
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; } = null!;
        [Required]
        public Double ProductPrice { get; set;}
        [Required]
        public int  Qnt { get; set; }

    }
}
