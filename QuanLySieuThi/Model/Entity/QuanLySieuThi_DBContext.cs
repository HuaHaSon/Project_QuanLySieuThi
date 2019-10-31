using Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class QuanLySieuThi_DBContext:DbContext
    {
        public QuanLySieuThi_DBContext():base("name=QuanLySieuThi")
        {

        }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<SanPham_NCC> sanPham_NCCs { get; set; }
        public DbSet<DonGiaNhap> donGiaNhaps { get; set; }
        public DbSet<CTDonGiaNhap> cTDonGiaNhaps { get; set; }
        public DbSet<DonGiaBan> donGiaBans { get; set; }
        public DbSet<CTDonGiaBan> cTDonGiaBans { get; set; }
        public DbSet<PhieuNhap> phieuNhaps { get; set; }
        public DbSet<CTPhieuNhap> CTPhieuNhaps { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<CTHoaDon> cTHoaDons { get; set; }
        public DbSet <TaiKhoan> taiKhoans { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<SLTon> sLTons { get; set; }
        public DbSet<Quyen> quyens { get; set; }
    }
}
