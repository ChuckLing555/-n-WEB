using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public int maNguoiDung { get; set; }
        public int maTaiKhoan { get; set; }
        public float soTien { get; set; }
        public string tenTaiKhoan { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }
    }
}
