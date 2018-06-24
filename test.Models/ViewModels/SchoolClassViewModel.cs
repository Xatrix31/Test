using System.ComponentModel.DataAnnotations;

namespace test.Models.ViewModels
{
    public class SchoolClassViewModel
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }

        [Required(ErrorMessage ="Write Class Name")]
        [Display(Name="Class Name")]
        public string Name { get; set; }
    }
}