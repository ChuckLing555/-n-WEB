using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ThongKeBUS
    {
        UserThongKeDAO qlctDAO = new UserThongKeDAO();

        public List<ChiTietGiaoDichDTO> layDSBUS()
        {
            return qlctDAO.LayDSDAO();
        }
    }
}
