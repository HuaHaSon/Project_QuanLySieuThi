﻿using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BAL
{
    public interface ILogin
    {
        bool LoginTK(TaiKhoan taiKhoan);
    }
}