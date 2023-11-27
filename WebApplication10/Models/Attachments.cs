using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class Attachments
    {
        public int Id { get; set; }
        public int PostID { get; set; }
        public string FilePath { get; set; }
        public int FileSize { get; set; }
    }
}