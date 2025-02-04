using BUS;
using DTO;
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

namespace LIZARDMONEY
{
    public partial class frmCDPhanHoi : Form
    {

        public frmCDPhanHoi()
        {
            InitializeComponent();
        }

        private void frmCDPhanHoi_Load(object sender, EventArgs e)
        {
            txtDongGop.Text = string.Empty;
            txtEmailOrSDT.Text = string.Empty; 
            txtTen.Text = string.Empty;
        }

        public int idNguoiDung;
        userPhanHoiBUS phBUS = new userPhanHoiBUS();

        private void btnGui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDongGop.Text) || string.IsNullOrEmpty(txtEmailOrSDT.Text) || string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            if (!ktEmail())
            {
                MessageBox.Show("Định dạng Email sai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                

            var ttPhanHoi = new PhanHoiDTO
            {
                maNguoiDung = idNguoiDung,
                tenNguoiDung = txtTen.Text,
                email = txtEmailOrSDT.Text,
                yKien = txtDongGop.Text
            };

            if (phBUS.guiPhanHoiBUS(idNguoiDung, ttPhanHoi))
            {
                MessageBox.Show("Gửi phản hồi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Gửi phản hồi thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmCDPhanHoi_Load(sender, e);
        }
        public void CDNgonNguPH(string nd, string hoTen, string email, string dongGop, string gui)
        {
            lbND.Text = nd;
            lbHoTen.Text = hoTen;
            lbEmail.Text = email;
            lbDongGop.Text = dongGop;
            btnGui.Text = gui;
        }

        private bool ktEmail()
        {
            string reEmail = @"^(?!.* )([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            if (Regex.IsMatch(txtEmailOrSDT.Text, reEmail))
            {
                return true;
            }
            return false;
        }

    }
}
