using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;

namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly maContext _context;

        public BookingsController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var bookings = _context.Bookings.ToList();
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var booking = _context.Bookings.Find(id);
            if (booking == null) return NotFound();
            return Ok(booking);
        }

        
    }
}
