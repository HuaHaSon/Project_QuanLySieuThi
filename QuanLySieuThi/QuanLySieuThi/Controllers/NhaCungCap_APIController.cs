using Model.BAL;
using Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLySieuThi.Controllers
{
    [RoutePrefix("api/nhacungcap")]
    public class NhaCungCap_APIController : ApiController
    {
        private INhaCungCap INhaCungCap = new NhaCungCapDAL();


        [HttpGet]
        [Authorize]
        [Route("GetNCC_SP")]
        public IHttpActionResult GetNCC_SP()
        {
            var rs = INhaCungCap.GetNCC_SP();
            return Ok(rs);
        }
        
    }
}
