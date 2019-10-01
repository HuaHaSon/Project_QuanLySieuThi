using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class DonGiaBan:Base
    {
        public DateTime NgayApDung { get; set; }
        public ICollection<CTDonGiaBan> cTDonGiaBans { get; set; }
    }
}
