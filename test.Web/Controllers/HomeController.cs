using System.Web.Mvc;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClassesService _classesService;
        private readonly ITeachersService _teacherService;

        public HomeController(IClassesService classesService, ITeachersService teacherService)
        {
            _classesService = classesService;
            _teacherService = teacherService;
        }

        public ActionResult Index()
        {
            ViewBag.Director = _teacherService.GetDirector();
            return View(_classesService.GetClasses());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddClass(SchoolClassViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _classesService.AddClass(viewModel);
                ViewBag.Message = "Added";
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditClass(long id)
        {
            return View(_classesService.GetClassById(id));
        }

        // POST: Class/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditClass(long id, SchoolClassViewModel vm)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _classesService.EditClass(vm);
                    ViewBag.Message = "Edited";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index", _classesService.GetClasses());
            }
        }
    }
}