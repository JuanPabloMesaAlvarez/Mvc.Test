using MvcTutorial.Web.Models;
using MvcTutorial.Web.Utils.Statics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly CoursesRepository repo;

        public CourseController()
        {
            repo = new CoursesRepository();
        }

        // GET: Course
        public ActionResult Index()
        {
            return View(repo.Courses);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.Courses.First(c => c.CourseId == id));
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        public ActionResult Create(Course collection)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    collection.CourseId = repo.Courses.Max(f => f.CourseId) + 1;
                    repo.Courses.Add(collection);
                    return RedirectToAction("Index");
                }

                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Course/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
