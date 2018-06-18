using System.ComponentModel.DataAnnotations;
using test.Models.Enums;

namespace test.Models.ViewModels
{
    public class PupilViewModel
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }

        [Required(ErrorMessage ="Enter the Name")]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the Surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        public Sex Sex { get; set; }


        public string ClassName { get; set; }
    }
}