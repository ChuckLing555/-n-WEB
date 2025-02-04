using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    
    public class PhanHoiAdminBUS
    {
        PhanHoiAdminDAO phanHoiBUS = new PhanHoiAdminDAO();

        public List<PhanHoiDTO> layDSBUS()
        {
            return phanHoiBUS.layDSDAO();
        }
    }
}
