 using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIZARDMONEY
{
    public partial class frmViTien : Form
    {
        public frmViTien()
        {
            InitializeComponent();
            dgvDSTK.AutoGenerateColumns = false;
            //formart cho cột tiền
            dgvDSTK.Columns["colSoTien"].DefaultCellStyle.Format = "N0";
        }

        private void frmViTien_Load(object sender, EventArgs e)
        {
            dgvDSTK.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);
        }

        userTaiKhoanBUS tkBUS = new userTaiKhoanBUS();
        public int idNguoiDung;

        private void btnThem_Click(object sender, EventArgs e)
        {

            //ràng nhập liệu
            if (string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtGhiChu.Text) || string.IsNullOrEmpty(txtSoTien.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            if (int.Parse(txtSoTien.Text) <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //---------------------------------------------------
            var newTK = new TaiKhoanDTO
            {
                maNguoiDung = idNguoiDung,
                tenTaiKhoan = txtTenVi.Text,
                soTien = float.Parse(txtSoTien.Text),
                ghiChu = txtGhiChu.Text,
                trangThai = true
            };

            if (tkBUS.themTaiKhoanBUS(newTK))
            {
                MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmViTien_Load(sender, e);
            btnLamMoi_Click(sender, e);
            //---------------------------------------------------------
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            int id = int.Parse(dgvDSTK.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            //ràng nhập liệu
            if (string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtGhiChu.Text) || string.IsNullOrEmpty(txtSoTien.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtSoTien.Text) <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //------------------------------------------
            var newTK = new TaiKhoanDTO
            {
                tenTaiKhoan = txtTenVi.Text,
                soTien = float.Parse(txtSoTien.Text),
                ghiChu = txtGhiChu.Text
            };

            if (tkBUS.capNhatTaiKhoanBUS(idNguoiDung, id, newTK))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmViTien_Load(sender, e);
            btnLamMoi_Click(sender, e);
            //------------------------------------------------------ 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (result == DialogResult.OK)
            {
                int id = int.Parse(dgvDSTK.SelectedCells[0].OwningRow.Cells[0].Value.ToString());
                if (tkBUS.xoaTaiKhoanBUS(idNguoiDung, id))
                {
                    MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frmViTien_Load(sender, e);
                btnLamMoi_Click(sender, e);
            }
            else
                return;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenVi.Text = string.Empty;
            txtSoTien.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
        }

        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtTenVi.Text = dgvDSTK.Rows[e.RowIndex].Cells[1].Value.ToString();
            object cellValue = dgvDSTK.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGhiChu.Text = dgvDSTK.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (cellValue != null)
            {
                double chuyen;
                // Kiểm tra xem giá trị có thể được chuyển đổi thành số không
                if (double.TryParse(cellValue.ToString(), out chuyen))
                {
                    txtSoTien.Text = chuyen.ToString();
                }
            }
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ràng nhập số
            if (!char.IsDigit(e.KeyChar ) && e.KeyChar !=8 )
            {
                e.Handled = true;
            }
        }

        private void txtSoTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Kiểm tra Ctrl + V (phím tắt cho paste)
            {
                MessageBox.Show("Không được phép dán dữ liệu vào ô này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Text = string.Empty;
            }
        }
    }
}
