using Model.BAL;
using Model.DAL;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySieuThi.Controllers
{
    [RoutePrefix("api/hoadon")]
    public class HoaDon_APIController : ApiController
    {
        private IHoaDon IHoaDon = new HoaDonDAL();

        [HttpGet]
        [Authorize]
        [Route("GetAll")]
        public IHttpActionResult GetAll()
        {
            var rs = IHoaDon.ListHoaDon();
            return Ok(rs);
        }
        [HttpPost]
        [Authorize]
        [Route("CTHoaDon/{id}")]
        public IHttpActionResult ListCTHD(string id)
        {
            var rs = IHoaDon.CTHoaDon(id);
            return Ok(rs);
        }
        [HttpPost]
        [Authorize]
        [Route("Search")]
        public IHttpActionResult SearchHD(DateTime ngayhd)
        {
            var rs = IHoaDon.Search(ngayhd);
            return Ok(rs);
        }
        //[HttpPost]
        //[Authorize]
        //[Route("GiaBan/{id}")]
        //public IHttpActionResult GiaBan(string id)
        //{
        //    var rs = IHoaDon.GiaBan(id);
        //    return Ok(rs);
        //}
        [HttpPost]
        [Authorize]
        [Route("ListCTHD/{id}")]
        public IHttpActionResult List_CTHD(string id)
        {
            var rs = IHoaDon.ListCTHD(id);
            return Ok(rs);
        }
    }
}
