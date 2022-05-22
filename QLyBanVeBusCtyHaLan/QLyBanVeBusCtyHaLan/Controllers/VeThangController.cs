using QLyBanVeBusCtyHaLan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLyBanVeBusCtyHaLan.Controllers
{
    public class VeThangController : Controller
    {
        // GET: VeThang
        public ActionResult Index()
        {
            var listVeThang = new DBContext().VeThangs.ToList();
            return View(listVeThang);
        }

        // GET: VeThang/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VeThang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VeThang/Create
        [HttpPost]
        public ActionResult Create(VeThang model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBContext();
                context.VeThangs.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VeThang/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VeThang/Edit/5
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

        // GET: VeThang/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VeThang/Delete/5
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
