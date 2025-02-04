using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userDangKyDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public bool dangKyDAO (NguoiDungDTO nd)
        {
            try
            {
                NGUOIDUNG nguoiDung = new NGUOIDUNG
                {
                    TenDangNhap = nd.tenDangNhap,
                    AnhDaiDien = nd.anhDaiDien,
                    MatKhau = nd.matKhau,
                    HoTen = nd.hoTen,
                    Email = nd.email,
                    MaPin = nd.maPin,
                    TrangThai = true
                };

                qlct.NGUOIDUNG.Add(nguoiDung);
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
