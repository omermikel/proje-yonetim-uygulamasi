using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiziix.Models
{
    internal class TaskDto
    {
        public int TaskID { get; set; }
        public string AssignedUserName { get; set; } // Bu yeni eklenen özellik
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public int AssignedTo { get; set; }
        public int ProjectID { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime DueDate { get; set; }
        public string File { get; set; }
    }
}
