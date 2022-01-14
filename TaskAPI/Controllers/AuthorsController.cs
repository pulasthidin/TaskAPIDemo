using AutoMapper; //auto mapper
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")] //when it name as controllers, we can't change controler name again and again so we create hard code value
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet] //https://localhost:44356/api/authors/?job=Developer //https://localhost:44356/api/authors?job=Developer&search=s
        public ActionResult<ICollection<AuthorDto>> GetAuthor(string job, string search)  // https://domain//api/authors/?job=Developer (string job) or ([FromQuery] string job) we used this for getting value from query string
        {

            //throw new Exception("Test error"); //for testing production server error

            var authors = _service.GetAllAuthors(job, search);
           
            var mappedAuthors =_mapper.Map<ICollection<AuthorDto>>(authors); // because of list we put Icollection using Mapping

            return Ok(mappedAuthors);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetAuthor(int id)
        {
            var author = _service.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author); // mapping single author

            return Ok(mappedAuthor);
        }

        [HttpPost]
        public ActionResult<AuthorDto> CreateAuthor(CreateAuthorDto author)
        {
            var authorEntity = _mapper.Map<Author>(author);
            var newAuthor = _service.AddAuthor(authorEntity);

            var authorForReturn = _mapper.Map<AuthorDto>(newAuthor);

            return CreatedAtRoute("GetAuthor", new { id = authorForReturn.Id }, authorForReturn);
        }
    }
}
