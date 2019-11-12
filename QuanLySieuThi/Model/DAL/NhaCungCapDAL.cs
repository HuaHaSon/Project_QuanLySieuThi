using Model.BAL;
using Model.DTO;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class NhaCungCapDAL:INhaCungCap
    {
        QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();
        public List<NhaCungCapDTO> GetNCC_SP()
        {
            var rs = (from a in db.SanPhams
                      join b in db.sanPham_NCCs
                      on a.id equals b.MaSP
                      join c in db.NhaCungCaps
                      on b.MaNCC equals c.id
                      where c.isDeleted == false && b.isDeleted == false && c.isDeleted == false
                      select new NhaCungCapDTO
                      {
                          id = b.id,
                          MaSP = a.id,
                          MaNCC = c.id,
                          TenSP = a.TenSP,
                          TenNCC = c.TenNCC
                      }).ToList();
            return rs;
        }
    }
}
