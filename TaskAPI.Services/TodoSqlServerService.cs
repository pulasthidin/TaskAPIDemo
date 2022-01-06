﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Models;
using TaskAPI.DataAccess;

namespace TaskAPI.Services
{
    public class TodoSqlServerService : ITodoRepository
    {
        private readonly TodoDBContext _context = new TodoDBContext();  
        public List<Todo> AllTodos()
        {
            return _context.Todos.ToList();
        }
    }
}
