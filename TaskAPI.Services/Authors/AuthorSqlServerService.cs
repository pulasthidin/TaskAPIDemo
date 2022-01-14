using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.DataAccess;

namespace TaskAPI.Services.Authors
{
    public class AuthorSqlServerService : IAuthorRepository
    {
        private readonly TodoDBContext _context = new TodoDBContext();

        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }

        public List<Author> GetAllAuthors(string job, string search) 
        {
            if(string.IsNullOrEmpty(job) && string.IsNullOrEmpty(search))
            {
                return GetAllAuthors();
            }

            var authorCollection = _context.Authors as IQueryable<Author>; //for SQl Queary

            if (!string.IsNullOrEmpty(job))
            {
                job = job.Trim(); // remove spaces end and start side
                authorCollection = authorCollection.Where(a => a.JobRole == job);
            }

            if(!string.IsNullOrEmpty(search))
            {
                search = search.Trim();
                authorCollection = authorCollection.Where(a => 
                a.FullName.Contains(search) || a.City.Contains(search)
                );
            }

            return authorCollection.ToList();

            //1 filter 2 search otherwise performance hit comming 
        }

        public Author AddAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();

            return _context.Authors.Find(author.Id);
        }
    }
}
