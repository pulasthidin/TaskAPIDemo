using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services.Authors;

namespace TaskAPI.Controllers
{
    [Route("api/authors")] //when it name as controllers, we can't change controler name again and again so we create hard code value
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        public AuthorsController(IAuthorRepository service)
        {
            _authorRepository = service;
        }

        [HttpGet]
        public IActionResult GetAuthor()
        {
            var authors = _authorRepository.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            return Ok(author);
        }
    }
}
