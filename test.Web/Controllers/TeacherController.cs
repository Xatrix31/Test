using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models.Interfaces;

namespace test.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeachersService _teacherService;

        public TeacherController(ITeachersService teacherService)
        {
            _teacherService = teacherService;
        }


    }
}