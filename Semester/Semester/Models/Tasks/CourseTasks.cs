using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Semester.Models
{
    public class CourseTasks:Tasks 
    {
        public Guid CourseId { get; set; }
    }
}
