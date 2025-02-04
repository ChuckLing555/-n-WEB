using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class userDangKyBUS
    {
        userDangKyDAO nguoiDungDAO = new userDangKyDAO();
        public bool dangKyBUS(NguoiDungDTO nguoiDungMoi)
        {
            return nguoiDungDAO.dangKyDAO(nguoiDungMoi);
        }
    }
}
