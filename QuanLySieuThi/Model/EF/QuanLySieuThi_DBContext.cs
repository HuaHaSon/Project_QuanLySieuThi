using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.EF
{
    public class QuanLySieuThi_DBContext:DbContext
    {
        public QuanLySieuThi_DBContext():base("name=QuanLySieuThi")
        {

        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
    }
}
