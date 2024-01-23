using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Websjop.Database;

namespace Websjop.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;            
        }

        [HttpGet(Name = "GetAllProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _context.Product.Include(many => many.Categories).ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id:int}", Name = "GetAllProductsPerCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetProductsPerCategory(int id)
        {
            var products = await _context.Product.Include(many => many.Categories).Where(c => c.Categories.Any(k => k.Id == id)).ToListAsync();

            return Ok(products);
        }
    }
}
