using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace LIZARDMONEY
{
    public partial class frmADLoaiChiTieu : Form
    {
        LoaiChiTieuBUS lctBUS = new LoaiChiTieuBUS();

        LoaiThuNhapBUS ltnBUS = new LoaiThuNhapBUS();
        public frmADLoaiChiTieu()
        {
            InitializeComponent();
            grpThuNhap.Enabled = false;
            dgvDSTN.Enabled = false;

            rdoChiTieu.Checked = true;
            grpChiTieu.Enabled = true;
            dgvDSCT.Enabled = true;

            rdoThuNhap.CheckedChanged += rdoThuNhap_CheckedChanged;
            rdoChiTieu.CheckedChanged += rdoChiTieu_CheckedChanged;
        }

        private void rdoChiTieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChiTieu.Checked)
            {
                grpChiTieu.Enabled = true;
                dgvDSCT.Enabled = true;
            }
            else
            {
                grpChiTieu.Enabled = false;
                dgvDSCT.Enabled = false;
            }
        }

        private void rdoThuNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThuNhap.Checked)
            {
                grpThuNhap.Enabled = true;
                dgvDSTN.Enabled = true;
            }
            else
            {
                grpThuNhap.Enabled = false;
                dgvDSTN.Enabled = false;
            }
        }

        private void frmADLoaiChiTieu_Load(object sender, EventArgs e)
        {

            dgvDSCT.DataSource = lctBUS.layDSBUS();

            dgvDSTN.DataSource = ltnBUS.layDSBUS();

            if (dgvDSCT.Rows.Count > 0)
            {
                txtMaCT.Text = dgvDSCT.Rows[0].Cells[0].Value?.ToString() ?? "";
                txtLoaiCT.Text = dgvDSCT.Rows[0].Cells[1].Value?.ToString() ?? "";
                cbTrangThai.Checked = (bool)dgvDSCT.Rows[0].Cells[2].Value;

            }

            if (dgvDSTN.Rows.Count > 0)
            {
                txtMaThuNhap.Text = dgvDSTN.Rows[0].Cells[0].Value?.ToString() ?? "";
                txtLoaiThuNhap.Text = dgvDSTN.Rows[0].Cells[1].Value?.ToString() ?? "";
                cbThuNhap.Checked = (bool)dgvDSTN.Rows[0].Cells[2].Value;
            }
        }

        private void dgvDSCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaCT.Text = dgvDSCT.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLoaiCT.Text = dgvDSCT.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTrangThai.Checked = (bool)dgvDSCT.Rows[e.RowIndex].Cells[2].Value;
        }

        private void dgvDSTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtMaThuNhap.Text = dgvDSTN.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtLoaiThuNhap.Text = dgvDSTN.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbThuNhap.Checked = (bool)dgvDSTN.Rows[e.RowIndex].Cells[2].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (rdoChiTieu.Checked == true)
            {
                if (string.IsNullOrEmpty(txtLoaiCT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var loaiCTNew = new LoaiChiTieuDTO
                    {
                        tenChiTieu = txtLoaiCT.Text
                    };

                    if (lctBUS.ThemChiTieu(loaiCTNew))
                    {
                        MessageBox.Show("Thêm chi tiêu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm chi tiêu thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    frmADLoaiChiTieu_Load(sender, e);
                }

            }

            if (string.IsNullOrEmpty(txtLoaiThuNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (rdoThuNhap.Checked == true)
                {
                    var LoaiThuNhap = new LoaiThuNhapDTO
                    {
                        tenThuNhap = txtLoaiThuNhap.Text
                    };

                    if (ltnBUS.ThemThuNhap(LoaiThuNhap))
                    {
                        MessageBox.Show("Thêm chi tiêu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm chi tiêu thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    frmADLoaiChiTieu_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (rdoChiTieu.Checked == true)
            {
                if (string.IsNullOrEmpty(txtMaCT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var loaiCTNew = new LoaiChiTieuDTO
                    {

                        maLoai = Convert.ToInt32(txtMaCT.Text),
                        tenChiTieu = txtLoaiCT.Text,
                        trangThai = cbTrangThai.Checked
                    };

                    if (lctBUS.CapNhatCT(loaiCTNew))
                    {

                        MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    frmADLoaiChiTieu_Load(sender, e);
                }

            }

            if (rdoThuNhap.Checked == true)
            {
                if (string.IsNullOrEmpty(txtLoaiThuNhap.Text))
                {
                    MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var LoaiTNNew = new LoaiThuNhapDTO
                    {
                        maLoai = Convert.ToInt32(txtMaThuNhap.Text),
                        tenThuNhap = txtLoaiThuNhap.Text,
                        trangThai = cbThuNhap.Checked
                    };

                    if (ltnBUS.CapNhatTN(LoaiTNNew))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    frmADLoaiChiTieu_Load(sender, e);
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (rdoChiTieu.Checked == true)
            {
                if (string.IsNullOrEmpty(txtMaCT.Text))
                {
                    MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (result == DialogResult.OK)
                    {
                        var loaiCTNew = new LoaiChiTieuDTO
                        {
                            maLoai = int.Parse(txtMaCT.Text)
                        };

                        if (lctBUS.XoaCT(int.Parse(txtMaCT.Text)))
                        {
                            MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (cbTrangThai.Checked == false)
                            {
                                MessageBox.Show("Đã được xóa rồi!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Xóa thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        frmADLoaiChiTieu_Load(sender, e);
                    }
                    else
                        return;
                }
            }

            if (rdoThuNhap.Checked == true)
            {
                if (string.IsNullOrEmpty(txtMaThuNhap.Text))
                {
                    MessageBox.Show("Bạn chưa nhập liệu!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                    if (result == DialogResult.OK)
                    {
                        var loaiTNNew = new LoaiThuNhapDTO
                        {
                            maLoai = int.Parse(txtMaThuNhap.Text)
                        };

                        if (ltnBUS.XoaTN(int.Parse(txtMaThuNhap.Text)))
                        {

                            MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (cbThuNhap.Checked == false)
                            {
                                MessageBox.Show("Đã được xóa rồi!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MessageBox.Show("Xóa thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        frmADLoaiChiTieu_Load(sender, e);
                    }
                    else
                        return;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (rdoChiTieu.Checked == true)
            {
                txtLoaiCT.Text = string.Empty;
                txtMaCT.Text = string.Empty;
            }


            if (rdoThuNhap.Checked == true)
            {
                txtMaThuNhap.Text = string.Empty;
                txtLoaiThuNhap.Text = string.Empty;
            }
        }
    }
}
