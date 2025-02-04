namespace LIZARDMONEY
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnMini = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbAnhND = new System.Windows.Forms.PictureBox();
            this.lblGio = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.btnXuatBC = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDangXuat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCaiDat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThongKe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnKhoanVay = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnThuNhap = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnChiTieu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnViTien = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTrangChu = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gBody = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.lblUserName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblLogo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.timerNgayGio = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBody.Panel)).BeginInit();
            this.gBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMini
            // 
            this.btnMini.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMini.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.btnMini.Location = new System.Drawing.Point(1053, -1);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(40, 40);
            this.btnMini.TabIndex = 3;
            this.btnMini.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Values.Image")));
            this.btnMini.Values.Text = "";
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.FormClose;
            this.btnClose.Location = new System.Drawing.Point(1099, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Values.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Values.Image")));
            this.btnClose.Values.Text = "";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gBody);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 698);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.panel3.Controls.Add(this.pbAnhND);
            this.panel3.Controls.Add(this.lblGio);
            this.panel3.Controls.Add(this.lblNgay);
            this.panel3.Controls.Add(this.btnXuatBC);
            this.panel3.Controls.Add(this.btnDangXuat);
            this.panel3.Controls.Add(this.btnCaiDat);
            this.panel3.Controls.Add(this.btnThongKe);
            this.panel3.Controls.Add(this.btnKhoanVay);
            this.panel3.Controls.Add(this.btnThuNhap);
            this.panel3.Controls.Add(this.btnChiTieu);
            this.panel3.Controls.Add(this.btnViTien);
            this.panel3.Controls.Add(this.btnTrangChu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 698);
            this.panel3.TabIndex = 13;
            // 
            // pbAnhND
            // 
            this.pbAnhND.Location = new System.Drawing.Point(83, 6);
            this.pbAnhND.Name = "pbAnhND";
            this.pbAnhND.Size = new System.Drawing.Size(100, 100);
            this.pbAnhND.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnhND.TabIndex = 32;
            this.pbAnhND.TabStop = false;
            // 
            // lblGio
            // 
            this.lblGio.AutoSize = true;
            this.lblGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGio.Location = new System.Drawing.Point(192, 673);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(29, 16);
            this.lblGio.TabIndex = 31;
            this.lblGio.Text = "giờ";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(9, 673);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(41, 16);
            this.lblNgay.TabIndex = 30;
            this.lblNgay.Text = "ngày";
            // 
            // btnXuatBC
            // 
            this.btnXuatBC.Location = new System.Drawing.Point(12, 475);
            this.btnXuatBC.Name = "btnXuatBC";
            this.btnXuatBC.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnXuatBC.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.OverrideDefault.Back.ColorAngle = 1F;
            this.btnXuatBC.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.OverrideDefault.Border.ColorAngle = 1F;
            this.btnXuatBC.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatBC.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXuatBC.OverrideDefault.Border.Rounding = 25;
            this.btnXuatBC.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnXuatBC.Size = new System.Drawing.Size(231, 55);
            this.btnXuatBC.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnXuatBC.StateCommon.Back.ColorAngle = 1F;
            this.btnXuatBC.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnXuatBC.StateCommon.Border.ColorAngle = 1F;
            this.btnXuatBC.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatBC.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXuatBC.StateCommon.Border.Rounding = 25;
            this.btnXuatBC.StateCommon.Content.AdjacentGap = 10;
            this.btnXuatBC.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 25, -1);
            this.btnXuatBC.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatBC.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnXuatBC.StatePressed.Back.ColorAngle = 135F;
            this.btnXuatBC.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StatePressed.Border.ColorAngle = 135F;
            this.btnXuatBC.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatBC.StatePressed.Border.Rounding = 25;
            this.btnXuatBC.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnXuatBC.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StateTracking.Back.ColorAngle = 1F;
            this.btnXuatBC.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnXuatBC.StateTracking.Border.ColorAngle = 1F;
            this.btnXuatBC.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXuatBC.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnXuatBC.StateTracking.Border.Rounding = 25;
            this.btnXuatBC.TabIndex = 29;
            this.btnXuatBC.Values.Image = global::LIZARDMONEY.Properties.Resources._002_upload;
            this.btnXuatBC.Values.Text = "Báo cáo";
            this.btnXuatBC.Click += new System.EventHandler(this.btnXuatBC_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(12, 597);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnDangXuat.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.OverrideDefault.Back.ColorAngle = 1F;
            this.btnDangXuat.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.OverrideDefault.Border.ColorAngle = 1F;
            this.btnDangXuat.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangXuat.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDangXuat.OverrideDefault.Border.Rounding = 25;
            this.btnDangXuat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnDangXuat.Size = new System.Drawing.Size(231, 55);
            this.btnDangXuat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnDangXuat.StateCommon.Back.ColorAngle = 1F;
            this.btnDangXuat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnDangXuat.StateCommon.Border.ColorAngle = 1F;
            this.btnDangXuat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangXuat.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDangXuat.StateCommon.Border.Rounding = 25;
            this.btnDangXuat.StateCommon.Content.AdjacentGap = 10;
            this.btnDangXuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnDangXuat.StatePressed.Back.ColorAngle = 135F;
            this.btnDangXuat.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StatePressed.Border.ColorAngle = 135F;
            this.btnDangXuat.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangXuat.StatePressed.Border.Rounding = 25;
            this.btnDangXuat.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnDangXuat.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StateTracking.Back.ColorAngle = 1F;
            this.btnDangXuat.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnDangXuat.StateTracking.Border.ColorAngle = 1F;
            this.btnDangXuat.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangXuat.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDangXuat.StateTracking.Border.Rounding = 25;
            this.btnDangXuat.TabIndex = 28;
            this.btnDangXuat.Values.Image = global::LIZARDMONEY.Properties.Resources._017_exit;
            this.btnDangXuat.Values.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Location = new System.Drawing.Point(12, 536);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnCaiDat.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.OverrideDefault.Back.ColorAngle = 1F;
            this.btnCaiDat.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.OverrideDefault.Border.ColorAngle = 1F;
            this.btnCaiDat.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCaiDat.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCaiDat.OverrideDefault.Border.Rounding = 25;
            this.btnCaiDat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnCaiDat.Size = new System.Drawing.Size(231, 55);
            this.btnCaiDat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnCaiDat.StateCommon.Back.ColorAngle = 1F;
            this.btnCaiDat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnCaiDat.StateCommon.Border.ColorAngle = 1F;
            this.btnCaiDat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCaiDat.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCaiDat.StateCommon.Border.Rounding = 25;
            this.btnCaiDat.StateCommon.Content.AdjacentGap = 10;
            this.btnCaiDat.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 30, -1);
            this.btnCaiDat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnCaiDat.StatePressed.Back.ColorAngle = 135F;
            this.btnCaiDat.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StatePressed.Border.ColorAngle = 135F;
            this.btnCaiDat.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCaiDat.StatePressed.Border.Rounding = 25;
            this.btnCaiDat.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnCaiDat.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StateTracking.Back.ColorAngle = 1F;
            this.btnCaiDat.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnCaiDat.StateTracking.Border.ColorAngle = 1F;
            this.btnCaiDat.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCaiDat.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnCaiDat.StateTracking.Border.Rounding = 25;
            this.btnCaiDat.TabIndex = 27;
            this.btnCaiDat.Values.Image = global::LIZARDMONEY.Properties.Resources._002_gear;
            this.btnCaiDat.Values.Text = "Cài đặt";
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(12, 414);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThongKe.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.OverrideDefault.Back.ColorAngle = 1F;
            this.btnThongKe.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.OverrideDefault.Border.ColorAngle = 1F;
            this.btnThongKe.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThongKe.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThongKe.OverrideDefault.Border.Rounding = 25;
            this.btnThongKe.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnThongKe.Size = new System.Drawing.Size(231, 55);
            this.btnThongKe.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThongKe.StateCommon.Back.ColorAngle = 1F;
            this.btnThongKe.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThongKe.StateCommon.Border.ColorAngle = 1F;
            this.btnThongKe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThongKe.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThongKe.StateCommon.Border.Rounding = 25;
            this.btnThongKe.StateCommon.Content.AdjacentGap = 10;
            this.btnThongKe.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThongKe.StatePressed.Back.ColorAngle = 135F;
            this.btnThongKe.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StatePressed.Border.ColorAngle = 135F;
            this.btnThongKe.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThongKe.StatePressed.Border.Rounding = 25;
            this.btnThongKe.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThongKe.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StateTracking.Back.ColorAngle = 1F;
            this.btnThongKe.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThongKe.StateTracking.Border.ColorAngle = 1F;
            this.btnThongKe.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThongKe.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThongKe.StateTracking.Border.Rounding = 25;
            this.btnThongKe.TabIndex = 26;
            this.btnThongKe.Values.Image = global::LIZARDMONEY.Properties.Resources._001_bar_chart;
            this.btnThongKe.Values.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnKhoanVay
            // 
            this.btnKhoanVay.Location = new System.Drawing.Point(12, 353);
            this.btnKhoanVay.Name = "btnKhoanVay";
            this.btnKhoanVay.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnKhoanVay.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.OverrideDefault.Back.ColorAngle = 1F;
            this.btnKhoanVay.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.OverrideDefault.Border.ColorAngle = 1F;
            this.btnKhoanVay.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKhoanVay.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnKhoanVay.OverrideDefault.Border.Rounding = 25;
            this.btnKhoanVay.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnKhoanVay.Size = new System.Drawing.Size(231, 55);
            this.btnKhoanVay.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnKhoanVay.StateCommon.Back.ColorAngle = 1F;
            this.btnKhoanVay.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnKhoanVay.StateCommon.Border.ColorAngle = 1F;
            this.btnKhoanVay.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKhoanVay.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnKhoanVay.StateCommon.Border.Rounding = 25;
            this.btnKhoanVay.StateCommon.Content.AdjacentGap = 10;
            this.btnKhoanVay.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoanVay.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnKhoanVay.StatePressed.Back.ColorAngle = 135F;
            this.btnKhoanVay.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StatePressed.Border.ColorAngle = 135F;
            this.btnKhoanVay.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKhoanVay.StatePressed.Border.Rounding = 25;
            this.btnKhoanVay.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnKhoanVay.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StateTracking.Back.ColorAngle = 1F;
            this.btnKhoanVay.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnKhoanVay.StateTracking.Border.ColorAngle = 1F;
            this.btnKhoanVay.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnKhoanVay.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnKhoanVay.StateTracking.Border.Rounding = 25;
            this.btnKhoanVay.TabIndex = 25;
            this.btnKhoanVay.Values.Image = global::LIZARDMONEY.Properties.Resources._014_borrow;
            this.btnKhoanVay.Values.Text = "Khoản vay";
            this.btnKhoanVay.Click += new System.EventHandler(this.btnKhoanVay_Click);
            // 
            // btnThuNhap
            // 
            this.btnThuNhap.Location = new System.Drawing.Point(12, 292);
            this.btnThuNhap.Name = "btnThuNhap";
            this.btnThuNhap.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThuNhap.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.OverrideDefault.Back.ColorAngle = 1F;
            this.btnThuNhap.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.OverrideDefault.Border.ColorAngle = 1F;
            this.btnThuNhap.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThuNhap.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThuNhap.OverrideDefault.Border.Rounding = 25;
            this.btnThuNhap.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnThuNhap.Size = new System.Drawing.Size(231, 55);
            this.btnThuNhap.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThuNhap.StateCommon.Back.ColorAngle = 1F;
            this.btnThuNhap.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThuNhap.StateCommon.Border.ColorAngle = 1F;
            this.btnThuNhap.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThuNhap.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThuNhap.StateCommon.Border.Rounding = 25;
            this.btnThuNhap.StateCommon.Content.AdjacentGap = 10;
            this.btnThuNhap.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 5, -1);
            this.btnThuNhap.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuNhap.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThuNhap.StatePressed.Back.ColorAngle = 135F;
            this.btnThuNhap.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StatePressed.Border.ColorAngle = 135F;
            this.btnThuNhap.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThuNhap.StatePressed.Border.Rounding = 25;
            this.btnThuNhap.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnThuNhap.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StateTracking.Back.ColorAngle = 1F;
            this.btnThuNhap.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnThuNhap.StateTracking.Border.ColorAngle = 1F;
            this.btnThuNhap.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnThuNhap.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnThuNhap.StateTracking.Border.Rounding = 25;
            this.btnThuNhap.TabIndex = 24;
            this.btnThuNhap.Values.Image = global::LIZARDMONEY.Properties.Resources._020_business_and_finance;
            this.btnThuNhap.Values.Text = "Thu nhập";
            this.btnThuNhap.Click += new System.EventHandler(this.btnThuNhap_Click);
            // 
            // btnChiTieu
            // 
            this.btnChiTieu.Location = new System.Drawing.Point(12, 231);
            this.btnChiTieu.Name = "btnChiTieu";
            this.btnChiTieu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnChiTieu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.OverrideDefault.Back.ColorAngle = 1F;
            this.btnChiTieu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.OverrideDefault.Border.ColorAngle = 1F;
            this.btnChiTieu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChiTieu.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChiTieu.OverrideDefault.Border.Rounding = 25;
            this.btnChiTieu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnChiTieu.Size = new System.Drawing.Size(231, 55);
            this.btnChiTieu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnChiTieu.StateCommon.Back.ColorAngle = 1F;
            this.btnChiTieu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnChiTieu.StateCommon.Border.ColorAngle = 1F;
            this.btnChiTieu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChiTieu.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChiTieu.StateCommon.Border.Rounding = 25;
            this.btnChiTieu.StateCommon.Content.AdjacentGap = 10;
            this.btnChiTieu.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 25, -1);
            this.btnChiTieu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTieu.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnChiTieu.StatePressed.Back.ColorAngle = 135F;
            this.btnChiTieu.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StatePressed.Border.ColorAngle = 135F;
            this.btnChiTieu.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChiTieu.StatePressed.Border.Rounding = 25;
            this.btnChiTieu.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnChiTieu.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StateTracking.Back.ColorAngle = 1F;
            this.btnChiTieu.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnChiTieu.StateTracking.Border.ColorAngle = 1F;
            this.btnChiTieu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChiTieu.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnChiTieu.StateTracking.Border.Rounding = 25;
            this.btnChiTieu.TabIndex = 23;
            this.btnChiTieu.Values.Image = global::LIZARDMONEY.Properties.Resources._016_economic;
            this.btnChiTieu.Values.Text = "Chi tiêu";
            this.btnChiTieu.Click += new System.EventHandler(this.btnChiTieu_Click);
            // 
            // btnViTien
            // 
            this.btnViTien.Location = new System.Drawing.Point(12, 170);
            this.btnViTien.Name = "btnViTien";
            this.btnViTien.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnViTien.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.OverrideDefault.Back.ColorAngle = 1F;
            this.btnViTien.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.OverrideDefault.Border.ColorAngle = 1F;
            this.btnViTien.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViTien.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnViTien.OverrideDefault.Border.Rounding = 25;
            this.btnViTien.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnViTien.Size = new System.Drawing.Size(231, 55);
            this.btnViTien.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnViTien.StateCommon.Back.ColorAngle = 1F;
            this.btnViTien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnViTien.StateCommon.Border.ColorAngle = 1F;
            this.btnViTien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViTien.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnViTien.StateCommon.Border.Rounding = 25;
            this.btnViTien.StateCommon.Content.AdjacentGap = 10;
            this.btnViTien.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, 33, -1);
            this.btnViTien.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViTien.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnViTien.StatePressed.Back.ColorAngle = 135F;
            this.btnViTien.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StatePressed.Border.ColorAngle = 135F;
            this.btnViTien.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViTien.StatePressed.Border.Rounding = 25;
            this.btnViTien.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnViTien.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StateTracking.Back.ColorAngle = 1F;
            this.btnViTien.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnViTien.StateTracking.Border.ColorAngle = 1F;
            this.btnViTien.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnViTien.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnViTien.StateTracking.Border.Rounding = 25;
            this.btnViTien.TabIndex = 22;
            this.btnViTien.Values.Image = global::LIZARDMONEY.Properties.Resources._018_wallet;
            this.btnViTien.Values.Text = "Ví tiền";
            this.btnViTien.Click += new System.EventHandler(this.btnViTien_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Location = new System.Drawing.Point(12, 109);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnTrangChu.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.OverrideDefault.Back.ColorAngle = 1F;
            this.btnTrangChu.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.OverrideDefault.Border.ColorAngle = 1F;
            this.btnTrangChu.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangChu.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTrangChu.OverrideDefault.Border.Rounding = 25;
            this.btnTrangChu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnTrangChu.Size = new System.Drawing.Size(231, 55);
            this.btnTrangChu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnTrangChu.StateCommon.Back.ColorAngle = 1F;
            this.btnTrangChu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnTrangChu.StateCommon.Border.ColorAngle = 1F;
            this.btnTrangChu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangChu.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTrangChu.StateCommon.Border.Rounding = 25;
            this.btnTrangChu.StateCommon.Content.AdjacentGap = 10;
            this.btnTrangChu.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnTrangChu.StatePressed.Back.ColorAngle = 135F;
            this.btnTrangChu.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StatePressed.Border.ColorAngle = 135F;
            this.btnTrangChu.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangChu.StatePressed.Border.Rounding = 25;
            this.btnTrangChu.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(231)))), ((int)(((byte)(184)))));
            this.btnTrangChu.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StateTracking.Back.ColorAngle = 1F;
            this.btnTrangChu.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.btnTrangChu.StateTracking.Border.ColorAngle = 1F;
            this.btnTrangChu.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTrangChu.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnTrangChu.StateTracking.Border.Rounding = 25;
            this.btnTrangChu.TabIndex = 21;
            this.btnTrangChu.Values.Image = global::LIZARDMONEY.Properties.Resources._003_house;
            this.btnTrangChu.Values.Text = "Trang chủ";
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // gBody
            // 
            this.gBody.Location = new System.Drawing.Point(249, 0);
            this.gBody.Name = "gBody";
            this.gBody.Size = new System.Drawing.Size(891, 698);
            this.gBody.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.gBody.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.gBody.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.gBody.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.gBody.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.gBody.StateCommon.Border.Rounding = 20;
            this.gBody.StateCommon.Border.Width = 5;
            this.gBody.TabIndex = 14;
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonGroup1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonGroup1.Location = new System.Drawing.Point(0, 0);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.lblUserName);
            this.kryptonGroup1.Panel.Controls.Add(this.lblLogo);
            this.kryptonGroup1.Panel.Controls.Add(this.btnMini);
            this.kryptonGroup1.Panel.Controls.Add(this.btnClose);
            this.kryptonGroup1.Size = new System.Drawing.Size(1140, 57);
            this.kryptonGroup1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(245)))), ((int)(((byte)(205)))));
            this.kryptonGroup1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(255)))), ((int)(((byte)(239)))));
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.TabIndex = 15;
            // 
            // lblUserName
            // 
            this.lblUserName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblUserName.Location = new System.Drawing.Point(248, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(257, 36);
            this.lblUserName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Values.Image = global::LIZARDMONEY.Properties.Resources.chameleon;
            this.lblUserName.Values.Text = "LIZARD MONEY";
            // 
            // lblLogo
            // 
            this.lblLogo.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblLogo.Location = new System.Drawing.Point(3, 11);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(280, 44);
            this.lblLogo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.TabIndex = 4;
            this.lblLogo.Values.Text = "LIZARD MONEY";
            // 
            // timerNgayGio
            // 
            this.timerNgayGio.Tick += new System.EventHandler(this.timerNgayGio_Tick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonGroup1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIZARD MONEY";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBody.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gBody)).EndInit();
            this.gBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnMini;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup gBody;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTrangChu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChiTieu;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnViTien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDangXuat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCaiDat;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThongKe;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnKhoanVay;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnThuNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblLogo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnXuatBC;
        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Timer timerNgayGio;
        private System.Windows.Forms.PictureBox pbAnhND;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUserName;
    }
}