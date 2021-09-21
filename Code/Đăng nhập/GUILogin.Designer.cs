namespace LapTrinhCoSoDuLieu
{
    partial class GUILogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUILogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnĐN = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTK.Location = new System.Drawing.Point(156, 164);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(179, 27);
            this.txtTK.TabIndex = 2;
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMK.Location = new System.Drawing.Point(156, 200);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(179, 27);
            this.txtMK.TabIndex = 3;
            // 
            // btnĐN
            // 
            this.btnĐN.BackColor = System.Drawing.SystemColors.Window;
            this.btnĐN.FlatAppearance.BorderSize = 0;
            this.btnĐN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnĐN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnĐN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnĐN.ForeColor = System.Drawing.Color.Black;
            this.btnĐN.Location = new System.Drawing.Point(182, 295);
            this.btnĐN.Name = "btnĐN";
            this.btnĐN.Size = new System.Drawing.Size(142, 43);
            this.btnĐN.TabIndex = 4;
            this.btnĐN.Text = "Đăng nhập";
            this.btnĐN.UseVisualStyleBackColor = false;
            this.btnĐN.Click += new System.EventHandler(this.BtnĐN_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(47, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(92, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 57);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login !";
            // 
            // GUILogin
            // 
            this.AcceptButton = this.btnĐN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnĐN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUILogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnĐN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
    }
}