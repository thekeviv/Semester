using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Semester.Models
{
    public class Course
    {
        public Course()
        {
            this.CourseId = Guid.NewGuid();
        }
        [PrimaryKey, AutoIncrement]
        public Guid CourseId { get; set; }

        public string CourseName { get; set; }

        public string SchoolName { get; set; } 

        public DateTime CourseStartDate { get; set; }

        public DateTime CourseEndDate { get; set; }
    }
}
