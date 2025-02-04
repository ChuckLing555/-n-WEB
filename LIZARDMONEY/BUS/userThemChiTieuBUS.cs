using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class userThemChiTieuBUS
    {
        userThemChiTieuDAO ctDAO = new userThemChiTieuDAO();

        public List<ChiTietGiaoDichDTO> dsChiTieuBUS(int id)
        {
            return ctDAO.dsChiTieu(id);
        }

        public bool themChiTieuBUS(ChiTietGiaoDichDTO chiTieuMoi)
        {
            return ctDAO.themChiTieuDAO(chiTieuMoi);
        }

        public bool xoaChiTieuBUS(int id, int idMaCT)
        {
            return ctDAO.xoaChiTieuDAO(id, idMaCT);
        }

        public bool capNhatChiTieuBUS(int id, int idMaCT, ChiTietGiaoDichDTO chiTieuMoi)
        {
            return ctDAO.capNhatChiTieuDAO(id, idMaCT, chiTieuMoi);
        }
    }
}
