using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLySieuThi.Models
{
    public class User_Role
    {
        QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();
        public SessionUser GetUser(string tk)
        {
            var rs = (from a in db.taiKhoans
                      join b in db.quyens
                     on a.MaQuyen equals b.id
                      where a.TenTK == tk && b.isDeleted == false
                      select new SessionUser
                      {
                          TenTK = a.TenTK,
                          TenQuyen = b.TenQuyen
                      }).FirstOrDefault();
            return rs;
        }
    }
}