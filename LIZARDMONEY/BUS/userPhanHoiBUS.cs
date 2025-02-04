using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class userPhanHoiBUS
    {
        userPhanHoiDAO phDAO = new userPhanHoiDAO();

        public bool guiPhanHoiBUS(int id, PhanHoiDTO phanHoi)
        {
            return phDAO.guiPhanHoiDAO(id, phanHoi);
        }
    }
}
