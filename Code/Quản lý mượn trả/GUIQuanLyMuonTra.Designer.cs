namespace LapTrinhCoSoDuLieu
{
    partial class GUIQuanLyMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIQuanLyMuonTra));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSach = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvGioHang = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btThemVaoGH = new System.Windows.Forms.Button();
            this.btChotDonHang = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvSachDaDuocMuon = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvDanhSachPhieuMuon = new System.Windows.Forms.ListView();
            this.btTraSach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDocGia = new System.Windows.Forms.ComboBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(149, 165);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(362, 30);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTimKiem_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lvSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(6, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            // 
            // lvSach
            // 
            this.lvSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSach.GridLines = true;
            this.lvSach.HideSelection = false;
            this.lvSach.Location = new System.Drawing.Point(6, 25);
            this.lvSach.Name = "lvSach";
            this.lvSach.Size = new System.Drawing.Size(669, 152);
            this.lvSach.TabIndex = 0;
            this.lvSach.UseCompatibleStateImageBehavior = false;
            this.lvSach.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvGioHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(529, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng (Tạm thời)";
            // 
            // lvGioHang
            // 
            this.lvGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGioHang.GridLines = true;
            this.lvGioHang.HideSelection = false;
            this.lvGioHang.Location = new System.Drawing.Point(6, 27);
            this.lvGioHang.Name = "lvGioHang";
            this.lvGioHang.Size = new System.Drawing.Size(497, 238);
            this.lvGioHang.TabIndex = 0;
            this.lvGioHang.UseCompatibleStateImageBehavior = false;
            this.lvGioHang.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(70, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ MƯỢN - TRẢ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.độcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.mượnToolStripMenuItem,
            this.quảnLýTrảToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 50);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.độcGiảToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(186, 46);
            this.độcGiảToolStripMenuItem.Text = "Quản lý nhân viên";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.ĐộcGiảToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Enabled = false;
            this.sáchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sáchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(32, 46);
            this.sáchToolStripMenuItem.Text = "|";
            // 
            // mượnToolStripMenuItem
            // 
            this.mượnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mượnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mượnToolStripMenuItem.Name = "mượnToolStripMenuItem";
            this.mượnToolStripMenuItem.Size = new System.Drawing.Size(164, 46);
            this.mượnToolStripMenuItem.Text = "Quản lý độc giả";
            this.mượnToolStripMenuItem.Click += new System.EventHandler(this.MượnToolStripMenuItem_Click);
            // 
            // quảnLýTrảToolStripMenuItem
            // 
            this.quảnLýTrảToolStripMenuItem.Enabled = false;
            this.quảnLýTrảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTrảToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quảnLýTrảToolStripMenuItem.Name = "quảnLýTrảToolStripMenuItem";
            this.quảnLýTrảToolStripMenuItem.Size = new System.Drawing.Size(32, 46);
            this.quảnLýTrảToolStripMenuItem.Text = "|";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(137, 46);
            this.toolStripMenuItem1.Text = "Quản lý sách";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // btThemVaoGH
            // 
            this.btThemVaoGH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemVaoGH.FlatAppearance.BorderSize = 0;
            this.btThemVaoGH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btThemVaoGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemVaoGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemVaoGH.Image = ((System.Drawing.Image)(resources.GetObject("btThemVaoGH.Image")));
            this.btThemVaoGH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemVaoGH.Location = new System.Drawing.Point(25, 264);
            this.btThemVaoGH.Name = "btThemVaoGH";
            this.btThemVaoGH.Size = new System.Drawing.Size(117, 56);
            this.btThemVaoGH.TabIndex = 21;
            this.btThemVaoGH.Text = "Thêm";
            this.btThemVaoGH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemVaoGH.UseVisualStyleBackColor = false;
            this.btThemVaoGH.Click += new System.EventHandler(this.BtThemVaoGH_Click);
            // 
            // btChotDonHang
            // 
            this.btChotDonHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChotDonHang.FlatAppearance.BorderSize = 0;
            this.btChotDonHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btChotDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChotDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChotDonHang.Image = ((System.Drawing.Image)(resources.GetObject("btChotDonHang.Image")));
            this.btChotDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChotDonHang.Location = new System.Drawing.Point(148, 264);
            this.btChotDonHang.Name = "btChotDonHang";
            this.btChotDonHang.Size = new System.Drawing.Size(117, 56);
            this.btChotDonHang.TabIndex = 22;
            this.btChotDonHang.Text = "Chốt";
            this.btChotDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChotDonHang.UseVisualStyleBackColor = false;
            this.btChotDonHang.Click += new System.EventHandler(this.BtChotDonHang_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(393, 202);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(118, 57);
            this.btThoat.TabIndex = 23;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lvSachDaDuocMuon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(6, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 137);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Từng Phiếu Mượn";
            // 
            // lvSachDaDuocMuon
            // 
            this.lvSachDaDuocMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSachDaDuocMuon.GridLines = true;
            this.lvSachDaDuocMuon.HideSelection = false;
            this.lvSachDaDuocMuon.Location = new System.Drawing.Point(6, 25);
            this.lvSachDaDuocMuon.Name = "lvSachDaDuocMuon";
            this.lvSachDaDuocMuon.Size = new System.Drawing.Size(669, 103);
            this.lvSachDaDuocMuon.TabIndex = 0;
            this.lvSachDaDuocMuon.UseCompatibleStateImageBehavior = false;
            this.lvSachDaDuocMuon.View = System.Windows.Forms.View.Details;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Controls.Add(this.lvDanhSachPhieuMuon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Gold;
            this.groupBox4.Location = new System.Drawing.Point(699, 329);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 326);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu mượn";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-499, -87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 140);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lvDanhSachPhieuMuon
            // 
            this.lvDanhSachPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachPhieuMuon.GridLines = true;
            this.lvDanhSachPhieuMuon.HideSelection = false;
            this.lvDanhSachPhieuMuon.Location = new System.Drawing.Point(6, 27);
            this.lvDanhSachPhieuMuon.Name = "lvDanhSachPhieuMuon";
            this.lvDanhSachPhieuMuon.Size = new System.Drawing.Size(327, 290);
            this.lvDanhSachPhieuMuon.TabIndex = 0;
            this.lvDanhSachPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachPhieuMuon.View = System.Windows.Forms.View.Details;
            this.lvDanhSachPhieuMuon.SelectedIndexChanged += new System.EventHandler(this.LvDanhSachPhieuMuon_SelectedIndexChanged);
            // 
            // btTraSach
            // 
            this.btTraSach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTraSach.FlatAppearance.BorderSize = 0;
            this.btTraSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraSach.Image = ((System.Drawing.Image)(resources.GetObject("btTraSach.Image")));
            this.btTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTraSach.Location = new System.Drawing.Point(271, 264);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(117, 56);
            this.btTraSach.TabIndex = 28;
            this.btTraSach.Text = "Trả";
            this.btTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTraSach.UseVisualStyleBackColor = false;
            this.btTraSach.Click += new System.EventHandler(this.BtTraSach_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tìm kiếm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(20, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày trả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(20, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ngày mượn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(20, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Độc giả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDocGia
            // 
            this.cbDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocGia.FormattingEnabled = true;
            this.cbDocGia.Location = new System.Drawing.Point(149, 134);
            this.cbDocGia.Name = "cbDocGia";
            this.cbDocGia.Size = new System.Drawing.Size(362, 26);
            this.cbDocGia.TabIndex = 35;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(149, 234);
            this.dtpNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(239, 24);
            this.dtpNgayTra.TabIndex = 37;
            this.dtpNgayTra.Value = new System.DateTime(2020, 3, 10, 22, 52, 39, 0);
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(149, 202);
            this.dtpNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(239, 24);
            this.dtpNgayMuon.TabIndex = 38;
            this.dtpNgayMuon.Value = new System.DateTime(2020, 3, 10, 22, 52, 39, 0);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(393, 264);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(118, 56);
            this.btXoa.TabIndex = 40;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // GUIQuanLyMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 658);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.cbDocGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTraSach);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btChotDonHang);
            this.Controls.Add(this.btThemVaoGH);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTimKiem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIQuanLyMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mượn Sách";
            this.Load += new System.EventHandler(this.QuanLyMuon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvGioHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btThemVaoGH;
        private System.Windows.Forms.Button btChotDonHang;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvSachDaDuocMuon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvDanhSachPhieuMuon;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDocGia;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Button btXoa;
    }
}