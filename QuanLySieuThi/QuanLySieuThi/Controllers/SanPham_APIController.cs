using Model.DAL;
using Model.DTO;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySieuThi.Controllers
{
    [RoutePrefix("api/sanpham")]

    public class SanPham_APIController : ApiController
    {
        private ISanPham ISanPham = new SanPhamDAL();

        [HttpGet]
        [Authorize]
        [Route("GetAll")] 
        public IHttpActionResult GetAll()
        {            
                List<SanPham> sanPhams = ISanPham.ListSanPham().Where(e => e.isDeleted == false).ToList();
                return Ok(sanPhams);        
        }
        [HttpGet]
        [Route("GetById")]
        public IHttpActionResult GetById(string id)
        {
            SanPham sanPham = ISanPham.GetById(id);
            return Ok(sanPham);
        }
        [HttpPost]      
        public IHttpActionResult Add([FromBody] SanPham sanPham)
        {
            bool rs = ISanPham.AddSanPham(sanPham);
            if (rs)
            {
                return Ok("Thêm sản phẩm thành công !");
            }
            else
            {
                return Ok("Đã xảy ra lỗi !");
            }
        }
        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            bool rs = ISanPham.DeleteSanpham(id);
            if (rs)
            {
                return Ok("Xóa sản phẩm thành công!");
            }
            else
            {
                return Ok("Đã xảy ra lỗi!");
            }
        }
        [HttpPost]
        [Route("Search")]
        [Authorize]
        public IHttpActionResult Search(SanPhamDTO sanPhamDTO)
        {
            var rs = ISanPham.SearchSanPham(sanPhamDTO).Where(s=>s.isDeleted==false);
            return Ok(rs);
        }

        [HttpPost]
        [Authorize]
        [Route("GetSLTon/{id}")]
        public IHttpActionResult SLTon(string id)
        {
            var rs = ISanPham.GetSLTon(id);
            return Ok(rs);
        }
    }
}
