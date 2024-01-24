using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Websjop.Models
{
    [Table("Product")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public int Quantity { get; set; }
        [Required]
        [Precision(10, 4)]
        public decimal Price { get; set; }
        public bool HasDiscount { get; set; }
        [Precision(10, 4)]
        public decimal DiscountPrice { get; set; }
        [Range(0, 100)]
        public int DiscountPercentage { get; set; }
        public string? Description { get; set; }
        public ICollection<Category> Categories { get; } = [];
        public DateTime EndDiscountDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
