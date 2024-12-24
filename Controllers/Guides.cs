using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;

namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuidesController : ControllerBase
    {
        private readonly maContext _context;

        public GuidesController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var guides = _context.Guides.ToList();
            return Ok(guides);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var guide = _context.Guides.Find(id);
            if (guide == null) return NotFound();
            return Ok(guide);
        }

      
    }
}
