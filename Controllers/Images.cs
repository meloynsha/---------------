using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;

namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly maContext _context;

        public ImagesController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var images = _context.Images.ToList();
            return Ok(images);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var image = _context.Images.Find(id);
            if (image == null) return NotFound();
            return Ok(image);
        }

        
    }
}
