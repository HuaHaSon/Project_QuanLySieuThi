using Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class NhaCungCap:Base
    {  
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public ICollection<SanPham_NCC> sanPham_NCCs { get; set; }
        public ICollection<DonGiaNhap> donGiaNhaps { get; set; }
        public ICollection<PhieuNhap> phieuNhaps { get; set; }
        public ICollection<CTHoaDon> cTHoaDons { get; set; }
        public ICollection<SLTon> sLTons { get; set; }
    }
}
