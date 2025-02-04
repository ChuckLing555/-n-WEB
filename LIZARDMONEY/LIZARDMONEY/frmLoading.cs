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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        public string imageUser;
        public int idUser;
        public string nameUser;
        public string fullNameUser;
        public string emailUser;
        public Form trangChu;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pnLoad.Width += 8;
            if (pnLoad.Width >= 460)
            {
                timer1.Stop();

                Main main = new Main()
                {
                    linkAnh = imageUser,
                    idND = idUser,
                    tenND = nameUser,
                    hoTenND = fullNameUser,
                    emailND = emailUser
                };
                trangChu = main;
                main.trangchu1 = trangChu;
                main.Show();

                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            lbIcon.Left += 8;
            if (lbIcon.Left >= 456)
            {
                timer2.Stop();
            }
        }
    }
}
