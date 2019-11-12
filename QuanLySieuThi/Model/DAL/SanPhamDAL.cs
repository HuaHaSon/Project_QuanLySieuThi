using Model.DTO;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class SanPhamDAL:ISanPham
    {
        QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();

        public IEnumerable<SanPham> ListSanPham()
        {
            return db.SanPhams.ToList();
        }
        public SanPham GetById(string id)
        {
            return db.SanPhams.Find(id);
        }
        public bool AddSanPham(SanPham sanPham)
        {
            try
            {               
                db.SanPhams.Add(sanPham);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
           
        }
        public bool DeleteSanpham(string id)
        {
            try
            {
                SanPham sanPham = db.SanPhams.Find(id);
                sanPham.isDeleted = true;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<SanPham> SearchSanPham(SanPhamDTO sanPhamDTO)
        {
            var rs = db.SanPhams.Where(s => s.TenSP.Contains(sanPhamDTO.TenSP) && s.MoTa.Contains(sanPhamDTO.MoTa)).ToList();
            return rs;
        }
        public int GetSLTon(string id)
        {
            var rs = db.sLTons.Where(s => db.SanPhams.Where(q => q.id == s.MaSP && q.id==id && s.isDeleted == false).Any()).Select(s=>s.SoLuong).FirstOrDefault();
            return rs;
        }
    }
}
