﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public int ThreadID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
