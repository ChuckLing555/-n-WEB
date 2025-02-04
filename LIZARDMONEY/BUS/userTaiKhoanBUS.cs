using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class userTaiKhoanBUS
    {
        userTaiKhoanDAO tkDAO = new userTaiKhoanDAO();

        public List<TaiKhoanDTO> dsTaiKhoanBUS(int id)
        {
            return tkDAO.dsTaiKhoanDAO(id);
        }

        public bool themTaiKhoanBUS(TaiKhoanDTO taiKhoanMoi)
        {
            return tkDAO.themTaiKhoanDAO(taiKhoanMoi);
        }

        public bool xoaTaiKhoanBUS(int id, int idMaTK)
        {
            return tkDAO.xoaTaiKhoanDAO(id, idMaTK);
        }

        public bool capNhatTaiKhoanBUS(int id, int idMaTK, TaiKhoanDTO tkMoi)
        {
            return tkDAO.capNhatTaiKhoanDAO(id, idMaTK, tkMoi);
        }
    }
}
