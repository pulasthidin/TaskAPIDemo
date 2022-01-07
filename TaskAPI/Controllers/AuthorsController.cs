using AutoMapper; //auto mapper
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")] //when it name as controllers, we can't change controler name again and again so we create hard code value
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorRepository service, IMapper mapper)
        {
            _authorRepository = service;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthor()
        {
            //throw new Exception("Test error"); //for testing production server error

            var authors = _authorRepository.GetAllAuthors();
           
            var mappedAuthors =_mapper.Map<ICollection<AuthorDto>>(authors); // because of list we put Icollection using Mapping

            return Ok(mappedAuthors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorRepository.GetAuthor(id);

            if (author is null)
            {
                return NotFound();
            }

            var mappedAuthor = _mapper.Map<AuthorDto>(author); // mapping single author

            return Ok(mappedAuthor);
        }
    }
}
