using System.Collections.Generic;
using System.Web.Mvc;
using test.Models.ViewModels;

namespace test.Web.Models
{
    public class FilterViewModel
    {
        public IEnumerable<PupilViewModel> Pupils { get; set; }
        public SelectList Genders { get; set; }
        public SelectList SchoolClasses { get; set; }
    }
}