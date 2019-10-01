using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public interface ISanPham
    {
        List<SanPham> ListSanPham();
        SanPham GetById(long id);
        bool AddSanPham(SanPham sanPham);
        bool DeleteSanpham(long id);

    }
}
