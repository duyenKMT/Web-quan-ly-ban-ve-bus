using QLyBanVeBusCtyHaLan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLyBanVeBusCtyHaLan.Controllers
{
    public class BaoCaoBanVeController : Controller
    {
        // GET: BaoCaoBanVe
        public ActionResult Index()
        {
            var listBaoCao= new DBContext().BaoCaoBanVes.ToList();
            return View(listBaoCao);
        }

        // GET: BaoCaoBanVe/Details/5
        public ActionResult Details(int id)
        {
            var context = new DBContext().ChiTietBaoCaos.ToList();

            return View(context);
        }
      

        // GET: BaoCaoBanVe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaoCaoBanVe/Create
        [HttpPost]
        public ActionResult Create(BaoCaoBanVe model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBContext();
                context.BaoCaoBanVes.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BaoCaoBanVe/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BaoCaoBanVe/Edit/5
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

        // GET: BaoCaoBanVe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BaoCaoBanVe/Delete/5
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
