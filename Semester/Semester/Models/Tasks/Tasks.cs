using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Semester.Models
{
    public class Tasks
    {
        public Tasks()
        {
            this.Id = Guid.NewGuid();
        }
        [PrimaryKey]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean isDone { get; set; }
    }
}
