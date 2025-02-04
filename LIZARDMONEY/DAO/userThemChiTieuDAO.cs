using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userThemChiTieuDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public List<ChiTietGiaoDichDTO> dsChiTieu(int id)
        {
            return qlct.CHITIETCHITIEU.Select(u => new ChiTietGiaoDichDTO
            {
                maGD = (int)u.MaCT,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                maLoaiGD = (int)u.MaLoaiCT,// lấy ra tên loại giao dịch/ chi tiêu
                soTien = (float)u.SoTienCT,
                ngayGD = (DateTime)u.NgayChi,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public bool themChiTieuDAO(ChiTietGiaoDichDTO chiTieu)
        {
            try
            {
                CHITIETCHITIEU ct = new CHITIETCHITIEU
                {
                    ID = chiTieu.maNguoiDung,
                    MaLoaiCT = chiTieu.maLoaiGD,
                    MaTaiKhoan = chiTieu.maTaiKhoan, 
                    SoTienCT = (float)chiTieu.soTien,
                    NgayChi = (DateTime)chiTieu.ngayGD,
                    GhiChu = chiTieu.ghiChu,
                    TrangThai = true
                };

                qlct.CHITIETCHITIEU.Add(ct);
                qlct.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool xoaChiTieuDAO(int maNguoiDung, int maChiTieu)
        {
            try
            {
                CHITIETCHITIEU ct = qlct.CHITIETCHITIEU.SingleOrDefault(u => u.ID == maNguoiDung && u.MaCT == maChiTieu);
                ct.TrangThai = false;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool capNhatChiTieuDAO(int maNguoiDung,int maCT, ChiTietGiaoDichDTO chiTieu)
        {
            try
            {
                CHITIETCHITIEU ct = qlct.CHITIETCHITIEU.SingleOrDefault(u => u.ID == maNguoiDung && u.MaCT == maCT);
                ct.MaLoaiCT = chiTieu.maLoaiGD;
                ct.MaTaiKhoan = chiTieu.maTaiKhoan;
                ct.SoTienCT = chiTieu.soTien;
                ct.NgayChi = chiTieu.ngayGD;
                ct.GhiChu = chiTieu.ghiChu;

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
