using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiThuNhapBUS
    {
        LoaiThuNhapDAO ltnDAO = new LoaiThuNhapDAO();
        public List<LoaiThuNhapDTO> layDSBUS()
        {
            return ltnDAO.layDSDAO();
        }

        public List<LoaiThuNhapDTO> user_dsLoaiTN_BUS()
        {
            return ltnDAO.user_dsLoaiTN();
        }
        public bool ThemThuNhap(LoaiThuNhapDTO newSP)
        {
            //var loaiTN = ltnDAO.layDSDAO();

            //if (loaiTN.SingleOrDefault(u => u.tenThuNhap == newSP.tenThuNhap) != null) return false;

            return ltnDAO.ThemLTN(newSP);
        }
        public bool CapNhatTN(LoaiThuNhapDTO newCT)
        {
            return ltnDAO.CapNhatLTN(newCT);
        }
        public bool XoaTN(int id)
        {
            return ltnDAO.XoaLTN(id);
        }
    }
}
