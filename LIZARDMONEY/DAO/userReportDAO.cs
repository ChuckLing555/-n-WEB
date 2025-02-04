using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userReportDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public List<ReportGiaoDichDTO> dsChiTieuDAO(int id)
        {
            return qlct.CHITIETCHITIEU.Select(u => new ReportGiaoDichDTO
            {
                maGD = (int)u.MaCT,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                maLoaiGD = (int)u.MaLoaiCT,// lấy ra tên loại giao dịch/ chi tiêu
                tenLoaiGD = qlct.LOAICHITIEU.FirstOrDefault(i => i.MaLoaiCT == u.MaLoaiCT).TenChiTieu,
                soTien = (float)u.SoTienCT,
                ngayGD = (DateTime)u.NgayChi,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public List<ReportGiaoDichDTO> dsChiTieuTheoLoaiCTDAO(int id, int maLoaiCT)
        {
            return qlct.CHITIETCHITIEU.Select(u => new ReportGiaoDichDTO
            {
                maGD = (int)u.MaCT,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                maLoaiGD = (int)u.MaLoaiCT,// lấy ra tên loại giao dịch/ chi tiêu
                tenLoaiGD = qlct.LOAICHITIEU.FirstOrDefault(i => i.MaLoaiCT == u.MaLoaiCT).TenChiTieu,
                soTien = (float)u.SoTienCT,
                ngayGD = (DateTime)u.NgayChi,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id && v.maLoaiGD == maLoaiCT).ToList();
        }

        public List<ReportGiaoDichDTO> dsChiTieuTheoLoaiVTDAO(int id, int maTaiKhoan)
        {
            return qlct.CHITIETCHITIEU.Select(u => new ReportGiaoDichDTO
            {
                maGD = (int)u.MaCT,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                maLoaiGD = (int)u.MaLoaiCT,// lấy ra tên loại giao dịch/ chi tiêu
                tenLoaiGD = qlct.LOAICHITIEU.FirstOrDefault(i => i.MaLoaiCT == u.MaLoaiCT).TenChiTieu,
                soTien = (float)u.SoTienCT,
                ngayGD = (DateTime)u.NgayChi,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id && v.maTaiKhoan == maTaiKhoan).ToList();
        }

        public List<ReportGiaoDichDTO> dsThuNhapDAO(int id)
        {
            return qlct.CHITIETTHUNHAP.Select(u => new ReportGiaoDichDTO
            {
                maGD = (int)u.MaTN,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                maLoaiGD = (int)u.MaLoaiTN,// lấy ra tên loại giao dịch/ chi tiêu
                tenLoaiGD = qlct.LOAITHUNHAP.FirstOrDefault(i => i.MaLoaiTN == u.MaLoaiTN).TenThuNhap,
                soTien = (float)u.SoTienTN,
                ngayGD = (DateTime)u.NgayThu,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public List<ReportGiaoDichDTO> dsThuNhapTheoLoaiTNDAO(int id, int maLoaiTN)
        {
            return qlct.CHITIETTHUNHAP.Select(u => new ReportGiaoDichDTO
            {
                maGD = (int)u.MaTN,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                maLoaiGD = (int)u.MaLoaiTN,// lấy ra tên loại giao dịch/ chi tiêu
                tenLoaiGD = qlct.LOAITHUNHAP.FirstOrDefault(i => i.MaLoaiTN == u.MaLoaiTN).TenThuNhap,
                soTien = (float)u.SoTienTN,
                ngayGD = (DateTime)u.NgayThu,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id && v.maLoaiGD == maLoaiTN).ToList();
        }

        public List<ReportGiaoDichDTO> dsThuNhapTheoLoaiVTDAO(int id, int maTaiKhoan)
        {
            return qlct.CHITIETTHUNHAP.Select(u => new ReportGiaoDichDTO
            {
                maGD = (int)u.MaTN,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                maLoaiGD = (int)u.MaLoaiTN,// lấy ra tên loại giao dịch/ chi tiêu
                tenLoaiGD = qlct.LOAITHUNHAP.FirstOrDefault(i => i.MaLoaiTN == u.MaLoaiTN).TenThuNhap,
                soTien = (float)u.SoTienTN,
                ngayGD = (DateTime)u.NgayThu,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id && v.maTaiKhoan == maTaiKhoan).ToList();
        }
        public List<ReportVayTraDTO> dsKhoanChoVayDAO(int id)
        {
            return qlct.KHOANNO.Select(u => new ReportVayTraDTO
            {
                maKVT = (int)u.MaKN,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                nguoiVayNo = u.NguoiVay,
                soTien = (float)u.SoTienNo,
                ngayChoVay = (DateTime)u.NgayMuonNo,
                ngayTraNo = (DateTime)u.NgayTra,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public List<ReportVayTraDTO> dsKhoanChoVayTheoLoaiVTDAO(int id, int maTaiKhoan)
        {
            return qlct.KHOANNO.Select(u => new ReportVayTraDTO
            {
                maKVT = (int)u.MaKN,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                nguoiVayNo = u.NguoiVay,
                soTien = (float)u.SoTienNo,
                ngayChoVay = (DateTime)u.NgayMuonNo,
                ngayTraNo = (DateTime)u.NgayTra,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id && v.maTaiKhoan == maTaiKhoan).ToList();
        }

        public List<ReportVayTraDTO> dsKhoanBiNoDAO(int id)
        {
            return qlct.KHOANVAY.Select(u => new ReportVayTraDTO
            {
                maKVT = (int)u.MaKV,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                nguoiVayNo = u.NguoiNo,
                soTien = (float)u.SoTienVay,
                ngayChoVay = (DateTime)u.NgayChoVay,
                ngayTraNo = (DateTime)u.NgayTra,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public List<ReportVayTraDTO> dsKhoanBiNoTheoLoaiVTDAO(int id, int maTaiKhoan)
        {
            return qlct.KHOANVAY.Select(u => new ReportVayTraDTO
            {
                maKVT = (int)u.MaKV,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                tenTaiKhoan = qlct.TAIKHOAN.FirstOrDefault(i => i.MaTaiKhoan == u.MaTaiKhoan).TenTaiKhoan,
                nguoiVayNo = u.NguoiNo,
                soTien = (float)u.SoTienVay,
                ngayChoVay = (DateTime)u.NgayChoVay,
                ngayTraNo = (DateTime)u.NgayTra,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id && v.maTaiKhoan == maTaiKhoan).ToList();
        }
    }
}
