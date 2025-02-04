using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace LIZARDMONEY
{
    public partial class frmADPhanHoi : Form
    {
        PhanHoiAdminBUS qlctBUS = new PhanHoiAdminBUS();
        public frmADPhanHoi()
        {
            InitializeComponent();
            dgvDSPH.AutoGenerateColumns = false;
        }

        private void frmADPhanHoi_Load(object sender, EventArgs e)
        {
            dgvDSPH.DataSource = qlctBUS.layDSBUS();

            if (dgvDSPH.Rows.Count > 0)
            {
                txtTenND.Text = dgvDSPH.Rows[0].Cells[0].Value?.ToString() ?? "";
                txtEmail.Text = dgvDSPH.Rows[0].Cells[1].Value?.ToString() ?? "";
                txtYKien.Text = dgvDSPH.Rows[0].Cells[2].Value?.ToString() ?? "";
            }
        }

        private void dgvDSND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow selectedRow = dgvDSPH.Rows[e.RowIndex];
            txtTenND.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
            txtEmail.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
            txtYKien.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
        }

    }
}
