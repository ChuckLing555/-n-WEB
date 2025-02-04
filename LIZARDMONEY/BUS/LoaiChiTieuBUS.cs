using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LoaiChiTieuBUS
    {
        LoaiChiTieuDAO lctDAO = new LoaiChiTieuDAO();
        public List<LoaiChiTieuDTO> layDSBUS()
        {
            return lctDAO.layDSDAO();
        }
        public List<LoaiChiTieuDTO> user_dsLoaiCT_BUS()
        {
            return lctDAO.user_dsLoaiCT();
        }
        public bool ThemChiTieu(LoaiChiTieuDTO newSP)
        {
            //var loaiCT = lctDAO.layDSDAO();

            //if(loaiCT.SingleOrDefault(u => u.tenChiTieu == newSP.tenChiTieu) != null) return false;

            return lctDAO.ThemLCT(newSP);
        }
        public bool CapNhatCT(LoaiChiTieuDTO newCT)
        {
            return lctDAO.CapNhatLCT(newCT);
        }
        public bool XoaCT(int id)
        {
            return lctDAO.XoaLCT(id);
        }
    }
}
