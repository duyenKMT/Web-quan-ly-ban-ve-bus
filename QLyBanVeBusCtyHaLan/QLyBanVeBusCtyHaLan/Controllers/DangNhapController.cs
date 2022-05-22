using QLyBanVeBusCtyHaLan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLyBanVeBusCtyHaLan.Controllers
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult NguoiDung()
        {

            var listNguoiDung = new DBContext().NguoiDungs.ToList();
            return View(listNguoiDung);
        }

        public RedirectResult Dieuhuong(string tendn, string mk)
        {
            string trangtrave = "";
            var obj = new DBContext().NguoiDungs.ToList();
            //Kiểm tra 2 ô text có rỗng k, k rỗng mới tìm
            if (!string.IsNullOrEmpty(tendn) && !string.IsNullOrEmpty(mk))
            {
                obj = obj.Where(x => x.tendangnhap.Contains(tendn)).ToList(); //truy vấn so sánh tên đăng nhập với list trong csdl
                obj = obj.Where(x => x.matkhau.Contains(mk)).ToList();

                if (obj.Count == 0)
                {
                    //đăng nhập thất bại
                    trangtrave = "/DangNhap/Index";
                    TempData["kq"] = "Vui lòng kiểm tra lại thông tin đăng nhập!";
                    TempData.Keep("kq");
                }
                else
                {
                    //đăng nhập thành công
                    trangtrave = "/BaoCaoBanVe/Index";
                }
            }
            else
            {
                //đăng nhập thất bại
                trangtrave = "/DangNhap/Index";
                TempData["kq"] = "Vui lòng điền thông tin đăng nhập!";
                TempData.Keep("kq");
            }
            return Redirect(trangtrave);
        }
    }
}