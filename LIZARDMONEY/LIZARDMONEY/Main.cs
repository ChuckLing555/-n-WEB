using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace LIZARDMONEY
{
    public partial class Main : KryptonForm
    {
        public Main()
        {
            InitializeComponent();

            colorButton(btnTrangChu);
            openChildForm(new frmTrangChu()
            {
                idNguoiDung = idND
            });

        }

        private void Main_Load(object sender, EventArgs e)
        {
            timerNgayGio.Enabled = true;

            if (File.Exists(folderPath + "/" + linkAnh))
            {
                // chuyển hình thành dữ liệu byte
                byte[] byteHA = File.ReadAllBytes(folderPath + "/" + linkAnh);
                // chuyển dữ liệu thành đối tượng MemoryStream cho việc chuyển dữ liệu
                MemoryStream mos = new MemoryStream(byteHA);
                // Tạo đối tượng Image từ MemoryStream
                pbAnhND.Image = Image.FromStream(mos);

                mos.Close();
                mos.Dispose();
                System.GC.Collect();
            }
            else
            {
                pbAnhND.Image = null;
            }

            btnTrangChu.Click += btnTrangChu_Click;
            btnTrangChu.PerformClick();

            lblUserName.Text = hoTenND;
        }

        public string linkAnh;
        public string tenND;
        public int idND;
        public string hoTenND;
        string folderPath = "../../image";
        public string emailND;

        private Form childForm;
        private KryptonButton btn;

        public Form trangchu1;

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openChildForm(Form nameChildForm)
        {
            if (childForm != null)
            {
                childForm.Close();
            }

            childForm = nameChildForm;
            nameChildForm.TopLevel = false;
            nameChildForm.Dock = DockStyle.Fill;
            gBody.Panel.Controls.Add(nameChildForm);
            nameChildForm.BringToFront();
            nameChildForm.Show();
        }

        private void colorButton(KryptonButton button)
        {
            if (btn != null)// neu button khong duoc click
            {
                btn.StateCommon.Back.Color1 = Color.FromArgb(227, 255, 239);
                btn.StateCommon.Back.Color2 = Color.FromArgb(147, 231, 184);
            }
            btn = button;// duoc click
            button.StateCommon.Back.Color1 = Color.FromArgb(147, 231, 184);
            button.StateCommon.Back.Color2 = Color.FromArgb(227, 255, 239);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            colorButton(btnTrangChu);
            openChildForm(new frmTrangChu() 
            { 
                idNguoiDung = idND 
            });
        }

        private void btnViTien_Click(object sender, EventArgs e)
        {
            colorButton(btnViTien);
            openChildForm(new frmViTien()
            {
                idNguoiDung = idND
            }) ;
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            colorButton(btnChiTieu);
            openChildForm(new frmChiTieu()
            {
                idNguoiDung = idND
            });
        }

        private void btnThuNhap_Click(object sender, EventArgs e)
        {
            colorButton(btnThuNhap);
            openChildForm(new frmThuNhap()
            {
                idNguoiDung = idND
            });
        }

        private void btnKhoanVay_Click(object sender, EventArgs e)
        {
            colorButton(btnKhoanVay);
            openChildForm(new frmKhoanVay()
            {
                idNguoiDung = idND
            });
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            colorButton(btnThongKe);
            openChildForm(new frmThongKe());
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            colorButton(btnCaiDat);
            openChildForm(new frmCaiDat()// gans gia tri cho linkAnh
            {
                Anh = linkAnh,
                id = idND,
                emailUser = emailND,
                accUser = tenND,
                fullNameUser = hoTenND,
                editfullNameUser = fullNameUser,
                editImageUser = imageUser,
                trangchu2 = trangchu1
            });
        }

        private void btnXuatBC_Click(object sender, EventArgs e)
        {
            colorButton(btnXuatBC);
            openChildForm(new frmBaoCao()
            {
               idNguoiDung = idND,
               tenNguoiDung = hoTenND
            });
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            colorButton(btnDangXuat);

            this.Hide();
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }

        private void timerNgayGio_Tick(object sender, EventArgs e)
        {
            lblNgay.Text = DateTime.Now.ToShortDateString();
            lblGio.Text = DateTime.Now.ToShortTimeString();
        }

        private void fullNameUser(string ten)
        {
            lblUserName.Text =ten;
        }

        private void imageUser(string link)
        {
            if (File.Exists(folderPath + "/" + link))
            {
                // chuyển hình thành dữ liệu byte
                byte[] byteHA = File.ReadAllBytes(folderPath + "/" + link);
                // chuyển dữ liệu thành đối tượng MemoryStream cho việc chuyển dữ liệu
                MemoryStream mos = new MemoryStream(byteHA);
                // Tạo đối tượng Image từ MemoryStream
                pbAnhND.Image = Image.FromStream(mos);

                mos.Close();
                mos.Dispose();
                System.GC.Collect();
            }
            else
            {
                pbAnhND.Image = null;
            }
        }
    }
}
