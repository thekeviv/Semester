using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semester.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semester.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewCourse : ContentPage
    {
        public CoursesViewModel viewModel;
        public AddNewCourse()
        {
            InitializeComponent();
        }

        public AddNewCourse(CoursesViewModel _viewModel)
        {
            InitializeComponent();
            this.viewModel = _viewModel;
            BindingContext = viewModel;
        }
        
    }
}