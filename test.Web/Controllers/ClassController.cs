using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IClassesService _classesService;

        public ClassController(IClassesService classesService)
        {
            _classesService = classesService;
        }

        // GET: Class
        public ActionResult Index(long id)
        {
            return View(_classesService.GetClassById(id));
        }
    }
}
