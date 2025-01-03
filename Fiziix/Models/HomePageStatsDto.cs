using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiziix.Models
{
    internal class HomePageStatsDto
    {
        public class ApiResponse
        {
            public List<TaskData> Tasks { get; set; }
            public List<ProjectTaskStatus> ProjectTasksStatus { get; set; }
            public List<UserPost> UserPosts { get; set; }
            public List<UserLike> UserLikes { get; set; }
        }

        public class TaskData
        {
            public string ProjectName { get; set; }
            public string TaskName { get; set; }
            public DateTime DueDate { get; set; }
            public int TaskStatus { get; set; }
        }

        public class ProjectTaskStatus
        {
            public string ProjectName { get; set; }
            public int CompletedTasks { get; set; }
            public int IncompleteTasks { get; set; }
        }

        public class UserPost
        {
            public string ProjectName { get; set; }
            public int PostCount { get; set; }
        }

        public class UserLike
        {
            public string ProjectName { get; set; }
            public int LikeCount { get; set; }
        }

    }
}
