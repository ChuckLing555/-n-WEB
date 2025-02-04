using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        public int maNguoiDung { get; set; }
        public string tenDangNhap { get; set; }
        public string anhDaiDien { get; set; }
        public string matKhau { get; set; }
        public string hoTen { get; set; }
        public string email { get; set; }
        public string maPin { get; set; }
        public bool trangThai { get; set; }
    }
}
