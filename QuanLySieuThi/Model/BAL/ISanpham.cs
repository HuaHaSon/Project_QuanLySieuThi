using Model.DTO;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public interface ISanPham
    {
        IEnumerable<SanPham> ListSanPham();
        SanPham GetById(string id);
        bool AddSanPham(SanPham sanPham);
        bool DeleteSanpham(string id);
        List<SanPham> SearchSanPham(SanPhamDTO sanPhamDTO);
       int GetSLTon(string id);

    }
}
