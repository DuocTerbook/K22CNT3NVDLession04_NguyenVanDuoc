using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVD_lession04.Controllers
{
    /// <summary>
    /// Athor: Nguyễn Văn Được
    /// Class: K22CNT3
    /// </summary>
    public class NVDStudentController : Controller
    {
        // GET: NVDStudent
        public ActionResult Index()
        {
            // Truyền dữ liệu từ controller -> view
            ViewBag.fullName = "Nguyễn Văn Được";
            ViewData["Birthday"] = "25/10/2004";
            TempData["Phone"] = "0966536276";
            return View();
        }
        public ActionResult Details()
        {
            string NVDStr = "";
            NVDStr += "<h3>Họ và tên: Nguyễn Văn Được</h3>";
            NVDStr += "<p> Mã sinh viên: 2210900016";
            NVDStr += "<p> Địa chỉ mail: nguyenvanduoc09665362766276@gmail.com";
            ViewBag.Details = NVDStr; 
            return View("chiTiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }
        //HTMLHelper
        // GET: NVDStudent/AddNewStudent
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            //Lấy dữ liệu trên form
            string fullName = form["fullName"];
            string Masv = form["Masv"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];
            string NVDStr = "<h3>" + fullName + "</h3>";
            NVDStr += "<p>" + Masv;
            NVDStr += "<p>" + TaiKhoan;
            NVDStr += "<p>" + MatKhau;
            ViewBag.info = NVDStr;
            return View("Ketqua");
        }
    }
}