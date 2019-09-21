using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySieuThi.Controllers
{
    public class SanPham_APIController : ApiController
    {
        private QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();
        [HttpGet]
        public IEnumerable<SanPham> GetAll()
        {
            var list = db.SanPhams.ToList();
            return list;
        }
    }
}
