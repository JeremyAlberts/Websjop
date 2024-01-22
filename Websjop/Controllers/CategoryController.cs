using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Websjop.Database;

namespace Websjop.Controllers
{
    [ApiController]
    [Route("api/category")]
    public class CategoryController : Controller
    {
        private ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Index()
        {
            var categories = await _context.Catergory.Include(many => many.Products).ToListAsync();

            return Ok(categories);
        }
    }
}
