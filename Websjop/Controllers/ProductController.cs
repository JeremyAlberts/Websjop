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
        public async Task<ActionResult> Index()
        {
            var products = await _context.Product.Include(many => many.Categories).ToListAsync();

            return Ok(products);
        }
    }
}
