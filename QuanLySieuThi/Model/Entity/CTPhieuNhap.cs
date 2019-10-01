using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class CTPhieuNhap:Base
    {
        public long MaPN { get; set; }
        [ForeignKey("MaPN")]
        public PhieuNhap phieuNhap { get; set; }
        public long MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham sanPham { get; set; }
        public int SLNhap { get; set; }
    }
}
