using System.Web.Mvc;
using test.Models.Interfaces;
using test.Models.ViewModels;

namespace test.Web.Controllers
{
    public class PupilController : Controller
    {
        private readonly IPupilsService _pupilsService;

        public PupilController(IPupilsService pupilsService)
        {
            _pupilsService = pupilsService;
        }

        // GET: Pupil
        public ActionResult Pupils(long id)
        {
            return PartialView(_pupilsService.GetPupilsByIdClass(id));
        }

        // POST: Class/Create
        [HttpPost]
        public ActionResult CreatePupil(PupilViewModel vm)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _pupilsService.AddPupil(vm);
                }
                return RedirectToAction("Index", "Class", new { id = vm.IdClass });
            }
            catch
            {
                return RedirectToAction("Index", "Class", new { id = vm.IdClass });
            }
        }

        // GET: Class/Edit/5
        public ActionResult EditPupil(long id)
        {
            return View(_pupilsService.GetPupilById(id));
        }

        // POST: Class/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditPupil(long id, PupilViewModel vm)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _pupilsService.EditPupil(vm);
                }
                return RedirectToAction("Index", "Class", new { id = vm.IdClass });
            }
            catch
            {
                return RedirectToAction("Index", "Class", new { id = vm.IdClass });
            }
        }

        // POST: Class/Delete/5
        [HttpPost]
        public ActionResult DeletePupil(PupilViewModel vm)
        {
            try
            {
                // TODO: Add delete logic here
                _pupilsService.DeletePupil(vm.Id);
                return RedirectToAction("Index", "Class", new { id = vm.IdClass });
            }
            catch
            {
                return RedirectToAction("Index", "Class", new { id = vm.IdClass });
            }
        }
    }
}