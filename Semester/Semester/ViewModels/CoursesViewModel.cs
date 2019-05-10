using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Semester.Models;
namespace Semester.ViewModels
{
    public class CoursesViewModel : INotifyPropertyChanged
    {
        public IList<Course> source;
        public string[] courseNames { get; set; }
        public ObservableCollection<Course> courses { get; set; }
        public CoursesViewModel()
        {
            Course CSC320 = new Course { CourseName = "CSC320", SchoolName = "University of Victoria", CourseStartDate = new DateTime(2019, 5, 3), CourseEndDate = new DateTime(2019, 6, 28) };
            Course SENG310 = new Course { CourseName = "SENG310", SchoolName = "University of Victoria", CourseStartDate = new DateTime(2019, 5, 6), CourseEndDate = new DateTime(2019, 8, 10) };
            Course CSC426 = new Course { CourseName = "CSC426", SchoolName = "University of Victoria", CourseStartDate = new DateTime(2019, 5, 6), CourseEndDate = new DateTime(2019, 8, 10) };
            courseNames = new string[] { CSC320.CourseName, SENG310.CourseName, CSC426.CourseName }; 
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
