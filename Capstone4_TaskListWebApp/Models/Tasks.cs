using System;
using System.Collections.Generic;

namespace Capstone4_TaskListWebApp.Models
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Complete { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
