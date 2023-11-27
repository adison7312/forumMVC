using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class Forums
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ThreadsNumber { get; set; }
        public int PostsNumber { get; set; }
    }
}
