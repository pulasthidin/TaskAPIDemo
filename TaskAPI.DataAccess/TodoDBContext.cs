using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.DataAccess
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }
        //add all models like todos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=CML-PULASTHIRAN\\SQL2019; Database=MyTodoDb; User Id=sa; Password =123";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author {Id = 1, FullName = "Pulasthi Dinusha", AddressNo ="45", Street ="Street 1", City = "Colombo 1" }, 
                new Author {Id = 2, FullName ="Ruvini Suranika", AddressNo ="35", Street ="Street 2", City = "Colombo 2"  },
                new Author {Id = 3, FullName = "Rex", AddressNo ="25", Street ="Street 3", City = "Colombo 3"  },
                new Author {Id = 4, FullName ="Kitty", AddressNo ="15", Street ="Street 4", City = "Colombo 4"  }

            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
               new Todo
               { Id = 1,
                Title = "Get books for school - DB",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New,
                AuthorId =  1
               },
               new Todo
               { Id = 2,
                Title = "Get vegitables - DB",
                Description = "Get vegitables for the week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New,
                AuthorId = 2
               },
               new Todo
               { Id = 3,
                Title = "Water the plans - DB",
                Description = "Water all the plants quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(3),
                Status = TodoStatus.New,
                AuthorId = 1
               }

            });
        }
    }
}
