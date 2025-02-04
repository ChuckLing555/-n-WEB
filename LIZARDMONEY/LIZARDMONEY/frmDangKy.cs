using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using _0306221404;
using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using static System.Net.WebRequestMethods;

namespace LIZARDMONEY
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
        }

        // gọi BUS 
        userDangKyBUS nguoiDungBUS = new userDangKyBUS();
        userDangNhapBUS dangNhap = new userDangNhapBUS();
        Random rdOTP = new Random();
        int otp;
        int otpnhap;


        // sự kiện button 
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {

            // Tạo đối tượng đọc hình ảnh
            Stream myStream = null;

            // Mặc định OpenFileDialog mở ổ đĩa C:\
            ofdFile.InitialDirectory = "C:\\";
            // Lọc những loại tập tin có thể mở được (trong bài này là hình ảnh)
            ofdFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofdFile.FilterIndex = 2;
            ofdFile.RestoreDirectory = true;

            // Hiển thị hộp thoại
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Tập tin tồn tại
                    if ((myStream = ofdFile.OpenFile()) != null)
                    {
                        // Đọc tập tin và hiển thị PictureBox
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            pbAnhUser.Image = Image.FromStream(myStream);

                        }
                    }
                }
                catch (Exception ex) // Thông báo lỗi trong trường hợp đọc hình ảnh
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

                myStream.Close();
                myStream.Dispose();
                System.GC.Collect();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // ràng buộc
            if (pbAnhUser.Image == null || string.IsNullOrEmpty(txtHoTen.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMatKhau.Text)
                || txtNhapLaiMK.Text ==  null || txtTenTK.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtEmail.Text.Trim().Length == 0 || txtHoTen.Text.Trim().Length == 0 || txtTenTK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(dangNhap.idNguoiDung(txtTenTK.Text, txtNhapLaiMK.Text) > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dangNhap.idNguoiDungEmail(txtEmail.Text) > 0)
            {
                MessageBox.Show("Email đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dangNhap.emailBUS(txtTenTK.Text) != null)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhau.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ktEmail())
            {
                MessageBox.Show("Định dạng Email sai.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ktTenTaiKhoan())
            {
                MessageBox.Show("Định dạng tên tài khoản sai.\nTài khoản không được chứa ký tự đặt biệt và khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ktMatKhau())
            {
                MessageBox.Show("Định dạng mật khẩu sai.\nMật khẩu bao gồm 4 chữ số trở lên, chứa ký tự đặt biệt và không chứa khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtOtpXN.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập mã xác nhận.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtOtpXN.Text != otpnhap.ToString())
            {
                MessageBox.Show("Mã xác nhận không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //-----------------------------------------------------------------------------
            using (MemoryStream memory = new MemoryStream())
            {
                using (FileStream fs = new FileStream(folderPath + "/" + txtEmail.Text + ".jpg",
                    FileMode.Create, FileAccess.ReadWrite))
                {
                    byte[] bytes = ConvertImageToByteArray(pbAnhUser.Image);
                    fs.Write(bytes, 0, bytes.Length);
                }
            }

            var nguoiDung = new NguoiDungDTO
            {
                tenDangNhap = txtTenTK.Text,
                anhDaiDien = txtEmail.Text + ".jpg",
                matKhau = Utils.GetMD5(txtMatKhau.Text),
                hoTen = txtHoTen.Text,
                email = txtEmail.Text
            };


            if (nguoiDungBUS.dangKyBUS(nguoiDung))
            {
                this.Hide();
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.linkAnh = txtEmail.Text + ".jpg";
                dangNhap.tenDangNhap = txtTenTK.Text;
                dangNhap.Show();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại", ".Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //-----------------------------------------------------------------------------------
            
        }

        private void btnNhanMa_Click(object sender, EventArgs e)
        {
            try
            {
                otp = rdOTP.Next(100000, 1000000);
                otpnhap = otp;

                var fromAddress = new MailAddress("0306221495@caothang.edu.vn", "Lizard Money");
                var toAddress = new MailAddress(txtEmail.Text);
                const string fromPass = "xfwvrvfzpzghtrwf";//mshydqdwrkjygikv
                const string sub = "Mã OTP của bạn là: ";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = sub,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                MessageBox.Show("Mã đã được gửi về gmail của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // mở file ảnh và chuyển đổi ảnh
        string folderPath = "../../image";
        public byte[] ConvertImageToByteArray(Image imageToConvert)
        {
            using (var ms = new MemoryStream())
            {
                // Chuyển image sang kiểu bitmap
                Bitmap bmp = new Bitmap(imageToConvert);

                // Lưu bitmap thành MemoryStream cho việc lưu trữ ảnh
                bmp.Save(ms, ImageFormat.Jpeg);

                return ms.ToArray();
            }
        }

        // sự kiện khác
        private bool ktEmail()
        {
            string reEmail = @"^(?!.* )([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            if (Regex.IsMatch(txtEmail.Text, reEmail))
            {
                return true;
            }
            return false;
        }

        private bool ktTenTaiKhoan()
        {
            string reTenTK = @"^(?!.* )([\w]+)(?!.*\W)";
            if (Regex.IsMatch(txtTenTK.Text, reTenTK))
            {
                return true;
            }
            return false;
        }

        private bool ktMatKhau()
        {
            string reMatKhau = @"^(?!.* )(?=.*\W).{3,}$";

            if (Regex.IsMatch(txtMatKhau.Text, reMatKhau))
            {
                return true;
            }
            return false;
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtNhapLaiMK.PasswordChar = '\0';
                txtOtpXN.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
                txtNhapLaiMK.PasswordChar = '*';
                txtOtpXN.PasswordChar = '*';
            }
        }

        private void txtTenTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ràng khoảng trắngg
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
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

    }
}
