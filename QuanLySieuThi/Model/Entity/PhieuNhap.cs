using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class PhieuNhap:Base
    {
        public DateTime NgayPN { get; set; }
        public int TongTien { get; set; }
        public long MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCungCap nhaCungCap { get; set; }
        public ICollection<CTPhieuNhap > cTPhieuNhaps { get; set; }

    }
}
