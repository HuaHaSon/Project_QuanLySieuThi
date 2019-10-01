using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class CTHoaDon:Base
    {
        public long MaHD { get; set; }
        [ForeignKey("MaHD")]
        public HoaDon hoaDon { get; set; }
        public long MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham sanPham { get; set; }
        public long MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCungCap nhaCungCap { get; set; }
        public int SLBan { get; set; }
    }
}
