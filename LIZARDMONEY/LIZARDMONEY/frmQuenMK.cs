using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIZARDMONEY
{
    public partial class frmQuenMK : Form
    {
        public frmQuenMK()
        {
            InitializeComponent();
        }
        private void frmQuenMK_Load(object sender, EventArgs e)
        {
            lblEmail.Text = "********************************";
        }

        public int idUser;
        Random rdOTP = new Random();
        int otp;
        public string email;
        userDangNhapBUS dnEmail = new userDangNhapBUS();

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            frmDangNhap dangNhap = new frmDangNhap();
            dangNhap.Show();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGuiYC_Click(object sender, EventArgs e)
        {
            if(email != txtEmail.Text)
            {
                MessageBox.Show("Email không trùng khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            idUser = dnEmail.idNguoiDungEmail(txtEmail.Text);

            try
            {
                otp = rdOTP.Next(100000, 1000000);

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
                DialogResult res = MessageBox.Show("Mã đã được gửi về gmail của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {
                    this.Hide();
                    frmMKMoi mkMoi = new frmMKMoi()
                    {
                        maOTP = otp.ToString(),
                        idNguoiDung = idUser
                    };
                    mkMoi.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
