using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace LIZARDMONEY
{
    public partial class MainAdmin : KryptonForm
    {
        public MainAdmin()
        {
            InitializeComponent();

            colorButton(btnQuanLy);
            openChildForm(new frmADQuanLy());
        }

        private Form childFormAdim;
        private KryptonButton btnAD;

        private void openChildForm(Form nameChildFormAD)
        {
            if (childFormAdim != null)
            {
                childFormAdim.Close();
            }

            childFormAdim = nameChildFormAD;
            nameChildFormAD.TopLevel = false;
            nameChildFormAD.Dock = DockStyle.Fill;
            gBody.Panel.Controls.Add(nameChildFormAD);
            nameChildFormAD.BringToFront();
            nameChildFormAD.Show();
        }

        private void colorButton(KryptonButton button)
        {
            if (btnAD != null)// neu button khong duoc click
            {
                btnAD.StateCommon.Back.Color1 = Color.FromArgb(227, 255, 239);
                btnAD.StateCommon.Back.Color2 = Color.FromArgb(147, 231, 184);
            }
            btnAD = button;// duoc click
            button.StateCommon.Back.Color1 = Color.FromArgb(147, 231, 184);
            button.StateCommon.Back.Color2 = Color.FromArgb(227, 255, 239);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            colorButton(btnQuanLy);
            openChildForm(new frmADQuanLy());
        }

        private void btnPhanTich_Click(object sender, EventArgs e)
        {
            colorButton(btnPhanTich);
            openChildForm(new frmADPhanTich());
        }

        private void btnChiTieu_Click(object sender, EventArgs e)
        {
            colorButton(btnChiTieu);
            openChildForm(new frmADLoaiChiTieu());
        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            colorButton(btnPhanHoi);
            openChildForm(new frmADPhanHoi());
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {
            timerNgayGio.Enabled = true;
        }

        private void timerNgayGio_Tick(object sender, EventArgs e)
        {
            lblNgay.Text = DateTime.Now.ToShortDateString();
            lblGio.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
