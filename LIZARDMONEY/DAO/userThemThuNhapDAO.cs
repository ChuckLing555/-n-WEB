using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userThemThuNhapDAO
    {

        QLCT_LIZARDett qlct = new QLCT_LIZARDett(); 
        public List<ChiTietGiaoDichDTO> dsThuNhap(int id)
        {
            return qlct.CHITIETTHUNHAP.Select(u => new ChiTietGiaoDichDTO
            {
                maGD = (int)u.MaTN,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                maLoaiGD = (int)u.MaLoaiTN,// lấy ra tên loại giao dịch/ chi tiêu
                soTien = (float)u.SoTienTN,
                ngayGD = (DateTime)u.NgayThu,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public bool themThuNhapDAO(ChiTietGiaoDichDTO thuNhap)
        {
            try
            {
                CHITIETTHUNHAP tn = new CHITIETTHUNHAP
                {
                    ID = thuNhap.maNguoiDung,
                    MaLoaiTN = thuNhap.maLoaiGD,
                    MaTaiKhoan = thuNhap.maTaiKhoan,
                    SoTienTN = thuNhap.soTien, 
                    NgayThu = thuNhap.ngayGD,
                    GhiChu = thuNhap.ghiChu,
                    TrangThai = true
                };

                qlct.CHITIETTHUNHAP.Add(tn);
                qlct.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool xoaThuNhapDAO(int maNguoiDung, int maThuNhap)
        {
            try
            {
                CHITIETTHUNHAP ct = qlct.CHITIETTHUNHAP.SingleOrDefault(u => u.ID == maNguoiDung && u.MaTN == maThuNhap);
                ct.TrangThai = false;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool capNhatThuNhapDAO(int maNguoiDung, int maTN, ChiTietGiaoDichDTO thuNhap)
        {
            try
            {
                CHITIETTHUNHAP ct = qlct.CHITIETTHUNHAP.SingleOrDefault(u => u.ID == maNguoiDung && u.MaTN == maTN);
                ct.MaLoaiTN= thuNhap.maLoaiGD;
                ct.MaTaiKhoan = thuNhap.maTaiKhoan;
                ct.SoTienTN = thuNhap.soTien;
                ct.NgayThu = thuNhap.ngayGD;
                ct.GhiChu = thuNhap.ghiChu;

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
