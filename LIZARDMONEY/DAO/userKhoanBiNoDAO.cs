using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userKhoanBiNoDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public List<KhoanVayTraDTO> dsKhoanNoDAO(int id)
        {
            return qlct.KHOANNO.Select(u => new KhoanVayTraDTO
            {
                maKVT = (int)u.MaKN,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                nguoiVayNo = u.NguoiVay,
                soTien = (float)u.SoTienNo,
                ngayChoVay = (DateTime)u.NgayMuonNo,
                ngayTraNo = (DateTime)u.NgayTra,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public bool themKhoanNoDAO(KhoanVayTraDTO khoanVay)
        {
            try
            {
                KHOANNO kn = new KHOANNO
                {
                    ID = khoanVay.maNguoiDung,
                    MaTaiKhoan = khoanVay.maTaiKhoan,
                    NguoiVay = khoanVay.nguoiVayNo,
                    SoTienNo = (float)khoanVay.soTien,
                    NgayMuonNo = (DateTime)khoanVay.ngayChoVay,
                    NgayTra =(DateTime)khoanVay.ngayTraNo,
                    GhiChu = khoanVay.ghiChu,
                    TrangThai = true
                };

                qlct.KHOANNO.Add(kn);
                qlct.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool xoaKhoanNoDAO(int maNguoiDung, int idKV)
        {
            try
            {
                KHOANNO kn = qlct.KHOANNO.SingleOrDefault(u => u.ID == maNguoiDung && u.MaKN == idKV);
                kn.TrangThai = false;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool capNhatKhoanNoDAO(int maNguoiDung, int maKV, KhoanVayTraDTO khoanVay)
        {
            try
            {
                KHOANNO kn = qlct.KHOANNO.SingleOrDefault(u => u.ID == maNguoiDung && u.MaKN == maKV);
                kn.MaTaiKhoan = khoanVay.maTaiKhoan;
                kn.SoTienNo = khoanVay.soTien;
                kn.NgayMuonNo = khoanVay.ngayChoVay;
                kn.NgayTra = khoanVay.ngayTraNo;
                kn.NguoiVay = khoanVay.nguoiVayNo;
                kn.GhiChu = khoanVay.ghiChu;

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
