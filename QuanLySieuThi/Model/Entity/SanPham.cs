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
    public class SanPham: Base
    {
        public string TenSP { get; set; }
        public string MoTa { get; set; }
        public ICollection<SanPham_NCC> sanPham_NCCs { get; set; }
        public ICollection<CTDonGiaNhap> cTDonGiaNhaps { get; set; }
        public ICollection<CTPhieuNhap> cTPhieuNhaps { get; set; }
        public ICollection<CTHoaDon> cTHoaDons { get; set; }
        public ICollection<CTDonGiaBan> cTDonGiaBans { get; set; }
       
    }
}
