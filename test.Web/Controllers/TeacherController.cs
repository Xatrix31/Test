﻿using System.Web.Mvc;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeachersService _teacherService;

        public TeacherController(ITeachersService teacherService)
        {
            _teacherService = teacherService;
        }

        public ActionResult AddTeacher()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddTeacher(TeacherViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _teacherService.AddTeacher(vm);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult AddTeacherToClass(long id, TeacherViewModel vm)
        {
            _teacherService.AddTeacherToClass(id, vm);
            return RedirectToAction("Index", "Class", new { id });
        }

        public ActionResult TeachersByClass(long id)
        {
            return PartialView("Teachers", _teacherService.GetTeachersByIdClass(id));
        }

        public ActionResult GetAllTeachers()
        {
            return PartialView("Teachers", _teacherService.GetAllTeachers());
        }

        [HttpPost]
        public ActionResult RemoveTeacherFromClass(long id, long idTeacher)
        {
            _teacherService.DeleteTeacherFromClass(id, idTeacher);
            return RedirectToAction("Index", "Class", new { id });
        }
    }
}