using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NguoiDungBUS
    {
        NguoiDungDAO qlctDAO = new NguoiDungDAO();
        public List<NguoiDungDTO> layDSBUS()
        {
            return qlctDAO.layDSDAO();
        }
        public List<NguoiDungDTO>  LayDSTen(string tenDangNhap)
        {
            return qlctDAO.layDSTen(tenDangNhap);
        }
        public List<NguoiDungDTO> LayDSEmail(string email)
        {
            return qlctDAO.layDSEmail(email);
        }
        public List<NguoiDungDTO> LayDSHoTen(string hoTen)
        {
            return qlctDAO.layDSHoTen(hoTen);
        }
        public List<NguoiDungDTO> LayDSHOATDONG(bool hoatDong) 
        {
            return qlctDAO.layDSHoatDong(hoatDong);
        }

        public bool capNhatTTNDBUS(int id, NguoiDungDTO nd)
        {
            return qlctDAO.capNhatThongTinND(id, nd);
        }

        public bool xoaNDBUS(int id)
        {
            return qlctDAO.xoaTaiKhoanDAO(id);
        }
        public string KiemTraMK(int idNguoiDung)
        {
            return qlctDAO.ktMKDAO(idNguoiDung);
        }
    }
}
