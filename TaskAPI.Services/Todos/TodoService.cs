﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskAPI.Models;

namespace TaskAPI.Services.Todos
{
    public class TodoService : ITodoRepository
    {
        public Todo AddTodo(int authorId, Todo todo)
        {
            throw new NotImplementedException();
        }

        //Get Todos hard code values

        public List<Todo> AllTodos(int authorId)
        {
            var todos = new List<Todo>();

            var todo1 = new Todo
            {
                Id = 1,
                Title = "Get books for school",
                Description = "Get some text books for school",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };

            todos.Add(todo1);

            var todo2 = new Todo
            {
                Id = 2,
                Title = "Get vegitables",
                Description = "Get vegitables for the week",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.Inprogress
            };

            todos.Add(todo2);

            var todo3 = new Todo
            {
                Id = 3,
                Title = "Water the plans",
                Description = "Water all the plants quickly",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(1),
                Status = TodoStatus.Completed
            };

            todos.Add(todo3);

            return todos;
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo GetTodo(int authorId,int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
