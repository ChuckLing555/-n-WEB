using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _0306221404;
using BUS;

namespace LIZARDMONEY
{
    public partial class frmXacNhanXoaTK : Form
    {
        public Form parentFrom;
        public int idNguoiDung;
        NguoiDungBUS cdND = new NguoiDungBUS();
        public frmXacNhanXoaTK()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string Password = Utils.GetMD5(txtMatKhau.Text.Trim());

            if (cdND.KiemTraMK(idNguoiDung) == Password)
            {

                if (cdND.xoaNDBUS(idNguoiDung))
                {
                    DialogResult res = MessageBox.Show("Xóa tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        closeParentForm(parentFrom);
                        frmDangNhap dangNhap = new frmDangNhap();
                        dangNhap.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
        private void closeParentForm(Form parentFrom)
        {
            if (parentFrom != null)
            {
                this.Hide();
                parentFrom.Hide();
            }

        }

    }
}
