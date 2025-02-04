using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class userDangNhapBUS
    {
        userDangNhapDAO nguoiDungDAO = new userDangNhapDAO();
        public bool ktDangNhapBUS(string name, string pass)
        {
            return nguoiDungDAO.ktDangNhapDAO(name, pass);
        }

        public string linkImageBUS(string name, string pass)
        {
            return nguoiDungDAO.linkImageDAO(name, pass);
        }

        public string emailBUS(string name)
        {
            return nguoiDungDAO.emailDAO(name);
        }
        public int idNguoiDung(string name, string pass)
        {
            return nguoiDungDAO.idNguoiDungDAO(name, pass);
        }
        public int idNguoiDungEmail(string email)
        {
            return nguoiDungDAO.idNguoiDungEmailDAO(email);
        }
        public string userNameBUS(string name, string pass)
        {
            return nguoiDungDAO.userName(name, pass);
        }
    }
}
