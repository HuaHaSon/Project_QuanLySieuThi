using Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class DonGiaNhap:Base
    {
        public string MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCungCap nhaCungCap { get; set; }
        public DateTime NgayApDung { get; set; }
        public ICollection<CTDonGiaNhap> cTDonGiaNhaps { get; set; }
    }
}
