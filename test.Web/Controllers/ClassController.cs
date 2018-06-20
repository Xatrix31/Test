﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models.Interfaces;

namespace test.Web.Controllers
{
    public class ClassController : Controller
    {
        private readonly IPupilsService _pupilsService;

        public ClassController(IPupilsService pupilsService)
        {
            _pupilsService = pupilsService;
        }

        // GET: Class
        public ActionResult Index(long id)
        {
            return View();
        }

        // GET: Class/Create
        public ActionResult CreatePupil()
        {
            return View();
        }

        // POST: Class/Create
        [HttpPost]
        public ActionResult CreatePupil(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {

                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Class/Edit/5
        public ActionResult EditPupil(long id)
        {
            return View();
        }

        // POST: Class/Edit/5
        [HttpPost]
        public ActionResult EditPupil(long id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: Class/Delete/5
        [HttpPost]
        public ActionResult DeletePupil(long id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
