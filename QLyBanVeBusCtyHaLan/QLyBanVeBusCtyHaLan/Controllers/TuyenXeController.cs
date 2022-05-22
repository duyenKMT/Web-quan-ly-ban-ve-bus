using QLyBanVeBusCtyHaLan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLyBanVeBusCtyHaLan.Controllers
{
    public class TuyenXeController : Controller
    {
        // GET: TuyenXe
        public ActionResult Index()
        {
            var listTuyenXe= new DBContext().TuyenXes.ToList();
            return View(listTuyenXe);
        }

        // GET: TuyenXe/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TuyenXe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TuyenXe/Create
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

        // GET: TuyenXe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TuyenXe/Edit/5
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

        // GET: TuyenXe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TuyenXe/Delete/5
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
