using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLyBanVeBusCtyHaLan.Models
{
    public class LoaiVeController : Controller
    {
        // GET: LoaiVe
        public ActionResult Index()
        {
            var listLoaiVe = new DBContext().LoaiVes.ToList();
            return View(listLoaiVe);
        }

        // GET: LoaiVe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoaiVe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiVe/Create
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

        // GET: LoaiVe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoaiVe/Edit/5
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

        // GET: LoaiVe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoaiVe/Delete/5
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
