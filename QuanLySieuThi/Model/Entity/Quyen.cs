using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Quyen:Base
    {
        public string TenQuyen { get; set; }
        public ICollection<TaiKhoan> taiKhoans { get; set; }
    }
}
