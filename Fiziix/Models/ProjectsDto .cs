using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiziix.Models
{
    public class ProjectsDto
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string Manager { get; set; }
        public string ProjectImage { get; set; }
        public int MemberCount { get; set; }
        
    }
}
