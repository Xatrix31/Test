using System.ComponentModel.DataAnnotations;

namespace test.Models.ViewModels
{
    public class TeacherViewModel
    {
        [Required(ErrorMessage = "Enter the Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the Surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
    }
}