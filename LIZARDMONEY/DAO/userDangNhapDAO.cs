using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DAO
{
    public class userDangNhapDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public bool ktDangNhapDAO(string name, string pass)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.MatKhau == pass && u.TenDangNhap == name && u.TrangThai == true);
                if (nd != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public string linkImageDAO(string name, string pass)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.MatKhau == pass && u.TenDangNhap == name && u.TrangThai == true);
                if (nd != null)
                {
                    return nd.AnhDaiDien;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public string emailDAO(string name)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.TenDangNhap == name && u.TrangThai == true);
                if (nd != null)
                {
                    return nd.Email;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public int idNguoiDungDAO(string name, string pass)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.MatKhau == pass && u.TenDangNhap == name && u.TrangThai == true);
                if (nd != null)
                {
                    return nd.ID;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int idNguoiDungEmailDAO(string email)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.Email == email && u.TrangThai == true);
                if (nd != null)
                {
                    return nd.ID;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public string userName(string name, string pass)
        {
            try
            {
                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.MatKhau == pass && u.TenDangNhap == name && u.TrangThai == true);
                if (nd != null)
                {
                    return nd.HoTen;
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
