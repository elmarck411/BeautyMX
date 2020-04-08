using BeautyMX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautyMX.Controllers
{
    public class BottleRequestsController : Controller
    {
        // GET: BottleRequests
        public ActionResult Index()
        {
            List<_BottleRequest> bottleRequests = new List<_BottleRequest>();
            return View(bottleRequests);
        }

        // GET: BottleRequests/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BottleRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BottleRequests/Create
        [HttpPost]
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

        // GET: BottleRequests/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BottleRequests/Edit/5
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

        // GET: BottleRequests/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BottleRequests/Delete/5
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
