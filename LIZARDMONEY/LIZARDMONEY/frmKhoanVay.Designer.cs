namespace LIZARDMONEY
{
    partial class frmKhoanVay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rdoMuon = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rdoVay = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayMuon = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpNgayTra = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtGhiChu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.cboLoaiVi = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txtSoTien = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtNguoiNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNguoi = new System.Windows.Forms.Label();
            this.lblDS = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvVayNo = new System.Windows.Forms.DataGridView();
            this.colMaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViTien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayVay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVayNo)).BeginInit();
            this.SuspendLayout();
            // 
            // rdoMuon
            // 
            this.rdoMuon.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.rdoMuon.Location = new System.Drawing.Point(123, 131);
            this.rdoMuon.Name = "rdoMuon";
            this.rdoMuon.Size = new System.Drawing.Size(97, 24);
            this.rdoMuon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMuon.TabIndex = 190;
            this.rdoMuon.Values.Text = "Mượn Nợ";
            this.rdoMuon.CheckedChanged += new System.EventHandler(this.rdoMuon_CheckedChanged);
            // 
            // rdoVay
            // 
            this.rdoVay.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.rdoVay.Location = new System.Drawing.Point(24, 131);
            this.rdoVay.Name = "rdoVay";
            this.rdoVay.Size = new System.Drawing.Size(93, 24);
            this.rdoVay.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVay.TabIndex = 189;
            this.rdoVay.Values.Text = "Cho Vay";
            this.rdoVay.CheckedChanged += new System.EventHandler(this.rdoVay_CheckedChanged);
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Location = new System.Drawing.Point(52, 54);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnLamMoi);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnSua);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnXoa);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnThem);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rdoMuon);
            this.kryptonGroupBox1.Panel.Controls.Add(this.rdoVay);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpNgayMuon);
            this.kryptonGroupBox1.Panel.Controls.Add(this.dtpNgayTra);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtGhiChu);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cboLoaiVi);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtSoTien);
            this.kryptonGroupBox1.Panel.Controls.Add(this.txtNguoiNo);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label8);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label7);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label6);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblNguoi);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(769, 193);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 20;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.TabIndex = 40;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnLamMoi.BackgroundImage = global::LIZARDMONEY.Properties.Resources.refresh1;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 5;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(424, 115);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(60, 60);
            this.btnLamMoi.TabIndex = 196;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnSua.BackgroundImage = global::LIZARDMONEY.Properties.Resources.eraser;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnSua.FlatAppearance.BorderSize = 5;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(292, 117);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 60);
            this.btnSua.TabIndex = 193;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnXoa.BackgroundImage = global::LIZARDMONEY.Properties.Resources.recycle_bin;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnXoa.FlatAppearance.BorderSize = 5;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(358, 117);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(60, 60);
            this.btnXoa.TabIndex = 194;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnThem.BackgroundImage = global::LIZARDMONEY.Properties.Resources.pencil;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnThem.FlatAppearance.BorderSize = 5;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(226, 118);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 60);
            this.btnThem.TabIndex = 195;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(498, 2);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(239, 29);
            this.dtpNgayMuon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.dtpNgayMuon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.dtpNgayMuon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.dtpNgayMuon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayMuon.StateCommon.Border.Rounding = 5;
            this.dtpNgayMuon.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.TabIndex = 188;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(498, 42);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(239, 29);
            this.dtpNgayTra.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.dtpNgayTra.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.dtpNgayTra.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.dtpNgayTra.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayTra.StateCommon.Border.Rounding = 5;
            this.dtpNgayTra.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.TabIndex = 187;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtGhiChu.Location = new System.Drawing.Point(498, 80);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(239, 68);
            this.txtGhiChu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtGhiChu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtGhiChu.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtGhiChu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGhiChu.StateCommon.Border.Rounding = 5;
            this.txtGhiChu.StateCommon.Border.Width = 1;
            this.txtGhiChu.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtGhiChu.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.TabIndex = 186;
            this.txtGhiChu.WordWrap = false;
            // 
            // cboLoaiVi
            // 
            this.cboLoaiVi.DropDownWidth = 203;
            this.cboLoaiVi.Location = new System.Drawing.Point(141, 42);
            this.cboLoaiVi.Name = "cboLoaiVi";
            this.cboLoaiVi.Size = new System.Drawing.Size(239, 29);
            this.cboLoaiVi.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.cboLoaiVi.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.cboLoaiVi.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.cboLoaiVi.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboLoaiVi.StateCommon.ComboBox.Border.Rounding = 5;
            this.cboLoaiVi.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiVi.TabIndex = 185;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(141, 80);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(239, 31);
            this.txtSoTien.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtSoTien.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtSoTien.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtSoTien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSoTien.StateCommon.Border.Rounding = 5;
            this.txtSoTien.StateCommon.Border.Width = 1;
            this.txtSoTien.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtSoTien.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.TabIndex = 184;
            this.txtSoTien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoTien_KeyDown);
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // txtNguoiNo
            // 
            this.txtNguoiNo.Location = new System.Drawing.Point(141, 3);
            this.txtNguoiNo.Name = "txtNguoiNo";
            this.txtNguoiNo.Size = new System.Drawing.Size(239, 31);
            this.txtNguoiNo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtNguoiNo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtNguoiNo.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtNguoiNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNguoiNo.StateCommon.Border.Rounding = 5;
            this.txtNguoiNo.StateCommon.Border.Width = 1;
            this.txtNguoiNo.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtNguoiNo.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoiNo.TabIndex = 183;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 178;
            this.label8.Text = "Ngày vay:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(402, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 177;
            this.label7.Text = "Ngày trả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 176;
            this.label6.Text = "Loại ví tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 175;
            this.label4.Text = "Ghi chú:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 174;
            this.label3.Text = "Số tiền:";
            // 
            // lblNguoi
            // 
            this.lblNguoi.AutoSize = true;
            this.lblNguoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.lblNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoi.Location = new System.Drawing.Point(20, 14);
            this.lblNguoi.Name = "lblNguoi";
            this.lblNguoi.Size = new System.Drawing.Size(115, 20);
            this.lblNguoi.TabIndex = 173;
            this.lblNguoi.Text = "Người nợ/ vay:";
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(250, 6);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(272, 25);
            this.lblDS.TabIndex = 6;
            this.lblDS.Text = "Danh Sách Khoản Vay/ Nợ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(287, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 36);
            this.label15.TabIndex = 39;
            this.label15.Text = "KHOẢN VAY/ NỢ";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(52, 259);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.dgvVayNo);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lblDS);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(769, 414);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 20;
            this.kryptonGroupBox2.StateCommon.Border.Width = 2;
            this.kryptonGroupBox2.TabIndex = 41;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // dgvVayNo
            // 
            this.dgvVayNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVayNo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVayNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVayNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVayNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaND,
            this.colTen,
            this.colViTien,
            this.colSoTien,
            this.colNgayVay,
            this.colNgayTra,
            this.colGhiChu});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVayNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVayNo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVayNo.GridColor = System.Drawing.Color.Green;
            this.dgvVayNo.Location = new System.Drawing.Point(0, 44);
            this.dgvVayNo.Name = "dgvVayNo";
            this.dgvVayNo.RowHeadersVisible = false;
            this.dgvVayNo.RowHeadersWidth = 51;
            this.dgvVayNo.RowTemplate.Height = 24;
            this.dgvVayNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVayNo.Size = new System.Drawing.Size(751, 352);
            this.dgvVayNo.TabIndex = 7;
            this.dgvVayNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVayNo_CellClick);
            // 
            // colMaND
            // 
            this.colMaND.DataPropertyName = "maKVT";
            this.colMaND.HeaderText = "Mã";
            this.colMaND.MinimumWidth = 6;
            this.colMaND.Name = "colMaND";
            this.colMaND.Visible = false;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "nguoiVayNo";
            this.colTen.HeaderText = "Tên";
            this.colTen.MinimumWidth = 6;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colViTien
            // 
            this.colViTien.DataPropertyName = "maTaiKhoan";
            this.colViTien.HeaderText = "Ví tiền";
            this.colViTien.MinimumWidth = 6;
            this.colViTien.Name = "colViTien";
            this.colViTien.ReadOnly = true;
            this.colViTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colViTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSoTien
            // 
            this.colSoTien.DataPropertyName = "soTien";
            this.colSoTien.HeaderText = "Số tiền";
            this.colSoTien.MinimumWidth = 6;
            this.colSoTien.Name = "colSoTien";
            this.colSoTien.ReadOnly = true;
            // 
            // colNgayVay
            // 
            this.colNgayVay.DataPropertyName = "ngayChoVay";
            this.colNgayVay.HeaderText = "Ngày vay";
            this.colNgayVay.MinimumWidth = 6;
            this.colNgayVay.Name = "colNgayVay";
            this.colNgayVay.ReadOnly = true;
            // 
            // colNgayTra
            // 
            this.colNgayTra.DataPropertyName = "ngayTraNo";
            this.colNgayTra.HeaderText = "Ngày trả";
            this.colNgayTra.MinimumWidth = 6;
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.ReadOnly = true;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "ghiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.MinimumWidth = 6;
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            // 
            // frmKhoanVay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 688);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhoanVay";
            this.Text = "frmKhoanVay";
            this.Load += new System.EventHandler(this.frmKhoanVay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVayNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoMuon;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoVay;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpNgayMuon;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpNgayTra;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtGhiChu;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboLoaiVi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSoTien;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNguoiNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNguoi;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Label label15;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.DataGridView dgvVayNo;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewComboBoxColumn colViTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayVay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
    }
}