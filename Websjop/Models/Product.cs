using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Websjop.Models
{
    [Table("Product")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; } = [];
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
