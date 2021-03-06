﻿using System.ComponentModel.DataAnnotations;

namespace test.Models.ViewModels
{
    public class TeacherViewModel
    {
        [ScaffoldColumn(false)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter the Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the Surname")]
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        public string FullName { get; set; }

        [Required(ErrorMessage = "Choose type")]
        [Display(Name = "Teacher type")]
        public string TeacherType { get; set; }

        [ScaffoldColumn(false)]
        public long IdClass { get; set; }
    }
}