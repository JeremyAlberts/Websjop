using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Websjop.Models
{
    public class ProductCatergory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
    }
}
