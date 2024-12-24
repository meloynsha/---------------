using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using основа.Models;


namespace основа.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQsController : ControllerBase
    {
        private readonly maContext _context;

        public FAQsController(maContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var faqs = _context.Faqs.ToList();
            return Ok(faqs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var faq = _context.Faqs.Find(id);
            if (faq == null) return NotFound();
            return Ok(faq);
        }

      
    }
}
