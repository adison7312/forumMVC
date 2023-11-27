using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class BannedList
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public int AddedBy { get; set; }
    }
}
