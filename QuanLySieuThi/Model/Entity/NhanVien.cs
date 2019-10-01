using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class NhanVien:Base
    {
        public string TenNV { get; set; }
        public long MaTK { get; set; }
        [ForeignKey("MaTK")]
        public TaiKhoan taiKhoan { get; set; }
    }
}
