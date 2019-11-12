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
        public string MaPN { get; set; }
        [ForeignKey("MaPN")]
        public PhieuNhap phieuNhap { get; set; }
        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham sanPham { get; set; }
        public int SLNhap { get; set; }
    }
}
