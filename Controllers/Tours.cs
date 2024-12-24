using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;

namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToursController : ControllerBase
    {
        private readonly maContext _context;

        public ToursController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tours = _context.Tours.ToList();
            return Ok(tours);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var tour = _context.Tours.Find(id);
            if (tour == null) return NotFound();
            return Ok(tour);
        }

       
    }
}
