using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using _0306221404;
using BUS;

namespace LIZARDMONEY
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            loadAnh(linkAnh);

            txtTenTK.Text = tenDangNhap;
            //txtMatKhau.Text = matKhau;
            txtMatKhau.PasswordChar = '*';

        }

        // gọi BUS
        userDangNhapBUS nguoiDungBUS = new userDangNhapBUS();

        // sựu kiện button
        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private static string soLanDangNhap = "soLanLogin.txt";

        // Đọc số lượt đăng nhập hàng ngày từ file
        private static Dictionary<string, int> DocSoLan()
        {
            var soLanLogin = new Dictionary<string, int>();
            if (File.Exists(soLanDangNhap))
            {
                var lines = File.ReadAllLines(soLanDangNhap);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        var date = parts[0];
                        var count = int.Parse(parts[1]);
                        soLanLogin[date] = count;
                    }
                }
            }
            return soLanLogin;
        }

        // Ghi số lượt đăng nhập hàng ngày vào file
        private static void WriteDailyLoginCounts(Dictionary<string, int> loginCounts)
        {
            var lines = loginCounts.Select(kvp => $"{kvp.Key},{kvp.Value}");
            File.WriteAllLines(soLanDangNhap, lines);
        }

        public static void IncrementLoginCount()
        {
            var loginCounts = DocSoLan();
            var today = DateTime.Now.ToString("yyyy-MM-dd");

            if (loginCounts.ContainsKey(today))
            {
                loginCounts[today]++;
            }
            else
            {
                loginCounts[today] = 1;
            }

            WriteDailyLoginCounts(loginCounts);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Password = Utils.GetMD5(txtMatKhau.Text.Trim());

            if (nguoiDungBUS.ktDangNhapBUS(txtTenTK.Text.Trim(), Password))
            {
                IncrementLoginCount();

                IDNguoiDung = nguoiDungBUS.idNguoiDung(txtTenTK.Text, Password);
                hoTen = nguoiDungBUS.userNameBUS(txtTenTK.Text, Password);
                string emailND = nguoiDungBUS.emailBUS(txtTenTK.Text);

                this.Hide();
                frmLoading frm = new frmLoading()
                {
                    idUser = IDNguoiDung,
                    imageUser = linkAnh,
                    nameUser = txtTenTK.Text,
                    fullNameUser = hoTen,
                    emailUser = emailND,
                };
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // biến dữ liệu
        public string linkAnh;
        public string tenDangNhap;
        public int IDNguoiDung;
        public string hoTen;

        // sự kiên khác
        private void lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmDangKy dangKy = new frmDangKy();
            dangKy.Show();
        }

        string folderPath = "../../image";
        public void loadAnh(string path)
        {
            if (File.Exists(folderPath + "/" + path))
            {
                // chuyển hình thành dữ liệu byte
                byte[] byteHA = File.ReadAllBytes(folderPath + "/" + path);
                // chuyển dữ liệu thành đối tượng MemoryStream cho việc chuyển dữ liệu
                MemoryStream mos = new MemoryStream(byteHA);
                // Tạo đối tượng Image từ MemoryStream
                pbAnhUser.Image = Image.FromStream(mos);

                mos.Close();
                mos.Dispose();
                System.GC.Collect();
            }
            else
            {
                pbAnhUser.Image = null;
            }
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chkHienMK.Checked ? '\0' : '*';
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            string Password = Utils.GetMD5(txtMatKhau.Text);

            linkAnh = nguoiDungBUS.linkImageBUS(txtTenTK.Text, Password);
            if (linkAnh != null)
                loadAnh(linkAnh);
            else
                linkAnh = string.Empty;
        }

        private void lblQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string emailND = nguoiDungBUS.emailBUS(txtTenTK.Text);

            if (txtTenTK.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (emailND != null)
            {
                this.Hide();
                frmQuenMK quenMK = new frmQuenMK();
                quenMK.idUser = IDNguoiDung;
                quenMK.email = emailND;
                quenMK.Show();
            }

        }

        private void txtTenTK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) // Kiểm tra Ctrl + V (phím tắt cho paste)
            {
                MessageBox.Show("Không được phép dán dữ liệu vào ô này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTK.Text = string.Empty;
            }
        }

        private void txtTenTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
