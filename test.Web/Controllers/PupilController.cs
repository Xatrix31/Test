using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
                return RedirectToAction("Index", "Class");
            }
            catch
            {
                return RedirectToAction("Index", "Class");
            }
        }

        // GET: Class/Edit/5
        public ActionResult EditPupil(long id)
        {
            return View();
        }

        // POST: Class/Edit/5
        [HttpPost]
        public ActionResult EditPupil(long id, PupilViewModel collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {

                }
                return RedirectToAction("Index", "Class");
            }
            catch
            {
                return RedirectToAction("Index", "Class");
            }
        }

        // POST: Class/Delete/5
        [HttpPost]
        public ActionResult DeletePupil(long id)
        {
            try
            {
                // TODO: Add delete logic here
                _pupilsService.DeletePupil(id);
                return RedirectToAction("Index", "Class");
            }
            catch
            {
                return RedirectToAction("Index", "Class");
            }
        }
    }
}