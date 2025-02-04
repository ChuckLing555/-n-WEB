using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LIZARDMONEY
{
    public partial class frmKhoanVay : Form
    {
        public frmKhoanVay()
        {
            InitializeComponent();
            dgvVayNo.AutoGenerateColumns = false;

            rdoVay.Checked = true;
            dgvVayNo.DataSource = khoanVay.dsKhoanChoVayBUS(idNguoiDung);

            rdoVay.CheckedChanged += rdoVay_CheckedChanged;
            rdoMuon.CheckedChanged += rdoMuon_CheckedChanged;

            dgvVayNo.Columns["colSoTien"].DefaultCellStyle.Format = "N0";
        }

        public int idNguoiDung;
        userTaiKhoanBUS tkBUS = new userTaiKhoanBUS();
        userKhoanBiNoBUS khoanNo = new userKhoanBiNoBUS();// Khoản bị nợ
        userKhoanChoVayBUS khoanVay = new userKhoanChoVayBUS();// Khoản cho người khác vay

        private void frmKhoanVay_Load(object sender, EventArgs e)
        {
            cboLoaiVi.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);
            cboLoaiVi.ValueMember = "maTaiKhoan";
            cboLoaiVi.DisplayMember = "tenTaiKhoan";

            colViTien.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);
            colViTien.ValueMember = "maTaiKhoan";
            colViTien.DisplayMember = "tenTaiKhoan";

            if(rdoVay.Checked)
                dgvVayNo.DataSource = khoanVay.dsKhoanChoVayBUS(idNguoiDung);
            if(rdoMuon.Checked)
                dgvVayNo.DataSource = khoanNo.dsKhoanBiNoBUS(idNguoiDung);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //ràng nhập liệu
            if (string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtGhiChu.Text) || string.IsNullOrEmpty(txtNguoiNo.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtSoTien.Text) <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpNgayMuon.Value >= dtpNgayTra.Value)
            {
                MessageBox.Show("Ngày cho vay không được lớn hơn ngày trả nợ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //-----------------------------------------------------
            var newKVT = new KhoanVayTraDTO
            {
                maNguoiDung = idNguoiDung,
                maTaiKhoan = int.Parse(cboLoaiVi.SelectedValue.ToString()),
                nguoiVayNo = txtNguoiNo.Text,
                soTien = float.Parse(txtSoTien.Text),
                ngayChoVay = DateTime.Parse(dtpNgayMuon.Value.ToString()),
                ngayTraNo = DateTime.Parse(dtpNgayTra.Value.ToString()),
                ghiChu = txtGhiChu.Text,
                trangThai = true
            };

            if (rdoVay.Checked == true)
            {

                if (khoanVay.themKhoanVayBUS(newKVT))
                {
                    MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdoMuon.Checked == true)
            {

                if (khoanNo.themKhoanBiNoBUS(newKVT))
                {
                    MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            frmKhoanVay_Load(sender, e);
            btnLamMoi_Click(sender, e);
            //-----------------------------------------------------------
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

           
            //ràng nhập liệu
            if (string.IsNullOrEmpty(txtSoTien.Text) || string.IsNullOrEmpty(txtGhiChu.Text) || string.IsNullOrEmpty(txtNguoiNo.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(txtSoTien.Text) <= 0)
            {
                MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpNgayMuon.Value >= dtpNgayTra.Value)
            {
                MessageBox.Show("Ngày vay không được lớn hơn ngày trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //--------------------------------------
            var newTN = new KhoanVayTraDTO
            {
                maTaiKhoan = int.Parse(cboLoaiVi.SelectedValue.ToString()),
                nguoiVayNo = txtNguoiNo.Text,
                soTien = float.Parse(txtSoTien.Text),
                ngayChoVay = DateTime.Parse(dtpNgayMuon.Value.ToString()),
                ngayTraNo = DateTime.Parse(dtpNgayTra.Value.ToString()),
                ghiChu = txtGhiChu.Text
            };

            if (rdoVay.Checked == true)
            {
                int id = int.Parse(dgvVayNo.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                if (khoanVay.capNhatKhoanVayBUS(idNguoiDung, id, newTN))
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (rdoMuon.Checked == true)
            {
                int id = int.Parse(dgvVayNo.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                if (khoanNo.capNhatKhoanBiNoBUS(idNguoiDung, id, newTN))
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            frmKhoanVay_Load(sender, e);
            btnLamMoi_Click(sender, e);
            //--------------------------------------
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (result == DialogResult.OK)
            {
                if (rdoVay.Checked == true)
                {
                    int id = int.Parse(dgvVayNo.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                    if (khoanVay.xoaKhoanVayBUS(idNguoiDung, id))
                    {
                        MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (rdoMuon.Checked == true)
                {
                    int id = int.Parse(dgvVayNo.SelectedCells[0].OwningRow.Cells[0].Value.ToString());

                    if (khoanNo.xoaKhoanBiNoBUS(idNguoiDung, id))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm dữ liệu thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                frmKhoanVay_Load(sender, e);
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboLoaiVi.SelectedIndex = 0;
            txtSoTien.Text = string.Empty;
            txtNguoiNo.Text = string.Empty;
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            txtGhiChu.Text = string.Empty;
        }

        private void dgvVayNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtNguoiNo.Text = dgvVayNo.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboLoaiVi.SelectedValue = dgvVayNo.Rows[e.RowIndex].Cells[2].Value;
            txtSoTien.Text = dgvVayNo.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpNgayMuon.Value = Convert.ToDateTime(dgvVayNo.Rows[e.RowIndex].Cells[4].Value.ToString());
            dtpNgayTra.Value = Convert.ToDateTime(dgvVayNo.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtGhiChu.Text = dgvVayNo.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void rdoVay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoVay.Checked == true)
            {
                lblNguoi.Text = "Người vay:";
                lblDS.Text = "Danh Sách Khoản Cho Vay";
                dgvVayNo.DataSource = khoanVay.dsKhoanChoVayBUS(idNguoiDung);
            }
        }

        private void rdoMuon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMuon.Checked == true)
            {
                lblNguoi.Text = "Vay từ:";
                lblDS.Text = "Danh Sách Khoản Nợ";
                dgvVayNo.DataSource = khoanNo.dsKhoanBiNoBUS(idNguoiDung);
            }
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSoTien_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.V) 
            {
                MessageBox.Show("Không được phép dán dữ liệu vào ô này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTien.Text = string.Empty;
            }
        }
    }
}
