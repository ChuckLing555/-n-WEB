using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using _0306221404;
using BUS;
using DTO;

namespace LIZARDMONEY
{
    public partial class frmMKMoi : Form
    {
        public frmMKMoi()
        {
            InitializeComponent();
        }

        public string maOTP;
        public int idNguoiDung;
        userDoiMatKhauBUS doiMK = new userDoiMatKhauBUS();

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
            this.Hide();
            frmQuenMK quenMK = new frmQuenMK();
            quenMK.Show();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDNLai_Click(object sender, EventArgs e)
        {
            if(maOTP != txtMaXT.Text || txtMKMoi.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Sai mã OTP hoặc mật khẩu không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ktMatKhau())
            {
                MessageBox.Show("Mật khẩu không hợp lệ.\nMật khẩu bao gồm 4 chữ số trở lên, chứa ký tự đặt biệt và không chứa khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //------------------------------------------
            var newTK = new NguoiDungDTO
            {
                matKhau = Utils.GetMD5(txtNhapLaiMK.Text)
            };

            if (doiMK.doiMatKhauBUS(idNguoiDung, newTK))
            {

                DialogResult res = MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    this.Hide();
                    frmDangNhap dangNhap = new frmDangNhap();
                    dangNhap.Show();
                }
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //------------------------------------------------
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMKMoi.PasswordChar = chkHienMK.Checked ? '\0' : '*';
            txtNhapLaiMK.PasswordChar = chkHienMK.Checked ? '\0' : '*';
        }

        private bool ktMatKhau()
        {
            string reMatKhau = @"^(?!.* )(?=.*\W).{3,}$";

            if (Regex.IsMatch(txtMKMoi.Text, reMatKhau))
            {
                return true;
            }
            return false;
        }
    }
}
