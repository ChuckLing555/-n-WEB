using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static LIZARDMONEY.frmCDTaiKhoan;
using static LIZARDMONEY.frmCDUngDung;

namespace LIZARDMONEY
{
    public partial class frmCaiDat : KryptonForm
    {
        private frmCDUngDung formCDUngDung;
        private frmCDTaiKhoan formCDTaiKhoan;

        public frmCaiDat()
        {
            InitializeComponent();
            colorButton(btnTaiKhoan);

            formCDTaiKhoan = new frmCDTaiKhoan()
            {
                taiAnh = Anh,
            };

            formCDUngDung = new frmCDUngDung()
            {
                cdNgonNguDL = cdNgonNgu,
            };

            openChildFormCD(formCDTaiKhoan);
        }
        private void colorButton(KryptonButton button)
        {
            if (btnCD != null)
            {
                btnCD.StateCommon.Back.Color1 = Color.White;
                btnCD.StateCommon.Back.Color2 = Color.FromArgb(147, 231, 184);
            }
            btnCD = button;
            button.StateCommon.Back.Color1 = Color.FromArgb(147, 231, 184);
            button.StateCommon.Back.Color2 = Color.White;
        }

        public Form trangchu2;

        private Form childFormCD;
        private KryptonButton btnCD;
        // lay link anh tu form chinh
        public string Anh;
        public int id;
        public string emailUser;
        public string accUser;
        public string fullNameUser;
        public dlgTenNguoiDung editfullNameUser;
        public dlgLinkImage editImageUser;

        private void openChildFormCD(Form nameChildFormCD)
        {
            if (childFormCD != null)
            {
                childFormCD.Hide();
            }

            childFormCD = nameChildFormCD;

            if (!gbBodyCD.Panel.Controls.Contains(nameChildFormCD))
            {
                nameChildFormCD.TopLevel = false;
                nameChildFormCD.Dock = DockStyle.Fill;
                gbBodyCD.Panel.Controls.Add(nameChildFormCD);
            }

            nameChildFormCD.BringToFront();
            nameChildFormCD.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            colorButton(btnTaiKhoan);

            openChildFormCD(new frmCDTaiKhoan()
            {
                taiAnh = Anh,
                emailCD = emailUser,
                tenNDCD = fullNameUser,
                tenTKCD = accUser,
                fullNameUser = editfullNameUser,
                linkImg = editImageUser,
                idNguoiDung = id,
                parentFrom = trangchu2,
            });
        }

        //XUNG ĐỘT CODE

        //private void openChildFormCD(Form nameChildFormCD)
        //{
        //    if (childFormCD != null)
        //    {
        //        childFormCD.Close();
        //    }

        //    childFormCD = nameChildFormCD;
        //    nameChildFormCD.TopLevel = false;
        //    nameChildFormCD.Dock = DockStyle.Fill;
        //    gbBodyCD.Panel.Controls.Add(nameChildFormCD);
        //    nameChildFormCD.BringToFront();
        //    nameChildFormCD.Show();
        //}
        //private void btnTaiKhoan_Click(object sender, EventArgs e)
        //{
        //    colorButton(btnTaiKhoan);

        //    openChildFormCD(new frmCDTaiKhoan()
        //    {
        //        taiAnh = Anh,
        //        emailCD = emailUser,
        //        tenNDCD = fullNameUser,
        //        tenTKCD = accUser,
        //        fullNameUser = editfullNameUser,
        //        linkImg = editImageUser,
        //        idNguoiDung = id,
        //        parentFrom = trangchu2,
        //    });
        //}
        private void btnUngDung_Click(object sender, EventArgs e)
        {
            colorButton(btnUngDung);
            openChildFormCD(formCDUngDung);
        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            colorButton(btnPhanHoi);
            openChildFormCD(new frmCDPhanHoi()
            {
                idNguoiDung = id
            });
        }

        private void btnBaoMat_Click(object sender, EventArgs e)
        {
            colorButton(btnBaoMat);
            openChildFormCD(new frmCDBaoMat());
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            colorButton(btnChiTiet);
            openChildFormCD(new frmCDChiTiet());
        }

        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            btnTaiKhoan.PerformClick();
        }

        private void cdNgonNgu(string taiKhoan, string ungDung, string phanHoi, string baoMat, string chiTiet)
        {
            btnTaiKhoan.Text = taiKhoan;
            btnUngDung.Text = ungDung;
            btnPhanHoi.Text = phanHoi;
            btnBaoMat.Text = baoMat;
            btnChiTiet.Text = chiTiet;
        }
    }
}
