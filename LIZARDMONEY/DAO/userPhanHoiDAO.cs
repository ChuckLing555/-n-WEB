using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class userPhanHoiDAO
    {

        QLCT_LIZARDett qlct = new QLCT_LIZARDett();

        public bool guiPhanHoiDAO(int id, PhanHoiDTO ttPH)
        {
            try
            {
                PHANHOI ph = new PHANHOI
                {
                    ID = id,
                    TenNguoiDung = ttPH.tenNguoiDung,
                    LienLac = ttPH.email,
                    YKien = ttPH.yKien
                };

                qlct.PHANHOI.Add(ph);
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
