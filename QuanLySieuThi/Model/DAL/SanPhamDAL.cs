using Model.EF;
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

        public List<SanPham> ListSanPham()
        {
            return db.SanPhams.ToList();
        }
        public SanPham GetById(long id)
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
        public bool DeleteSanpham(long id)
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

    }
}
