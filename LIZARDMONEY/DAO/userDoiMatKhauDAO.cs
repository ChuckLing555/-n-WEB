using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DAO
{
    public class userDoiMatKhauDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();
        public bool capNhatMatKhau(int maNguoiDung, NguoiDungDTO nguoiDung)
        {
            try
            {

                NGUOIDUNG nd = qlct.NGUOIDUNG.SingleOrDefault(u => u.ID == maNguoiDung);
                nd.MatKhau = nguoiDung.matKhau;

                qlct.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string layMK(int maNguoiDung)
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
