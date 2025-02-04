using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class userKhoanChoVayBUS
    {
        userKhoanChoVayDAO vayDAO = new userKhoanChoVayDAO();

        public List<KhoanVayTraDTO> dsKhoanChoVayBUS(int id)
        {
            return vayDAO.dsKhoanChoVayDAO(id);
        }

        public bool themKhoanVayBUS(KhoanVayTraDTO khoanVay)
        {
            return vayDAO.themKhoanChoVayDAO(khoanVay);
        }

        public bool xoaKhoanVayBUS(int id, int idMaKV)
        {
            return vayDAO.xoaKhoanChoVayDAO(id, idMaKV);
        }

        public bool capNhatKhoanVayBUS(int id, int idMaTK, KhoanVayTraDTO khoanVay)
        {
            return vayDAO.capNhatKhoanChoVayDAO(id, idMaTK, khoanVay);
        }
    }
}
