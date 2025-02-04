using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class userDoiMatKhauBUS
    {
        userDoiMatKhauDAO resPass = new userDoiMatKhauDAO();

        public bool doiMatKhauBUS(int id, NguoiDungDTO nd)
        {
            return resPass.capNhatMatKhau(id, nd);
        }

        public string layMatKhauBUS(int id)
        {
            return resPass.layMK(id);
        }
    }
}
