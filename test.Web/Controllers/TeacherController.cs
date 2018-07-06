using System.Web.Mvc;
using test.Models.Interfaces;
using test.Models.ViewModels;
using test.Web.Models;

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
            return View(new EditTeacherViewModel
            {
                TeacherTypes = new SelectList(_teacherService.GetAllTypes(), "Title", "Title")
            });
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
        public ActionResult AddTeacherToClass(long? id, long? idTeacher)
        {
            if (id != null && idTeacher != null)
                _teacherService.AddTeacherToClass(id.Value, idTeacher.Value);
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

        public ActionResult RemoveTeacherFromClass(long id, long idTeacher)
        {
            _teacherService.DeleteTeacherFromClass(id, idTeacher);
            return RedirectToAction("Index", "Class", new { id });
        }

        public ActionResult ChangeDirector()
        {
            return View(new SelectList(_teacherService.GetAllTeachers(), "Id", "FullName", _teacherService.GetDirector()));
        }

        [HttpPost]
        public ActionResult ChangeDirector(long vm)
        {
            _teacherService.SetDirector(vm);
            return RedirectToAction("Index", "Home");
        }
    }
}