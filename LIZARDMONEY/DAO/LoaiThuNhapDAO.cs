using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LoaiThuNhapDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public List<LoaiThuNhapDTO> layDSDAO()
        {
            return qlct.LOAITHUNHAP.Select(u => new LoaiThuNhapDTO
            {
                maLoai = u.MaLoaiTN,
                tenThuNhap = u.TenThuNhap,
                trangThai = u.TrangThai.Value
            }).ToList();
        }

        public List<LoaiThuNhapDTO> user_dsLoaiTN()
        {
            return qlct.LOAITHUNHAP.Select(u => new LoaiThuNhapDTO
            {
                maLoai = u.MaLoaiTN,
                tenThuNhap = u.TenThuNhap,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true).ToList();
        }

        public bool ThemLTN(LoaiThuNhapDTO newCT)
        {
            try
            {
                LOAITHUNHAP cat = new LOAITHUNHAP
                {
                    TenThuNhap = newCT.tenThuNhap,
                    TrangThai = true //newSP.trangThai
                };

                qlct.LOAITHUNHAP.Add(cat);
                return qlct.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CapNhatLTN(LoaiThuNhapDTO CapNhat)
        {
            try
            {
                LOAITHUNHAP cat = qlct.LOAITHUNHAP.SingleOrDefault(u => u.MaLoaiTN == CapNhat.maLoai);
                cat.TenThuNhap = CapNhat.tenThuNhap;
                cat.TrangThai = CapNhat.trangThai;
                return qlct.SaveChanges() == 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool XoaLTN(int id)
        {
            try
            {
                LOAITHUNHAP cat = qlct.LOAITHUNHAP.SingleOrDefault(u => u.MaLoaiTN == id);
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
