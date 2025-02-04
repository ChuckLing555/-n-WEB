using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using DAO;

namespace BUS
{
    public class userReportBUS
    {
        userReportDAO repDAO = new userReportDAO();

        public List<ReportGiaoDichDTO> dsChiTieuBUS(int id)
        {
            return repDAO.dsChiTieuDAO(id);
        }

        public List<ReportGiaoDichDTO> dsChiTieuTheoLoaiCTBUS(int id, int maLoaiCT)
        {
            return repDAO.dsChiTieuTheoLoaiCTDAO(id, maLoaiCT);
        }

        public List<ReportGiaoDichDTO> dsChiTieuTheoLoaiVTBUS(int id, int maTaiKhoan)
        {
            return repDAO.dsChiTieuTheoLoaiVTDAO(id, maTaiKhoan);
        }

        public List<ReportGiaoDichDTO> dsThuNhapBUS(int id)
        {
            return repDAO.dsThuNhapDAO(id);
        }

        public List<ReportGiaoDichDTO> dsThuNhapTheoLoaiTNBUS(int id, int maLoaiTN)
        {
            return repDAO.dsThuNhapTheoLoaiTNDAO(id, maLoaiTN);
        }

        public List<ReportGiaoDichDTO> dsThuNhapTheoLoaiVTBUS(int id, int maTaiKhoan)
        {
            return repDAO.dsThuNhapTheoLoaiVTDAO(id, maTaiKhoan);
        }

        public List<ReportVayTraDTO> dsKhoanChoVayBUS(int id)
        {
            return repDAO.dsKhoanChoVayDAO(id);
        }

        public List<ReportVayTraDTO> dsKhoanChoVayTheoLoaiVTBUS(int id, int maTaiKhoan)
        {
            return repDAO.dsKhoanChoVayTheoLoaiVTDAO(id, maTaiKhoan);
        }

        public List<ReportVayTraDTO> dsKhoanBiNoBUS(int id)
        {
            return repDAO.dsKhoanBiNoDAO(id);
        }

        public List<ReportVayTraDTO> dsKhoanBiNoTheoLoaiVTBUS(int id, int maTaiKhoan)
        {
            return repDAO.dsKhoanBiNoTheoLoaiVTDAO(id, maTaiKhoan);
        }
    }
}
