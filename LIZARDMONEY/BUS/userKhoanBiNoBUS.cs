using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class userKhoanBiNoBUS
    {
        userKhoanBiNoDAO noDAO = new userKhoanBiNoDAO();

        public List<KhoanVayTraDTO> dsKhoanBiNoBUS(int id)
        {
            return noDAO.dsKhoanNoDAO(id);
        }

        public bool themKhoanBiNoBUS(KhoanVayTraDTO khoanNo)
        {
            return noDAO.themKhoanNoDAO(khoanNo);
        }

        public bool xoaKhoanBiNoBUS(int id, int idMaKN)
        {
            return noDAO.xoaKhoanNoDAO(id, idMaKN);
        }

        public bool capNhatKhoanBiNoBUS(int id, int idMaKN, KhoanVayTraDTO khoanNo)
        {
            return noDAO.capNhatKhoanNoDAO(id, idMaKN, khoanNo);
        }
    }
}
