using System;
using System.Collections.Generic;
using System.Linq;
using DTO;

namespace DAO
{
    public class UserThongKeDAO
    {
        QLCT_LIZARDett qlct = new QLCT_LIZARDett();

        public List<ChiTietGiaoDichDTO> LayDSDAO()
        {
            return qlct.CHITIETCHITIEU
                .Where(u => u.NgayChi.HasValue && u.SoTienCT.HasValue && u.TrangThai == true)
                .Select(u => new ChiTietGiaoDichDTO
                {
                    soTien = (float)u.SoTienCT.Value,
                    ngayGD = u.NgayChi.Value
                }).ToList();
        }
    }
}
