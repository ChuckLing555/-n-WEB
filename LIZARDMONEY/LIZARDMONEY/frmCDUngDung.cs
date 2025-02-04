using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace LIZARDMONEY
{
    public partial class frmCDUngDung : Form
    {
        public delegate void dlgNgonNgu(string account, string appli, string phan, string bm, string chi);
        public delegate void dlgNgonNguTK(string tttk, string dmk, string tenTk, string email, string hoTen, string capNhat, string mkc, string mkm, string nhaplaimk, string hienMK, string doiMK, string xoaTK);
        //public delegate void dlgNgonNguPH(string nd, string hoTen, string email, string dongGop, string gui);

        public dlgNgonNgu cdNgonNguDL;
        public dlgNgonNguTK cdNgonNguTK;
        //public dlgNgonNgu cdNgonNguPH;


        public string selectedLanguage;
        private CultureInfo ngonNgu;
        public Form parentFrom;

        public frmCDUngDung()
        {
            InitializeComponent();
            ngonNgu = CultureInfo.CurrentCulture;
            cboNgonNgu.Items.Add("Tiếng việt");
            cboNgonNgu.Items.Add("English");
            cboNgonNgu.SelectedItem = "Tiếng việt";
            cboNgonNgu.SelectedIndexChanged += cboNgonNgu_SelectedIndexChanged;
        }

        private void SetLanguage(string SetNgonNgu)
        {
            ngonNgu = CultureInfo.CreateSpecificCulture(SetNgonNgu);
            ResourceManager rm = new ResourceManager("LIZARDMONEY.Lang.MyResource", typeof(frmCaiDat).Assembly);

            labelNN.Text = rm.GetString("show", ngonNgu);
            labelNN1.Text = rm.GetString("show1", ngonNgu);
            lbMH.Text = rm.GetString("MH", ngonNgu);
            lbMH1.Text = rm.GetString("MH1", ngonNgu);
            lbMenu.Text = rm.GetString("Menu", ngonNgu);
            lbMenu1.Text = rm.GetString("Menu1", ngonNgu);
            lbKhoiDong.Text = rm.GetString("KD", ngonNgu);
            lbKhoiDong1.Text = rm.GetString("KD1", ngonNgu);
            btnKhoiDongLai.Text = rm.GetString("btnKhoiDong", ngonNgu);

            cdNgonNguDL?.Invoke(
                rm.GetString("btnTK", ngonNgu), 
                rm.GetString("btnUD", ngonNgu), 
                rm.GetString("btnPH", ngonNgu), 
                rm.GetString("btnBM", ngonNgu), 
                rm.GetString("btnCT", ngonNgu));
            cdNgonNguTK?.Invoke(
                rm.GetString("grpTTTK", ngonNgu),
                rm.GetString("grpDoiMK", ngonNgu),
                rm.GetString("lbTenTk", ngonNgu),
                rm.GetString("lbEmail", ngonNgu),
                rm.GetString("lbHoTen", ngonNgu),
                rm.GetString("btnCapNhatTk", ngonNgu),
                rm.GetString("lbMkc", ngonNgu),
                rm.GetString("lbMkm", ngonNgu),
                rm.GetString("lbNhapLaiMK", ngonNgu),
                rm.GetString("cboHienMK", ngonNgu),
                rm.GetString("btnDoiMK", ngonNgu),
                rm.GetString("btnXoaTK", ngonNgu));
            //cdNgonNguPH?.Invoke(
            //    rm.GetString("lbND", ngonNgu),
            //    rm.GetString("lbHoTenPH", ngonNgu),
            //    rm.GetString("lbEmailPH", ngonNgu),
            //    rm.GetString("lbDongGopPH", ngonNgu),
            //    rm.GetString("btnGuiPH", ngonNgu)
            //    );
        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonNgonNgu = cboNgonNgu.SelectedItem.ToString();
            if (chonNgonNgu == "Tiếng việt")
            {
                SetLanguage("vi-VN");
                selectedLanguage = "Tiếng việt";
            }
            else if (chonNgonNgu == "English")
            {
                SetLanguage("en-US");
                selectedLanguage = "English";
            }
        }
    }
}
