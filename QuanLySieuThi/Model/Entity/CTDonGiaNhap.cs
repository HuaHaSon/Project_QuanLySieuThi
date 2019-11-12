using Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class CTDonGiaNhap:Base
    {
        public string MaPhieuGiaNhap { get; set; }
        [ForeignKey("MaPhieuGiaNhap")]
        public DonGiaNhap donGiaNhap { get; set; }

        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham sanPham { get; set; }
        public int GiaNhap { get; set; }

    }
}
