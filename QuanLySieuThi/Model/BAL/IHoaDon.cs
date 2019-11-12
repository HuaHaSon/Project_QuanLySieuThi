using Model.DTO;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BAL
{
    public interface IHoaDon
    {
        List<HoaDon> ListHoaDon();
        
        List<CTHoaDon> CTHoaDon(string id);
        List<HoaDon> Search(DateTime ngayhd);
        //int  GiaBan(string masp);
        List<CTHoaDonDTO> ListCTHD(string id);

    }
}
