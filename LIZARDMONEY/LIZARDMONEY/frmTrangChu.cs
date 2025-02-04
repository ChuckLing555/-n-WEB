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

namespace LIZARDMONEY
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
            dgvDSTK.AutoGenerateColumns = false;
            dgvDSGD.AutoGenerateColumns = false;

            dgvDSTK.Columns["colSoTien"].DefaultCellStyle.Format = "N0";
            dgvDSGD.Columns["colSoTienGD"].DefaultCellStyle.Format = "N0";

            rdoChiTieu.Checked = true;

            rdoChiTieu.CheckedChanged += rdoChiTieu_CheckedChanged;
            rdoThuNhap.CheckedChanged += rdoThuNhap_CheckedChanged;

        }

        userTaiKhoanBUS tkBUS = new userTaiKhoanBUS();
        userThemChiTieuBUS chiTieu = new userThemChiTieuBUS();
        userThemThuNhapBUS thuNhap = new userThemThuNhapBUS();
        LoaiChiTieuBUS loaiCT = new LoaiChiTieuBUS();
        LoaiThuNhapBUS loaiTN = new LoaiThuNhapBUS();
        public int idNguoiDung;

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            dgvDSTK.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);

            int tongVi = dgvDSTK.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[2].Value));

            object cellValue = tongVi;
            if (cellValue != null)
            {
                double chuyenVT;
                // Kiểm tra xem giá trị có thể được chuyển đổi thành số không
                if (double.TryParse(cellValue.ToString(), out chuyenVT))
                {
                    lblTienVi.Text = chuyenVT.ToString() + " VNĐ";
                }
            }

            if (rdoChiTieu.Checked)
            {
                colTenGD.DataSource = loaiCT.user_dsLoaiCT_BUS();
                colTenGD.ValueMember = "maLoai";
                colTenGD.DisplayMember = "tenChiTieu";

                colViTien.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);
                colViTien.ValueMember = "maTaiKhoan";
                colViTien.DisplayMember = "tenTaiKhoan";

                dgvDSGD.DataSource = chiTieu.dsChiTieuBUS(idNguoiDung);

                int tongTN = dgvDSGD.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));

                object cellValueTN = tongTN;
                if (cellValueTN != null)
                {
                    double chuyenTN;
                    // Kiểm tra xem giá trị có thể được chuyển đổi thành số không
                    if (double.TryParse(cellValueTN.ToString(), out chuyenTN))
                    {
                        lblTongGD.Text = chuyenTN.ToString() + " VNĐ";
                    }
                }

            }
               
            if (rdoThuNhap.Checked)
            {
                colTenGD.DataSource = loaiTN.user_dsLoaiTN_BUS();
                colTenGD.ValueMember = "maLoai";
                colTenGD.DisplayMember = "tenThuNhap";

                colViTien.DataSource = tkBUS.dsTaiKhoanBUS(idNguoiDung);
                colViTien.ValueMember = "maTaiKhoan";
                colViTien.DisplayMember = "tenTaiKhoan";

                dgvDSGD.DataSource = thuNhap.dsThuNhapBUS(idNguoiDung);

                
            }
           
        }

        private void rdoChiTieu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChiTieu.Checked == true)
            {
                lblTXTTongTien.Text = "Tổng tiền chi tiêu:";
                dgvDSGD.DataSource = chiTieu.dsChiTieuBUS(idNguoiDung);

                int tongTN = dgvDSGD.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));

                object cellValueTN = tongTN;
                if (cellValueTN != null)
                {
                    double chuyenTN;
                    // Kiểm tra xem giá trị có thể được chuyển đổi thành số không
                    if (double.TryParse(cellValueTN.ToString(), out chuyenTN))
                    {
                        lblTongGD.Text = chuyenTN.ToString() + " VNĐ";
                    }
                }
            }
        }

        private void rdoThuNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThuNhap.Checked == true)
            {
                lblTXTTongTien.Text = "Tổng tiền thu nhập:";
                dgvDSGD.DataSource = thuNhap.dsThuNhapBUS(idNguoiDung);

                int tongCT = dgvDSGD.Rows.Cast<DataGridViewRow>().Sum(t => Convert.ToInt32(t.Cells[3].Value));

                object cellValueCT = tongCT;
                if (cellValueCT != null)
                {
                    double chuyenCT;
                    // Kiểm tra xem giá trị có thể được chuyển đổi thành số không
                    if (double.TryParse(cellValueCT.ToString(), out chuyenCT))
                    {
                        lblTongGD.Text = chuyenCT.ToString() + " VNĐ";
                    }
                }
            }
        }
    }
}
