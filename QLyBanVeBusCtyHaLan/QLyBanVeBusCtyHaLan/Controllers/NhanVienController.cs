using QLyBanVeBusCtyHaLan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLyBanVeBusCtyHaLan.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            var listNhanVien = new DBContext().NhanViens.ToList();
            return View(listNhanVien);
        }

        // GET: NhanVien/Details/5
       
        // GET: NhanVien/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBContext();
                context.NhanViens.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new DBContext();
            var editing = context.NhanViens.Find(id);
             
            return View(editing);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBContext();
                var oldItem = context.NhanViens.Find(model.id);
                oldItem.tenNV = model.tenNV;
                oldItem.ngaysinh = model.ngaysinh;
                oldItem.gioitinh = model.gioitinh;
                oldItem.diachi = model.diachi;
                oldItem.cmnd = model.cmnd;
                oldItem.sdt = model.sdt;
                oldItem.chucvu = model.chucvu;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new DBContext();
            var deleting = context.NhanViens.Find(id);

            return View(deleting);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, NhanVien model)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new DBContext();
                var deleting = context.NhanViens.Find(id);
                context.NhanViens.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
