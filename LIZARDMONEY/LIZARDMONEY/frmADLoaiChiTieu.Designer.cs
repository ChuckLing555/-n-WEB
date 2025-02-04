namespace LIZARDMONEY
{
    partial class frmADLoaiChiTieu
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.dgvDSCT = new System.Windows.Forms.DataGridView();
            this.colMaCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvDSTN = new System.Windows.Forms.DataGridView();
            this.colMaTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiTN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rdoThuNhap = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.grpThuNhap = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbThuNhap = new System.Windows.Forms.CheckBox();
            this.txtLoaiThuNhap = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMaThuNhap = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpChiTieu = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            this.txtLoaiCT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMaCT = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoChiTieu = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThuNhap.Panel)).BeginInit();
            this.grpThuNhap.Panel.SuspendLayout();
            this.grpThuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpChiTieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpChiTieu.Panel)).BeginInit();
            this.grpChiTieu.Panel.SuspendLayout();
            this.grpChiTieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "DANH SÁCH THU NHẬP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(506, 36);
            this.label8.TabIndex = 35;
            this.label8.Text = "THÊM LOẠI CHI TIÊU/ THU NHẬP";
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(449, 260);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.dgvDSTN);
            this.kryptonGroupBox3.Panel.Controls.Add(this.label7);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(372, 414);
            this.kryptonGroupBox3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox3.StateCommon.Border.Rounding = 20;
            this.kryptonGroupBox3.StateCommon.Border.Width = 2;
            this.kryptonGroupBox3.TabIndex = 36;
            this.kryptonGroupBox3.Values.Heading = "";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi Chú";
            this.columnHeader5.Width = 233;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "DANH SÁCH CHI TIÊU";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Location = new System.Drawing.Point(52, 54);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.rdoThuNhap);
            this.kryptonGroupBox2.Panel.Controls.Add(this.grpThuNhap);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnLamMoi);
            this.kryptonGroupBox2.Panel.Controls.Add(this.grpChiTieu);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnSua);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnXoa);
            this.kryptonGroupBox2.Panel.Controls.Add(this.btnThem);
            this.kryptonGroupBox2.Panel.Controls.Add(this.rdoChiTieu);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(769, 193);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 20;
            this.kryptonGroupBox2.StateCommon.Border.Width = 2;
            this.kryptonGroupBox2.TabIndex = 38;
            this.kryptonGroupBox2.Values.Heading = "";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(52, 260);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.dgvDSCT);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label9);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(385, 414);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(168)))), ((int)(((byte)(135)))));
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 20;
            this.kryptonGroupBox1.StateCommon.Border.Width = 2;
            this.kryptonGroupBox1.TabIndex = 37;
            this.kryptonGroupBox1.Values.Heading = "";
            // 
            // dgvDSCT
            // 
            this.dgvDSCT.AllowUserToResizeRows = false;
            this.dgvDSCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCT,
            this.colTenCT,
            this.colTrangThai});
            this.dgvDSCT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSCT.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(149)))));
            this.dgvDSCT.Location = new System.Drawing.Point(0, 48);
            this.dgvDSCT.Name = "dgvDSCT";
            this.dgvDSCT.RowHeadersVisible = false;
            this.dgvDSCT.RowHeadersWidth = 51;
            this.dgvDSCT.RowTemplate.Height = 24;
            this.dgvDSCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCT.Size = new System.Drawing.Size(367, 348);
            this.dgvDSCT.TabIndex = 37;
            this.dgvDSCT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSCT_CellClick);
            // 
            // colMaCT
            // 
            this.colMaCT.DataPropertyName = "maLoai";
            this.colMaCT.HeaderText = "Mã loại";
            this.colMaCT.MinimumWidth = 6;
            this.colMaCT.Name = "colMaCT";
            this.colMaCT.ReadOnly = true;
            // 
            // colTenCT
            // 
            this.colTenCT.DataPropertyName = "tenChiTieu";
            this.colTenCT.HeaderText = "Tên chi tiêu";
            this.colTenCT.MinimumWidth = 6;
            this.colTenCT.Name = "colTenCT";
            this.colTenCT.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "trangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // dgvDSTN
            // 
            this.dgvDSTN.AllowUserToResizeRows = false;
            this.dgvDSTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTN.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSTN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTN,
            this.colTenTN,
            this.colTrangThaiTN});
            this.dgvDSTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSTN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(98)))), ((int)(((byte)(149)))));
            this.dgvDSTN.Location = new System.Drawing.Point(0, 48);
            this.dgvDSTN.Name = "dgvDSTN";
            this.dgvDSTN.RowHeadersVisible = false;
            this.dgvDSTN.RowHeadersWidth = 51;
            this.dgvDSTN.RowTemplate.Height = 24;
            this.dgvDSTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSTN.Size = new System.Drawing.Size(354, 348);
            this.dgvDSTN.TabIndex = 37;
            this.dgvDSTN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTN_CellClick);
            // 
            // colMaTN
            // 
            this.colMaTN.DataPropertyName = "maLoai";
            this.colMaTN.HeaderText = "Mã loại";
            this.colMaTN.MinimumWidth = 6;
            this.colMaTN.Name = "colMaTN";
            this.colMaTN.ReadOnly = true;
            // 
            // colTenTN
            // 
            this.colTenTN.DataPropertyName = "tenThuNhap";
            this.colTenTN.HeaderText = "Tên thu nhập";
            this.colTenTN.MinimumWidth = 6;
            this.colTenTN.Name = "colTenTN";
            this.colTenTN.ReadOnly = true;
            // 
            // colTrangThaiTN
            // 
            this.colTrangThaiTN.DataPropertyName = "trangThai";
            this.colTrangThaiTN.HeaderText = "Trạng thái";
            this.colTrangThaiTN.MinimumWidth = 6;
            this.colTrangThaiTN.Name = "colTrangThaiTN";
            this.colTrangThaiTN.ReadOnly = true;
            this.colTrangThaiTN.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThaiTN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rdoThuNhap
            // 
            this.rdoThuNhap.Location = new System.Drawing.Point(376, 0);
            this.rdoThuNhap.Name = "rdoThuNhap";
            this.rdoThuNhap.Size = new System.Drawing.Size(100, 24);
            this.rdoThuNhap.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.rdoThuNhap.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.rdoThuNhap.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoThuNhap.TabIndex = 194;
            this.rdoThuNhap.Values.Text = "Thu nhập";
            this.rdoThuNhap.CheckedChanged += new System.EventHandler(this.rdoThuNhap_CheckedChanged);
            // 
            // grpThuNhap
            // 
            this.grpThuNhap.Location = new System.Drawing.Point(376, 22);
            this.grpThuNhap.Name = "grpThuNhap";
            // 
            // grpThuNhap.Panel
            // 
            this.grpThuNhap.Panel.Controls.Add(this.cbThuNhap);
            this.grpThuNhap.Panel.Controls.Add(this.txtLoaiThuNhap);
            this.grpThuNhap.Panel.Controls.Add(this.txtMaThuNhap);
            this.grpThuNhap.Panel.Controls.Add(this.label4);
            this.grpThuNhap.Panel.Controls.Add(this.label5);
            this.grpThuNhap.Panel.Controls.Add(this.label3);
            this.grpThuNhap.Size = new System.Drawing.Size(374, 94);
            this.grpThuNhap.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.grpThuNhap.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.grpThuNhap.TabIndex = 195;
            this.grpThuNhap.Values.Heading = "";
            // 
            // cbThuNhap
            // 
            this.cbThuNhap.AutoSize = true;
            this.cbThuNhap.Location = new System.Drawing.Point(341, 16);
            this.cbThuNhap.Name = "cbThuNhap";
            this.cbThuNhap.Size = new System.Drawing.Size(18, 17);
            this.cbThuNhap.TabIndex = 182;
            this.cbThuNhap.UseVisualStyleBackColor = true;
            // 
            // txtLoaiThuNhap
            // 
            this.txtLoaiThuNhap.Location = new System.Drawing.Point(137, 46);
            this.txtLoaiThuNhap.Name = "txtLoaiThuNhap";
            this.txtLoaiThuNhap.Size = new System.Drawing.Size(222, 31);
            this.txtLoaiThuNhap.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtLoaiThuNhap.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtLoaiThuNhap.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtLoaiThuNhap.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLoaiThuNhap.StateCommon.Border.Rounding = 5;
            this.txtLoaiThuNhap.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtLoaiThuNhap.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiThuNhap.TabIndex = 190;
            // 
            // txtMaThuNhap
            // 
            this.txtMaThuNhap.Enabled = false;
            this.txtMaThuNhap.Location = new System.Drawing.Point(137, 7);
            this.txtMaThuNhap.Name = "txtMaThuNhap";
            this.txtMaThuNhap.ReadOnly = true;
            this.txtMaThuNhap.Size = new System.Drawing.Size(107, 31);
            this.txtMaThuNhap.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtMaThuNhap.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtMaThuNhap.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtMaThuNhap.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaThuNhap.StateCommon.Border.Rounding = 5;
            this.txtMaThuNhap.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtMaThuNhap.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThuNhap.TabIndex = 191;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 188;
            this.label4.Text = "Mã thu nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 178;
            this.label5.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 189;
            this.label3.Text = "Loại thu nhập:";
            // 
            // grpChiTieu
            // 
            this.grpChiTieu.Location = new System.Drawing.Point(1, 22);
            this.grpChiTieu.Name = "grpChiTieu";
            // 
            // grpChiTieu.Panel
            // 
            this.grpChiTieu.Panel.Controls.Add(this.cbTrangThai);
            this.grpChiTieu.Panel.Controls.Add(this.txtLoaiCT);
            this.grpChiTieu.Panel.Controls.Add(this.txtMaCT);
            this.grpChiTieu.Panel.Controls.Add(this.label6);
            this.grpChiTieu.Panel.Controls.Add(this.label1);
            this.grpChiTieu.Panel.Controls.Add(this.label2);
            this.grpChiTieu.Size = new System.Drawing.Size(374, 94);
            this.grpChiTieu.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.grpChiTieu.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.grpChiTieu.TabIndex = 196;
            this.grpChiTieu.Values.Heading = "";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Location = new System.Drawing.Point(336, 18);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(18, 17);
            this.cbTrangThai.TabIndex = 182;
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // txtLoaiCT
            // 
            this.txtLoaiCT.Location = new System.Drawing.Point(133, 48);
            this.txtLoaiCT.Name = "txtLoaiCT";
            this.txtLoaiCT.Size = new System.Drawing.Size(222, 31);
            this.txtLoaiCT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtLoaiCT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtLoaiCT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtLoaiCT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLoaiCT.StateCommon.Border.Rounding = 5;
            this.txtLoaiCT.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtLoaiCT.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiCT.TabIndex = 180;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Enabled = false;
            this.txtMaCT.Location = new System.Drawing.Point(133, 9);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.ReadOnly = true;
            this.txtMaCT.Size = new System.Drawing.Size(108, 31);
            this.txtMaCT.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtMaCT.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtMaCT.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(210)))), ((int)(((byte)(179)))));
            this.txtMaCT.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMaCT.StateCommon.Border.Rounding = 5;
            this.txtMaCT.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtMaCT.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCT.TabIndex = 181;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 179;
            this.label6.Text = "Loại chi tiêu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 178;
            this.label1.Text = "Trạng thái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 178;
            this.label2.Text = "Mã chi tiêu:";
            // 
            // rdoChiTieu
            // 
            this.rdoChiTieu.Location = new System.Drawing.Point(3, 1);
            this.rdoChiTieu.Name = "rdoChiTieu";
            this.rdoChiTieu.Size = new System.Drawing.Size(86, 24);
            this.rdoChiTieu.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.rdoChiTieu.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.rdoChiTieu.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChiTieu.TabIndex = 189;
            this.rdoChiTieu.Values.Text = "Chi tiêu";
            this.rdoChiTieu.CheckedChanged += new System.EventHandler(this.rdoChiTieu_CheckedChanged);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnLamMoi.BackgroundImage = global::LIZARDMONEY.Properties.Resources.refresh1;
            this.btnLamMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(238)))), ((int)(((byte)(199)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(506, 124);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(48, 48);
            this.btnLamMoi.TabIndex = 193;
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
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(288, 124);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(48, 48);
            this.btnSua.TabIndex = 190;
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
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(409, 122);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(48, 48);
            this.btnXoa.TabIndex = 191;
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
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(189, 122);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(48, 48);
            this.btnThem.TabIndex = 192;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmADLoaiChiTieu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 688);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kryptonGroupBox3);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmADLoaiChiTieu";
            this.Text = "frmADLoaiChiTieu";
            this.Load += new System.EventHandler(this.frmADLoaiChiTieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            this.kryptonGroupBox3.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpThuNhap.Panel)).EndInit();
            this.grpThuNhap.Panel.ResumeLayout(false);
            this.grpThuNhap.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpThuNhap)).EndInit();
            this.grpThuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpChiTieu.Panel)).EndInit();
            this.grpChiTieu.Panel.ResumeLayout(false);
            this.grpChiTieu.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpChiTieu)).EndInit();
            this.grpChiTieu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.DataGridView dgvDSCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridView dgvDSTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTrangThaiTN;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoThuNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpThuNhap;
        private System.Windows.Forms.CheckBox cbThuNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLoaiThuNhap;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaThuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpChiTieu;
        private System.Windows.Forms.CheckBox cbTrangThai;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLoaiCT;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMaCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rdoChiTieu;
    }
}