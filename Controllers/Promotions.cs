using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;

namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionsController : ControllerBase
    {
        private readonly maContext _context;

        public PromotionsController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var promotions = _context.Promotions.ToList();
            return Ok(promotions);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var promotion = _context.Promotions.Find(id);
            if (promotion == null) return NotFound();
            return Ok(promotion);
        }

       
    }
}
