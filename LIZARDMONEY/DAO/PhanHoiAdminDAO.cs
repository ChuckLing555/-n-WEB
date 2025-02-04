using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class PhanHoiAdminDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();

        public List<PhanHoiDTO> layDSDAO()
        {
            return qlct.PHANHOI.Select(u => new PhanHoiDTO
            {
                tenNguoiDung = u.TenNguoiDung,
                email = u.LienLac,
                yKien = u.YKien
            }).ToList();
        }
    }
}
