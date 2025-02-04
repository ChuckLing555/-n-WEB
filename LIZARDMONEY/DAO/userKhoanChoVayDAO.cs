using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userKhoanChoVayDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public List<KhoanVayTraDTO> dsKhoanChoVayDAO(int id)
        {
            return qlct.KHOANVAY.Select(u => new KhoanVayTraDTO
            {
                maKVT = (int)u.MaKV,
                maNguoiDung = (int)u.ID,
                maTaiKhoan = (int)u.MaTaiKhoan,// lấy ra tên tài khoản
                nguoiVayNo = u.NguoiNo,
                soTien = (float)u.SoTienVay,
                ngayChoVay = (DateTime)u.NgayChoVay,
                ngayTraNo = (DateTime)u.NgayTra,
                ghiChu = u.GhiChu,
                trangThai = u.TrangThai.Value
            }).Where(v => v.trangThai == true && v.maNguoiDung == id).ToList();
        }

        public bool themKhoanChoVayDAO(KhoanVayTraDTO khoanVay)
        {
            try
            {
                KHOANVAY kv = new KHOANVAY
                {
                    ID = khoanVay.maNguoiDung,
                    MaTaiKhoan = khoanVay.maTaiKhoan,
                    NguoiNo = khoanVay.nguoiVayNo,
                    SoTienVay = (float)khoanVay.soTien,
                    NgayChoVay = (DateTime)khoanVay.ngayChoVay,
                    NgayTra = (DateTime)khoanVay.ngayTraNo,
                    GhiChu = khoanVay.ghiChu,
                    TrangThai = true
                };

                qlct.KHOANVAY.Add(kv);
                qlct.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool xoaKhoanChoVayDAO(int maNguoiDung, int idKV)
        {
            try
            {
                KHOANVAY kn = qlct.KHOANVAY.SingleOrDefault(u => u.ID == maNguoiDung && u.MaKV == idKV);
                kn.TrangThai = false;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool capNhatKhoanChoVayDAO(int maNguoiDung, int maKV, KhoanVayTraDTO khoanVay)
        {
            try
            {
                KHOANVAY kn = qlct.KHOANVAY.SingleOrDefault(u => u.ID == maNguoiDung && u.MaKV == maKV);
                kn.MaTaiKhoan = khoanVay.maTaiKhoan;
                kn.SoTienVay = khoanVay.soTien;
                kn.NgayChoVay = khoanVay.ngayChoVay;
                kn.NgayTra = khoanVay.ngayTraNo;
                kn.NguoiNo = khoanVay.nguoiVayNo;
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
