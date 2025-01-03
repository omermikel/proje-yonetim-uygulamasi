using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiziix.Models
{
    internal class PostDto
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
