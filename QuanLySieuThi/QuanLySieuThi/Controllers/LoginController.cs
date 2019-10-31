using Model.DAL;
using Model.Entity;
using QuanLySieuThi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySieuThi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LoginTK(TaiKhoan taiKhoan)
        {
            LoginDAL dal = new LoginDAL();
            User_Role user = new User_Role();
            var rs = dal.LoginTK(taiKhoan);
            var role = user.GetUser(taiKhoan.TenTK);
            if (rs == true)
            {
                Session["User"] = role;
                
                return Json(role, JsonRequestBehavior.AllowGet);
            }
                
            else
                return Json(role, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult LogoutTK()
        {
            Session.Remove("User");
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}