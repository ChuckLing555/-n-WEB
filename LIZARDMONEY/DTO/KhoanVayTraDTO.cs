using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhoanVayTraDTO
    {
        public int maKVT { get; set; }
        public int maNguoiDung { get; set; }
        public int maTaiKhoan { get; set; }
        public float soTien {  get; set; }
        public DateTime ngayChoVay {  get; set; }
        public DateTime ngayTraNo {  get; set; }
        public string nguoiVayNo {  get; set; }
        public string ghiChu {  get; set; }
        public bool trangThai {  get; set; }

    }
}
