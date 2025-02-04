using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class LoaiChiTieuDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public List<LoaiChiTieuDTO> layDSDAO()
        {
            return qlct.LOAICHITIEU.Select(u => new LoaiChiTieuDTO
            {
                maLoai = u.MaLoaiCT,
                tenChiTieu = u.TenChiTieu,
                trangThai = u.TrangThai.Value
            }).ToList();
        }

        public List<LoaiChiTieuDTO> user_dsLoaiCT()
        {
            return qlct.LOAICHITIEU.Select(u => new LoaiChiTieuDTO
            {
                maLoai = u.MaLoaiCT,
                tenChiTieu = u.TenChiTieu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true).ToList();
        }

        public bool ThemLCT(LoaiChiTieuDTO newCT)
        {
            try
            {
                LOAICHITIEU cat = new LOAICHITIEU
                {
                    TenChiTieu = newCT.tenChiTieu,
                    TrangThai = true //newSP.trangThai
                };

                qlct.LOAICHITIEU.Add(cat);
                return qlct.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }

       public bool CapNhatLCT(LoaiChiTieuDTO CapNhat)
        {
            try
            {
                LOAICHITIEU cat = qlct.LOAICHITIEU.SingleOrDefault(u => u.MaLoaiCT == CapNhat.maLoai);
                cat.TenChiTieu = CapNhat.tenChiTieu;
                cat.TrangThai = CapNhat.trangThai;
                return qlct.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaLCT(int id)
        {
            try
            {
                LOAICHITIEU cat = qlct.LOAICHITIEU.SingleOrDefault(u => u.MaLoaiCT == id);
                cat.TrangThai = false;
                return qlct.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
