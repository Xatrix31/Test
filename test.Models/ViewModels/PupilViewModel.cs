﻿using System.ComponentModel.DataAnnotations;
using test.Models.Enums;

namespace test.Models.ViewModels
{
    public class PupilViewModel
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter the Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the Surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [ScaffoldColumn(false)]
        public long IdClass { get; set; }

        [Required]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }
    }
}