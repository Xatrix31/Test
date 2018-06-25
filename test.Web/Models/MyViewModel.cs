using System.Web.Mvc;
using test.Models.ViewModels;

namespace test.Web.Models
{
    public class MyViewModel : SchoolClassViewModel
    {
        public SelectList FreeTeachers { get; set; }
    }
}