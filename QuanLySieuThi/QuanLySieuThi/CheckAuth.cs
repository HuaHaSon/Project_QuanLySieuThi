using Model.DAL;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySieuThi
{
    public class CheckAuth
    {
      
        public static bool CheckExist(string username,string password)
        {
            QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();
            var mahoa_mk = MD5.MaHoa_MK(password);
            var rs = db.taiKhoans.Where(s => s.MatKhau ==  mahoa_mk && s.TenTK==username &&s.isDeleted == false).FirstOrDefault();
            return rs != null ? true : false;
        }
        public static string CheckRole(string username)
        {
            QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();
            var rs = db.quyens.Where(s => db.taiKhoans.Where(r => r.MaQuyen == s.id && r.TenTK == username && r.isDeleted == false).Any()).Select(s=>s.TenQuyen).FirstOrDefault();
            return rs == null ? "NoRole" : rs;
        }
    }
}