using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class userThemThuNhapBUS
    {
        userThemThuNhapDAO tnDAO = new userThemThuNhapDAO();

        public List<ChiTietGiaoDichDTO> dsThuNhapBUS(int id)
        {
            return tnDAO.dsThuNhap(id);
        }

        public bool themThuNhapBUS(ChiTietGiaoDichDTO thuNhapMoi)
        {
            return tnDAO.themThuNhapDAO(thuNhapMoi);
        }

        public bool xoaThuNhapBUS(int id, int idMaTN)
        {
            return tnDAO.xoaThuNhapDAO(id, idMaTN);
        }

        public bool capNhatThuNhapBUS(int id, int idMaTN, ChiTietGiaoDichDTO thuNhapMoi)
        {
            return tnDAO.capNhatThuNhapDAO(id, idMaTN, thuNhapMoi);
        }
    }
}
