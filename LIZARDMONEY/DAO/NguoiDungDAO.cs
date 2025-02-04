using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class NguoiDungDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();

        public List<NguoiDungDTO> layDSDAO()
        {
            return qlct.NGUOIDUNG.Select(u => new NguoiDungDTO
            {
                tenDangNhap = u.TenDangNhap,
                matKhau = u.MatKhau,
                hoTen = u.HoTen,
                email = u.Email,
                trangThai = u.TrangThai.Value
            }).ToList();
        }
        public List<NguoiDungDTO> layDSTen(string tenDangNhap)
        {
            return qlct.NGUOIDUNG
                //Điều kiện lấy ra thông tin tương tự
               .Where(u => u.TenDangNhap.Contains(tenDangNhap))
               .Select(u => new NguoiDungDTO
               {
                   tenDangNhap = u.TenDangNhap,
                   matKhau = u.MatKhau,
                   hoTen = u.HoTen,
                   email = u.Email,
                   trangThai = u.TrangThai.Value
               }).ToList();
        }
        public List<NguoiDungDTO> layDSEmail(string email)
        {
            return qlct.NGUOIDUNG
               .Where(u => u.Email.Contains(email))
               .Select(u => new NguoiDungDTO
               {
                   tenDangNhap = u.TenDangNhap,
                   matKhau = u.MatKhau,
                   hoTen = u.HoTen,
                   email = u.Email,
                   trangThai = u.TrangThai.Value
               }).ToList();
        }
        public List<NguoiDungDTO> layDSHoTen(string hoTen)
        {
            return qlct.NGUOIDUNG
               .Where(u => u.HoTen.Contains(hoTen))
               .Select(u => new NguoiDungDTO
               {
                   tenDangNhap = u.TenDangNhap,
                   matKhau = u.MatKhau,
                   hoTen = u.HoTen,
                   email = u.Email,
                   trangThai = u.TrangThai.Value
               }).ToList();
        }
        public List<NguoiDungDTO> layDSHoatDong(bool hoatDong)
        {
            if (hoatDong == true)
                return qlct.NGUOIDUNG
                   .Select(u => new NguoiDungDTO
                   {
                       tenDangNhap = u.TenDangNhap,
                       matKhau = u.MatKhau,
                       hoTen = u.HoTen,
                       email = u.Email,
                       trangThai = u.TrangThai.Value
                   }).Where(u => u.trangThai == true).ToList();
            else
            {
                return qlct.NGUOIDUNG
                   .Select(u => new NguoiDungDTO
                   {
                       tenDangNhap = u.TenDangNhap,
                       matKhau = u.MatKhau,
                       hoTen = u.HoTen,
                       email = u.Email,
                       trangThai = u.TrangThai.Value
                   }).Where(u => u.trangThai == false).ToList();
            }
        }

        public bool capNhatThongTinND(int maNguoiDung, NguoiDungDTO nguoiDung)
        {
            try
            {

                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.ID == maNguoiDung);
                nd.HoTen = nguoiDung.hoTen;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool xoaTaiKhoanDAO(int maNguoiDung)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.ID == maNguoiDung);
                nd.TrangThai = false;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string ktMKDAO(int maNguoiDung)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.ID == maNguoiDung);
                if (nd != null)
                {
                    return nd.MatKhau;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
