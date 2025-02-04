using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace LIZARDMONEY
{
    public partial class frmADQuanLy : Form
    {
        NguoiDungBUS qlctBUS = new NguoiDungBUS();
        public frmADQuanLy()
        {
            InitializeComponent();
            dgvDSND.AutoGenerateColumns = false;
        }

        private void frmADQuanLy_Load(object sender, EventArgs e)
        {
            dgvDSND.DataSource = qlctBUS.layDSBUS();
            rdoHoatDong.Checked = true;

            if (dgvDSND.Rows.Count > 0)
            {
                txtTenTaiKhoan.Text = dgvDSND.Rows[0].Cells[0].Value?.ToString() ?? "";
                txtEmail.Text = dgvDSND.Rows[0].Cells[3].Value?.ToString() ?? "";
                txtTenNguoiDung.Text = dgvDSND.Rows[0].Cells[2].Value?.ToString() ?? "";
            }
        }

        private void dgvDSND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtTenTaiKhoan.Text = dgvDSND.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNguoiDung.Text = dgvDSND.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDSND.Rows[e.RowIndex].Cells[3].Value.ToString();
            if ((bool)dgvDSND.Rows[e.RowIndex].Cells[4].Value == true)
                rdoHoatDong.Checked = true;
            else
                rdoNgungHoatDong.Checked = true;
        }

        private void btnTKTenTK_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenTaiKhoan.Text))
            {
                MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string tenDangNhap = txtTenTaiKhoan.Text.Trim();
                List<NguoiDungDTO> nguoiDung = qlctBUS.LayDSTen(tenDangNhap);
                if (nguoiDung.Count > 0)
                {
                    dgvDSND.DataSource = nguoiDung;
                }
                else
                {
                    MessageBox.Show("Tên tài khoản không tồn tại!", "Không tìm thấy tên tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnTKEmail_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                string Email = txtEmail.Text.Trim();
                if (!string.IsNullOrEmpty(Email))
                {
                    List<NguoiDungDTO> email = qlctBUS.LayDSEmail(txtEmail.Text);
                    if (email.Count > 0)
                    {
                        dgvDSND.DataSource = email;
                    }
                    else
                    {
                        MessageBox.Show("Email không tồn tại!", "Không tìm thấy email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnTKNguoiDung_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTenNguoiDung.Text))
            {
                MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            else
            {
                string nguoiDung = txtTenNguoiDung.Text.Trim();
                if (!string.IsNullOrEmpty(nguoiDung))
                {
                    List<NguoiDungDTO> hoTen = qlctBUS.LayDSHoTen(txtTenNguoiDung.Text);
                    if (hoTen.Count > 0)
                    {
                        dgvDSND.DataSource = hoTen;
                    }
                    else
                    {
                        MessageBox.Show("Tên người dùng không tồn tại!", "Không tìm thấy người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTKTrangThai_Click(object sender, EventArgs e)
        {
            if (rdoHoatDong.Checked == true)
            {
                dgvDSND.DataSource = qlctBUS.LayDSHOATDONG(true);
            }
            else
                dgvDSND.DataSource = qlctBUS.LayDSHOATDONG(false);
        }

        private void btnRefest_Click(object sender, EventArgs e)
        {
            frmADQuanLy_Load(sender, e);

            rdoHoatDong.Checked = true;
            txtTenTaiKhoan.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTenNguoiDung.Text = string.Empty;
        }

        private void txtTenTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Kiểm tra Ctrl + V (phím tắt cho paste)
            {
                MessageBox.Show("Không được phép dán dữ liệu vào ô này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Text = string.Empty;
            }
        }

        private void txtTenTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
