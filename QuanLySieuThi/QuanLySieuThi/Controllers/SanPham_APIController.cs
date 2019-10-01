using Model.DAL;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySieuThi.Controllers
{
    [Route("api/v1/sanpham")]
    
    public class SanPham_APIController : ApiController
    {
        private ISanPham ISanPham = new SanPhamDAL();

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            List<SanPham> sanPhams = ISanPham.ListSanPham().Where(e => e.isDeleted == false).ToList();
            return Ok(sanPhams);
        }
        [HttpGet]
        [Route("/{id}")]
        public IHttpActionResult GetById(long id)
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
        public IHttpActionResult Delete(long id)
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
    }
}
