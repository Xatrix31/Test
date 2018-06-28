using System.Web.Mvc;
using test.Models.ViewModels;

namespace test.Web.Models
{
    public class EditTeacherViewModel : TeacherViewModel
    {
        public SelectList TeacherTypes { get; set; }
    }
}