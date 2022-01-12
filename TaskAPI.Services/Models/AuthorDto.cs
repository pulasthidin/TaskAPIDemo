using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAPI.Services.Models
{
    public class AuthorDto //it called also Author view model. we implemented this because author model class we can't provide to end usert to direct
    {
        public int Id { get; set; }
        public string FullName { get; set; }      
        public string Address { get; set; }
        public string JobRole { get; set; }
        
    }
}
