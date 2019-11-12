using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class CTDonGiaBan : Base
    {
        public string MaDonGiaBan { get; set; }
        [ForeignKey("MaDonGiaBan")]
        public DonGiaBan donGiaBan { get; set; }
        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham sanPham { get; set; }
        public int GiaBan { get; set; }
    }
}
