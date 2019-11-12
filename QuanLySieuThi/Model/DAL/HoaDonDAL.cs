using Model.BAL;
using Model.DTO;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    public class HoaDonDAL:IHoaDon
    {
        QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();
        public List<HoaDon> ListHoaDon()
        {
            var rs = db.hoaDons.Where(s => s.isDeleted == false).OrderByDescending(s => s.NgayHD).ToList();
            return rs;
        }
        public List<CTHoaDon> CTHoaDon(string id)
        {
            var rs = db.cTHoaDons.Where(s => db.hoaDons.Where(q => q.id == s.MaHD && s.isDeleted == false && s.MaHD==id).Any()).OrderByDescending(s=>s.createdDate).ToList();
            return rs;
        }
        public List<HoaDon> Search(DateTime ngayhd)
        {
            var ngay = DateTime.ParseExact(ngayhd.ToString("dd/MM/yyyy"), "MM/dd/yyyy", null);
            var rs = db.hoaDons.Where(s => s.NgayHD == ngay).OrderByDescending(s => s.NgayHD).ToList();
            return rs;
        }
        //public int GiaBan(string masp)
        //{
        //    var rs = db.cTDonGiaBans.Where(s => s.MaSP == masp && s.isDeleted == false).OrderByDescending(s => s.createdDate).Select(s=>s.GiaBan).FirstOrDefault();
        //    return rs;
        //}
        public List<CTHoaDonDTO> ListCTHD(string mahd)
        {
            var cTHoaDonDTOs = new List<CTHoaDonDTO>();
            string sqlconnectStr = ConfigurationManager.ConnectionStrings["QuanLySieuThi"].ConnectionString;
            SqlConnection connection = new SqlConnection(sqlconnectStr);
            connection.Open();

            string queryString = "select cthd.MaSP,cthd.SLBan,(select TOP 1 ctdg.GiaBan from CTDonGiaBans ctdg, DonGiaBans dg where cthd.MaSP = ctdg.MaSP and ctdg.MaDonGiaBan = dg.id and ctdg.isDeleted = 'false' and hd.NgayHD >= dg.NgayApDung order by ctdg.createdDate desc)from CTHoaDons cthd,HoaDons hd where cthd.MaHD = @mahd and cthd.MaHD = hd.id;";
            using (SqlCommand cmd = new SqlCommand(queryString, connection))
            {
                // Thiết lập tham số cmd cmd.Parameters nếu cần thiết
                cmd.Parameters.AddWithValue("@mahd", mahd);
                // Thi hành lệnh  (như ) cmd.ExecuteNonQuery();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Đọc kết quả
                        while (reader.Read())
                        {
                            //Console.WriteLine("{0}\t{1}", reader[0].ToString(), reader.GetString(1));
                            //Console.WriteLine("{0}\t{1}", reader[1].ToString(), reader.GetString(1));
                            //Console.WriteLine("{0}\t{1}", reader[2].ToString(), reader.GetString(1));
                            //Console.WriteLine("-----------------------");
                            CTHoaDonDTO cTHoaDonDTO = new CTHoaDonDTO();
                            cTHoaDonDTO.MaSP = reader[0].ToString();
                            cTHoaDonDTO.SLBan = Convert.ToInt32(reader[1].ToString());
                            cTHoaDonDTO.DonGia = Convert.ToInt32(reader[2].ToString());
                            cTHoaDonDTOs.Add(cTHoaDonDTO);
                        }
                    }
                    else Console.WriteLine("No rows found.");
                }
                connection.Close();
            }


            return cTHoaDonDTOs;
        }
    } 
}
