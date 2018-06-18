using System.ComponentModel.DataAnnotations;

namespace test.Models.ViewModels
{
    public class SchoolClassViewModel
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }

        [Required]
        [Display(Name="Class Name")]
        public string Name { get; set; }
    }
}