using _0306221404;
using BUS;
using DTO;
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
using System.Drawing.Imaging;
using static LIZARDMONEY.frmCDUngDung;
using System.Text.RegularExpressions;

namespace LIZARDMONEY
{
    public partial class frmCDTaiKhoan : Form
    {
        public frmCDTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmCDTaiKhoan_Load(object sender, EventArgs e)
        {
            txtEmail.Text = emailCD;
            txtTenTK.Text = tenTKCD;
            txtHoTen.Text = tenNDCD;

            if (File.Exists(folderPath + "/" + taiAnh))
            {
                // chuyển hình thành dữ liệu byte
                byte[] byteHA = File.ReadAllBytes(folderPath + "/" + taiAnh);
                // chuyển dữ liệu thành đối tượng MemoryStream cho việc chuyển dữ liệu
                MemoryStream mos = new MemoryStream(byteHA);
                // Tạo đối tượng Image từ MemoryStream
                pbAnhUser.Image = Image.FromStream(mos);//

                mos.Close();
                mos.Dispose();
                System.GC.Collect();
            }
            else
            {
                pbAnhUser.Image = null;
            }
        }

        public string taiAnh;
        string folderPath = "../../image";
        public string emailCD;
        public string tenNDCD;
        public string tenTKCD;
        public int idNguoiDung;

        public delegate void dlgTenNguoiDung(string fullNameUser);
        public delegate void dlgLinkImage(string linkImg);
        public dlgTenNguoiDung fullNameUser;
        public dlgLinkImage linkImg;
        userDoiMatKhauBUS doiMK = new userDoiMatKhauBUS();
        NguoiDungBUS cdND = new NguoiDungBUS();

        public Form parentFrom;

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (fullNameUser != null)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(folderPath + "/" + txtEmail.Text + ".jpg",
                        FileMode.Create, FileAccess.ReadWrite))
                    {
                        byte[] bytes = ConvertImageToByteArray(pbAnhUser.Image);
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }

                var newTK = new NguoiDungDTO
                {
                    hoTen = txtHoTen.Text,
                    anhDaiDien = txtEmail.Text + ".jpg"
                };

                if (cdND.capNhatTTNDBUS(idNguoiDung, newTK))
                {

                    DialogResult res = MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        fullNameUser.Invoke(txtHoTen.Text);
                        linkImg.Invoke(txtEmail.Text + ".jpg");
                    }
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string Password = Utils.GetMD5(txtMKCu.Text);

            if (doiMK.layMatKhauBUS(idNguoiDung) != Password)
            {
                MessageBox.Show("Mật khẩu không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ktMatKhau())
            {
                MessageBox.Show("Mật khẩu không hợp lệ.\nMật khẩu bao gồm 4 chữ số trở lên, chứa ký tự đặt biệt và không chứa khoảng trắng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTK = new NguoiDungDTO
            {
                matKhau = Utils.GetMD5(txtMKMoi.Text)
            };

            if (doiMK.doiMatKhauBUS(idNguoiDung, newTK))
            {

                DialogResult res = MessageBox.Show("Đổi mật khẩu thành công. Bạn có muốn đăng nhập lại không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    closeParentForm();
                    frmDangNhap dangNhap = new frmDangNhap();
                    dangNhap.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            DialogResult resXoaTK = MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resXoaTK == DialogResult.OK)
            {
                frmXacNhanXoaTK frmXoa = new frmXacNhanXoaTK();
                frmXoa.idNguoiDung = idNguoiDung;
                frmXoa.parentFrom = parentFrom;
                frmXoa.Show();
            }
        }

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

        private void closeParentForm()
        {
            if (parentFrom != null)
            {
                this.Hide();
                parentFrom.Hide();
            }
            
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMKCu.PasswordChar = chkHienMK.Checked ? '\0' : '*';
            txtMKMoi.PasswordChar = chkHienMK.Checked ? '\0' : '*';
            txtNhapLai.PasswordChar = chkHienMK.Checked ? '\0' : '*';
        }

        public void SetLanguage(string tttk, string dmk, string tenTk, string email, string hoTen, string capNhat, string mkc, string mkm, string nhaplaimk, string hienMK, string doiMK, string xoaTK)
        {
            grpTTTK.Text = tttk;
            grpDoiMK.Text = dmk;
            lbTenTk.Text = tenTk;
            lbEmail.Text = email;
            lbHoVaTen.Text = hoTen;
            btnCapNhat.Text = capNhat;
            lbMkc.Text = mkc;
            lbMkm.Text = mkm;
            lbNhapLaiMk.Text = nhaplaimk;
            chkHienMK.Text = hienMK;
            btnDoiMatKhau.Text = doiMK;
            btnXoaTK.Text = xoaTK;
        }

        private bool ktMatKhau()
        {
            string reMatKhau = @"^(?!.* )(?=.*\W).{3,}$";

            if (Regex.IsMatch(txtMKMoi.Text, reMatKhau))
            {
                return true;
            }
            return false;
        }

    }
}
