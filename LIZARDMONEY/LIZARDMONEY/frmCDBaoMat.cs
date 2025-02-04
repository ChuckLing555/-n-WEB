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
    public partial class frmCDBaoMat : Form
    {
        public frmCDBaoMat()
        {
            InitializeComponent();
        }

        private void btnDoiMaPin_Click(object sender, EventArgs e)
        {
            frmCDDoiMaPin frmDoiPin = new frmCDDoiMaPin();
            frmDoiPin.Show();
        }
    }
}
