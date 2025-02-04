using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanHoiDTO
    {
        public int maPH {  get; set; }
        public int maNguoiDung {  get; set; }
        public string tenNguoiDung { get; set; }
        public string email {  get; set; }
        public string yKien {  get; set; }
    }
}
