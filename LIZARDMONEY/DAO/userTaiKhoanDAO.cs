using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userTaiKhoanDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();

        public List<TaiKhoanDTO> dsTaiKhoanDAO(int id)
        {
            return qlct.TAIKHOAN.Select(u => new TaiKhoanDTO
            {
                maNguoiDung = u.ID,
                maTaiKhoan = u.MaTaiKhoan,
                tenTaiKhoan = u.TenTaiKhoan,
                soTien = (float)u.SoTien,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }
        // thêm xóa sửa cần truy xuất id người dùng
        public bool themTaiKhoanDAO(TaiKhoanDTO tkMoi)
        {
            try
            {
                TAIKHOAN tk = new TAIKHOAN
                {
                    ID = tkMoi.maNguoiDung,
                    TenTaiKhoan = tkMoi.tenTaiKhoan,
                    SoTien = tkMoi.soTien,
                    GhiChu = tkMoi.ghiChu,
                    TrangThai = true
                };

                qlct.TAIKHOAN.Add(tk);
                qlct.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool xoaTaiKhoanDAO(int maNguoiDung, int maTaiKhoan)
        {
            try
            {
                TAIKHOAN tk = qlct.TAIKHOAN.SingleOrDefault(u => u.ID == maNguoiDung && u.MaTaiKhoan == maTaiKhoan);
                tk.TrangThai = false;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool capNhatTaiKhoanDAO(int maNguoiDung, int maTaiKhoan, TaiKhoanDTO tkMoi)
        {
            try
            {
                TAIKHOAN tk = qlct.TAIKHOAN.SingleOrDefault(u => u.ID == maNguoiDung && u.MaTaiKhoan == maTaiKhoan);
                tk.TenTaiKhoan = tkMoi.tenTaiKhoan;
                tk.SoTien = tkMoi.soTien;
                tk.GhiChu = tkMoi.ghiChu;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
