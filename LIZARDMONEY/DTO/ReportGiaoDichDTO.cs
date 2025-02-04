using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportGiaoDichDTO
    {
        public int maGD { get; set; }
        public int maNguoiDung { get; set; }
        public int maLoaiGD { get; set; }
        public string tenLoaiGD { get; set; }
        public int maTaiKhoan { get; set; }
        public string tenTaiKhoan { get; set; }
        public float soTien { get; set; }
        public DateTime ngayGD { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }
    }
}
