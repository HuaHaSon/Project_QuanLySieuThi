using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class TaiKhoan:Base
    {
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public string MaQuyen { get; set; }
        [ForeignKey("MaQuyen")]
        public Quyen quyen { get; set; }
        public ICollection<NhanVien> nhanViens { get; set; }
    }
}
