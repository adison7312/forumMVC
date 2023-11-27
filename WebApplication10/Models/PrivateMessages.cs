using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class PrivateMessages
    {
        public int Id { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Content { get; set; }
        public DateTime MessageDate { get; set; }
        public bool IsMessageRead { get; set; }
    }
}
