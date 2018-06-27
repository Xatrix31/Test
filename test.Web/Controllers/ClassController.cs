using System.Web.Mvc;
using test.Models.Interfaces;
using test.Models.ViewModels;
using test.Web.Models;

namespace test.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassesService _classesService;
        private readonly ITeachersService _teachersService;

        public ClassController(IClassesService classesService, ITeachersService teachersService)
        {
            _classesService = classesService;
            _teachersService = teachersService;
        }

        // GET: Class
        public ActionResult Index(long id)
        {
            var currentClass = _classesService.GetClassById(id);
            return View(new MyViewModel
            {
                Id = currentClass.Id,
                Name = currentClass.Name,
                MonitorName = currentClass.MonitorName,
                FreeTeachers = new SelectList(_teachersService.GetTeachersNotInClass(id), "Id", "FullName")
            });
        }


        public ActionResult SetMonitor(PupilViewModel vm)
        {
            if (vm != null)
            {
                _classesService.SetMonitor(vm);
            }
            return RedirectToAction("Index", new { id = vm?.IdClass });
        }
    }
}