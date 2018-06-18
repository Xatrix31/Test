using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClassesService _classesService;

        public HomeController(IClassesService classesService)
        {
            _classesService = classesService;
        }

        public ActionResult Index()
        {
            return View(_classesService.GetClasses());
        }

        [HttpPost]
        public ActionResult Index(SchoolClassViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Added";
                _classesService.AddClass(viewModel);
            }
            return View();
        }
    }
}