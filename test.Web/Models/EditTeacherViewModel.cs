using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models.ViewModels;

namespace test.Web.Models
{
    public class EditTeacherViewModel:TeacherViewModel
    {
        public SelectList TeacherTypes { get; set; }
    }
}