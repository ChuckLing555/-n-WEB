namespace LIZARDMONEY
{
    partial class frmXemBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.repBaoCao = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repBaoCao
            // 
            this.repBaoCao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.repBaoCao.LocalReport.ReportEmbeddedResource = "LIZARDMONEY.rpBaoCao.rdlc";
            this.repBaoCao.Location = new System.Drawing.Point(0, 0);
            this.repBaoCao.Name = "repBaoCao";
            this.repBaoCao.ServerReport.BearerToken = null;
            this.repBaoCao.ServerReport.ReportPath = "rpBaoCao.rdlc";
            this.repBaoCao.Size = new System.Drawing.Size(751, 369);
            this.repBaoCao.TabIndex = 1;
            // 
            // frmXemBaoCao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(751, 369);
            this.Controls.Add(this.repBaoCao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXemBaoCao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemBaoCao";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repBaoCao;
    }
}