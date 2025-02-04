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
using Microsoft.Reporting.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace LIZARDMONEY
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            cboLoaiCT.DataSource = loaiCT.user_dsLoaiCT_BUS();
            cboLoaiCT.ValueMember = "maLoai";
            cboLoaiCT.DisplayMember = "tenChiTieu";

            cboLoaiTN.DataSource = loaiTN.user_dsLoaiTN_BUS();
            cboLoaiTN.ValueMember = "maLoai";
            cboLoaiTN.DisplayMember = "tenThuNhap";

            cboViTien.DataSource = viTien.dsTaiKhoanBUS(idNguoiDung);
            cboViTien.ValueMember = "maTaiKhoan";
            cboViTien.DisplayMember = "tenTaiKhoan";
        }

        LoaiChiTieuBUS loaiCT = new LoaiChiTieuBUS();
        LoaiThuNhapBUS loaiTN = new LoaiThuNhapBUS();
        userTaiKhoanBUS viTien = new userTaiKhoanBUS();
        userReportBUS reportBUS = new userReportBUS();
        public int idNguoiDung;
        public string tenNguoiDung;

        private Form childForm;
        private void openChildForm(Form nameChildForm)
        {
            if (childForm != null)
            {
                childForm.Close();
            }

            childForm = nameChildForm;

            nameChildForm.TopLevel = false;
            nameChildForm.Dock = DockStyle.Fill;
            pnlReport.Controls.Add(nameChildForm);
            nameChildForm.BringToFront();
            
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (rdoViTien.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCViTien();
                baoCao.Show();

            }

            if (rdoChiTieu.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCChiTieu();
                baoCao.Show();
                
            }

            if (rdoThuNhap.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCThuNhap();
                baoCao.Show();
                
            }

            if (rdoKCV.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCKhoanVay();
                baoCao.Show();
                
            }

            if (rdoKBN.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCKhoanNo();
                baoCao.Show();
                
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(!rdoLocTN.Checked && !rdoLocCT.Checked && !rdoLocVT.Checked && !rdoNhomVT.Checked)
            {
                MessageBox.Show("Bạn chọn dữ liệu !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(rdoChiTieu.Checked && rdoLocCT.Checked)
            { 
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCGiaoDichTheoLoaiGD_CT((LoaiChiTieuDTO)cboLoaiCT.SelectedItem);
                baoCao.Show();
            }


            if (rdoThuNhap.Checked && rdoLocTN.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCGiaoDichTheoLoaiGD_TN((LoaiThuNhapDTO)cboLoaiTN.SelectedItem);
                baoCao.Show();
            }

            if (rdoChiTieu.Checked && rdoLocVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCGiaoDichTheoLoaiVT_CT((TaiKhoanDTO)cboViTien.SelectedItem);
                baoCao.Show();
            }


            if (rdoThuNhap.Checked && rdoLocVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCGiaoDichTheoLoaiVT_TN((TaiKhoanDTO)cboViTien.SelectedItem);
                baoCao.Show();
            }

            if (rdoKCV.Checked && rdoLocVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCKhoanVayTheoLoaiVT((TaiKhoanDTO)cboViTien.SelectedItem);
                baoCao.Show();
            }


            if (rdoKBN.Checked && rdoLocVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.BCKhoanNoTheoLoaiVT((TaiKhoanDTO)cboViTien.SelectedItem);
                baoCao.Show();
            }

            if (rdoChiTieu.Checked && rdoNhomVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.nhom = 1;
                baoCao.BCChiTieuTheoNhomVT();
                baoCao.Show();
            }
            if (rdoThuNhap.Checked && rdoNhomVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.nhom = 2;
                baoCao.BCThuNhapTheoNhomVT();
                baoCao.Show();
            }
            if (rdoKCV.Checked && rdoNhomVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.nhom = 3;
                baoCao.BCKhoanVayTheoNhomVT();
                baoCao.Show();
            }
            if (rdoKBN.Checked && rdoNhomVT.Checked)
            {
                frmXemBaoCao baoCao = new frmXemBaoCao();
                openChildForm(baoCao);
                baoCao.idNguoiDung = idNguoiDung;
                baoCao.tenNguoiDung = tenNguoiDung;
                baoCao.nhom = 4;
                baoCao.BCKhoanNoTheoNhomVT();
                baoCao.Show();
            }
        }

        private void rdoViTien_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoViTien.Checked)
                gbLoc.Enabled = false;
            else gbLoc.Enabled = true;
        }

        private void rdoChiTieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocTN.Checked) rdoLocTN.Checked = false;

            if (rdoChiTieu.Checked)
            {
                cboLoaiTN.Enabled = false;
                rdoLocTN.Enabled = false;
            }

            else
            {
                cboLoaiTN.Enabled = true;
                rdoLocTN.Enabled = true;
            }
        }

        private void rdoThuNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocCT.Checked) rdoLocCT.Checked = false;

            if (rdoThuNhap.Checked)
            {
                cboLoaiCT.Enabled = false;
                rdoLocCT.Enabled = false;
            }

            else
            {
                cboLoaiCT.Enabled = true;
                rdoLocCT.Enabled = true;
            }
        }

        private void rdoKVN_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocTN.Checked || rdoLocCT.Checked)
            {
                rdoLocCT.Checked = false;
                rdoLocCT.Checked = false;
            }

            if (rdoKCV.Checked || rdoKBN.Checked)
            {
                cboLoaiCT.Enabled = false;
                cboLoaiTN.Enabled = false;
                rdoLocCT.Enabled = false;
                rdoLocTN.Enabled = false;
            }
            else
            {
                cboLoaiCT.Enabled = true;
                cboLoaiTN.Enabled = true;
                rdoLocCT.Enabled = true;
                rdoLocTN.Enabled = true;
            }
            
        }
    }
}
