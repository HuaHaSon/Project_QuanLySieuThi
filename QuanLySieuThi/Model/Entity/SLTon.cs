using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class SLTon:Base
    {
        public int SoLuong { get; set; }
        public string MaSP { get; set; }
        [ForeignKey("MaSP")]
        public SanPham sanPham { get; set; }
        public string MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCungCap nhaCungCap { get; set; }
    }
}
