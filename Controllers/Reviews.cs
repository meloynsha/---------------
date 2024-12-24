using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;

namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly maContext _context;

        public ReviewsController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var reviews = _context.Reviews.ToList();
            return Ok(reviews);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review == null) return NotFound();
            return Ok(review);
        }

       
    }
}
