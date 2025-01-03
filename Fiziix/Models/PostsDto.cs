using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiziix.Models
{
    internal class PostsDto
    {
        public int PostID { get; set; }
        public string ProjectName { get; set; }
        public string Username { get; set; }
        public string  UserPhoto { get; set; }
        public bool IsLiked { get; set; }
        public int LikeCount { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public string PostImage { get; set; }
    }
}

