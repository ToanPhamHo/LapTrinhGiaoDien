namespace LapTrinhCoSoDuLieu
{
    partial class GUINhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUINhanVien));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvDataBase = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.cbBangCap = new System.Windows.Forms.ComboBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.lvDataBase);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(21, 435);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(930, 211);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // lvDataBase
            // 
            this.lvDataBase.BackColor = System.Drawing.Color.White;
            this.lvDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDataBase.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvDataBase.FullRowSelect = true;
            this.lvDataBase.GridLines = true;
            this.lvDataBase.HideSelection = false;
            this.lvDataBase.Location = new System.Drawing.Point(8, 29);
            this.lvDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.lvDataBase.Name = "lvDataBase";
            this.lvDataBase.Size = new System.Drawing.Size(914, 171);
            this.lvDataBase.TabIndex = 0;
            this.lvDataBase.UseCompatibleStateImageBehavior = false;
            this.lvDataBase.View = System.Windows.Forms.View.Details;
            this.lvDataBase.SelectedIndexChanged += new System.EventHandler(this.LvDataBase_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.cbBangCap);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(21, 158);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(930, 189);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Black;
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.Location = new System.Drawing.Point(524, 120);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(379, 47);
            this.btThoat.TabIndex = 4;
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.BtThoat_Click);
            // 
            // cbBangCap
            // 
            this.cbBangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBangCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBangCap.FormattingEnabled = true;
            this.cbBangCap.Location = new System.Drawing.Point(634, 76);
            this.cbBangCap.Margin = new System.Windows.Forms.Padding(4);
            this.cbBangCap.Name = "cbBangCap";
            this.cbBangCap.Size = new System.Drawing.Size(269, 28);
            this.cbBangCap.TabIndex = 10;
            this.cbBangCap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DtpNgaySinh_MouseUp);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(635, 36);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(269, 27);
            this.dtpNgaySinh.TabIndex = 9;
            this.dtpNgaySinh.Value = new System.DateTime(2020, 3, 10, 22, 52, 39, 0);
            this.dtpNgaySinh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHoTen_KeyUp);
            this.dtpNgaySinh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DtpNgaySinh_MouseUp);
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(141, 86);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(307, 26);
            this.txtSDT.TabIndex = 7;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSDT_KeyPress);
            this.txtSDT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHoTen_KeyUp);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(141, 131);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(307, 26);
            this.txtDiaChi.TabIndex = 6;
            this.txtDiaChi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHoTen_KeyUp);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(141, 45);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(307, 26);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHoTen_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(29, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(519, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bằng cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(519, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(243, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.độcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.mượnToolStripMenuItem,
            this.quảnLýTrảToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 60);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.độcGiảToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(175, 56);
            this.độcGiảToolStripMenuItem.Text = "Quản lý độc giả";
            this.độcGiảToolStripMenuItem.Click += new System.EventHandler(this.ĐộcGiảToolStripMenuItem_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.sáchToolStripMenuItem.Enabled = false;
            this.sáchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sáchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(14, 56);
            // 
            // mượnToolStripMenuItem
            // 
            this.mượnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mượnToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mượnToolStripMenuItem.Name = "mượnToolStripMenuItem";
            this.mượnToolStripMenuItem.Size = new System.Drawing.Size(147, 56);
            this.mượnToolStripMenuItem.Text = "Quản lý sách";
            this.mượnToolStripMenuItem.Click += new System.EventHandler(this.MượnToolStripMenuItem_Click);
            // 
            // quảnLýTrảToolStripMenuItem
            // 
            this.quảnLýTrảToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.quảnLýTrảToolStripMenuItem.Enabled = false;
            this.quảnLýTrảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTrảToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.quảnLýTrảToolStripMenuItem.Name = "quảnLýTrảToolStripMenuItem";
            this.quảnLýTrảToolStripMenuItem.Size = new System.Drawing.Size(14, 56);
            this.quảnLýTrảToolStripMenuItem.Text = "|";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(208, 56);
            this.toolStripMenuItem1.Text = "Quản lý mượn - trả";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.White;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Black;
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(829, 369);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(122, 58);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.BtXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.White;
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Black;
            this.btSua.Image = ((System.Drawing.Image)(resources.GetObject("btSua.Image")));
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(699, 369);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(122, 58);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.BtSua_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.White;
            this.btThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Black;
            this.btThem.Image = ((System.Drawing.Image)(resources.GetObject("btThem.Image")));
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(563, 369);
            this.btThem.Margin = new System.Windows.Forms.Padding(0);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(122, 58);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm";
            this.btThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.BtThem_Click_1);
            // 
            // GUINhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 658);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUINhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Nhân Viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormNhanVien_MouseUp);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvDataBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbBangCap;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảToolStripMenuItem;
    }
}