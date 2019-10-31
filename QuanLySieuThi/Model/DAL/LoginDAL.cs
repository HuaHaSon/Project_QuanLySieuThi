using Model.BAL;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAL
{
    
    public class LoginDAL:ILogin
    {
        QuanLySieuThi_DBContext db = new QuanLySieuThi_DBContext();
        public bool LoginTK(TaiKhoan taiKhoan)
        {
            string mk_mahoa = MID5.MaHoa_MK(taiKhoan.MatKhau);
            var rs = db.taiKhoans.Where(s => s.isDeleted == false && s.TenTK == taiKhoan.TenTK && s.MatKhau == mk_mahoa).FirstOrDefault();
            if (rs == null)
                return false;
            else
                return true;
        }       
    }
}
