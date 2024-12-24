using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;

namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly maContext _context;

        public CitiesController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var cities = _context.Cities.ToList();
            return Ok(cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var city = _context.Cities.Find(id);
            if (city == null) return NotFound();
            return Ok(city);
        }

        
    }
}
