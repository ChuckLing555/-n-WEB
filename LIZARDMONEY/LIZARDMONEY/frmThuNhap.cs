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
    public partial class frmThuNhap : Form
    {
        public frmThuNhap()
        {
            InitializeComponent();
            dgvDSTN.AutoGenerateColumns = false;
            dgvDSTN.Columns["colSoTienTN"].DefaultCellStyle.Format = "N0";

        }

        userThemThuNhapBUS thuNhap = new userThemThuNhapBUS();
        LoaiThuNhapBUS loaiTN = new LoaiThuNhapBUS();
        userTaiKhoanBUS tkBUS = new userTaiKhoanBUS();
        public int idNguoiDung;

        private void frmThuNhap_Load(object sender, EventArgs e)
        {
            cboLoaiTN.DataSource = loaiTN.user_dsLoaiTN_BUS();
            cboLoaiTN.ValueMember = "maLoai";
            cboLoaiTN.DisplayMember = "tenThuNhap";

            cboLoaiVi.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);
            cboLoaiVi.ValueMember = "maTaiKhoan";
            cboLoaiVi.DisplayMember = "tenTaiKhoan";

            colTenTN.DataSource = loaiTN.user_dsLoaiTN_BUS();
            colTenTN.ValueMember = "maLoai";
            colTenTN.DisplayMember = "tenThuNhap";

            colViTien.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);
            colViTien.ValueMember = "maTaiKhoan";
            colViTien.DisplayMember = "tenTaiKhoan";

            dgvDSTN.DataSource = thuNhap.dsThuNhapBUS(idNguoiDung);
        }

        private void dgvDSTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            cboLoaiTN.SelectedValue = dgvDSTN.Rows[e.RowIndex].Cells[1].Value;
            cboLoaiVi.SelectedValue = dgvDSTN.Rows[e.RowIndex].Cells[2].Value;
            object cellValue = dgvDSTN.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpNgay.Value = Convert.ToDateTime(dgvDSTN.Rows[e.RowIndex].Cells[4].Value.ToString());
            txtGhiChu.Text = dgvDSTN.Rows[e.RowIndex].Cells[5].Value.ToString();
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

        private void btnThem_Click(object sender, EventArgs e)
        {

            //ràng nhập liệu
            if (string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtSoTien.Text) <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpNgay.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không được lớn hơn thời gian hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgay.Value = DateTime.Now; // Thiết lập lại thời gian về thời gian hiện tại
                return;
            }

            //------------------------------------------
            var newTN = new ChiTietGiaoDichDTO
            {
                maNguoiDung = idNguoiDung,
                maLoaiGD = int.Parse(cboLoaiTN.SelectedValue.ToString()),
                maTaiKhoan = int.Parse(cboLoaiVi.SelectedValue.ToString()),
                soTien = float.Parse(txtSoTien.Text),
                ngayGD = DateTime.Parse(dtpNgay.Value.ToString()),
                ghiChu = txtGhiChu.Text,
                trangThai = true
            };

            if (thuNhap.themThuNhapBUS(newTN))
            {
                MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmThuNhap_Load(sender, e);
            btnLamMoi_Click(sender, e);
            //-------------------------------------------
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            //ràng nhập liệu
            if (string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtGhiChu.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtSoTien.Text) <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpNgay.Value > DateTime.Now)
            {
                MessageBox.Show("Thời gian không được lớn hơn thời gian hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgay.Value = DateTime.Now; // Thiết lập lại thời gian về thời gian hiện tại
                return;
            }

            //---------------------------------------------------------
            int id = int.Parse(dgvDSTN.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

            var newTN = new ChiTietGiaoDichDTO
            {
                maLoaiGD = int.Parse(cboLoaiTN.SelectedValue.ToString()),
                maTaiKhoan = int.Parse(cboLoaiVi.SelectedValue.ToString()),
                soTien = float.Parse(txtSoTien.Text),
                ngayGD = DateTime.Parse(dtpNgay.Value.ToString()),
                ghiChu = txtGhiChu.Text,
            };

            if (thuNhap.capNhatThuNhapBUS(idNguoiDung, id, newTN))
            {
                MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            frmThuNhap_Load(sender, e);
            btnLamMoi_Click(sender, e);
            //---------------------------------------------------------

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (result == DialogResult.OK)
            {

                int id = int.Parse(dgvDSTN.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                if (thuNhap.xoaThuNhapBUS(idNguoiDung, id))
                {
                    MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                frmThuNhap_Load(sender, e);
                btnLamMoi_Click(sender, e);
            }
            else
                return;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLoaiTN.SelectedIndex = 0;
            cboLoaiVi.SelectedIndex = 0;
            txtSoTien.Text = string.Empty;
            dtpNgay.Value = DateTime.Now;
            txtGhiChu.Text = string.Empty;
        }

        private void txtSoTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Kiểm tra Ctrl + V (phím tắt cho paste)
            {
                MessageBox.Show("Không được phép dán dữ liệu vào ô này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Text = string.Empty;
            }
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
