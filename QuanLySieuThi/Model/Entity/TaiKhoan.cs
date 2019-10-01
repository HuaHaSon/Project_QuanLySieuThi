using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class TaiKhoan:Base
    {
        public string TenTK { get; set; }
        public long MatKhau { get; set; }
        public ICollection<NhanVien> nhanViens { get; set; }
    }
}
