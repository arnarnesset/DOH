using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOH.Controllers
{
    public class AntiForgeryController : Controller
    {
        // GET: AntiForgery
        public ActionResult Index()
        {
            return View();
        }

        // GET: AntiForgery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AntiForgery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AntiForgery/Create
        // Authorize slipper kun brukere med Admin-rollen inn
        // ValidateAntiForgeryToken sammen med @Html.AntiForgeryToken() i viewet sikrer at kun forms fra samme server blir prosessert
        [HttpPost]
        [Authorize(Roles ="Admin")]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AntiForgery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AntiForgery/Edit/5
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

        // GET: AntiForgery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AntiForgery/Delete/5
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
