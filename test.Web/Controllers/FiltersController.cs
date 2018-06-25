using System;
using System.Web.Mvc;
using test.Models.Enums;
using test.Models.Interfaces;
using test.Web.Models;

namespace test.Web.Controllers
{
    public class FiltersController : Controller
    {
        private readonly IPupilsService _pupilsService;
        private readonly IClassesService _classesService;

        public FiltersController(IPupilsService pupilsService, IClassesService classesService)
        {
            _pupilsService = pupilsService;
            _classesService = classesService;
        }

        // GET: Filters
        public ActionResult Index(string gender, string className)
        {
            return View(new FilterViewModel
            {
                Genders = new SelectList(Enum.GetValues(typeof(Gender))),
                SchoolClasses = new SelectList(_classesService.GetClassNames()),
                Pupils = _pupilsService.GetFilteredPupils(gender, className)
            });
        }
    }
}