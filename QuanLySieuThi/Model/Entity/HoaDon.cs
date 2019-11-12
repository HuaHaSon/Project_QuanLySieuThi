using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class HoaDon:Base
    {
        public DateTime NgayHD { get; set; }
        public int TongTien { get; set; }

        public ICollection<CTHoaDon> cTHoaDons { get; set; }
    }
}
