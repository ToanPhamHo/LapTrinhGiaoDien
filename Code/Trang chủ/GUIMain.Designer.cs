namespace LapTrinhCoSoDuLieu
{
    partial class GUIMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIMain));
            this.MS = new System.Windows.Forms.Button();
            this.DG = new System.Windows.Forms.Button();
            this.Sach = new System.Windows.Forms.Button();
            this.NV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MS
            // 
            this.MS.BackColor = System.Drawing.Color.White;
            this.MS.FlatAppearance.BorderSize = 0;
            this.MS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS.Location = new System.Drawing.Point(43, 292);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(270, 75);
            this.MS.TabIndex = 8;
            this.MS.Text = "Mượn - Trả";
            this.MS.UseVisualStyleBackColor = false;
            this.MS.Click += new System.EventHandler(this.MS_Click);
            // 
            // DG
            // 
            this.DG.BackColor = System.Drawing.Color.White;
            this.DG.FlatAppearance.BorderSize = 0;
            this.DG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.DG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DG.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DG.Location = new System.Drawing.Point(43, 130);
            this.DG.Name = "DG";
            this.DG.Size = new System.Drawing.Size(270, 75);
            this.DG.TabIndex = 7;
            this.DG.Text = "Độc giả";
            this.DG.UseVisualStyleBackColor = false;
            this.DG.Click += new System.EventHandler(this.DG_Click);
            // 
            // Sach
            // 
            this.Sach.BackColor = System.Drawing.Color.White;
            this.Sach.FlatAppearance.BorderSize = 0;
            this.Sach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.Sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sach.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sach.Location = new System.Drawing.Point(43, 211);
            this.Sach.Name = "Sach";
            this.Sach.Size = new System.Drawing.Size(270, 75);
            this.Sach.TabIndex = 6;
            this.Sach.Text = "Sách";
            this.Sach.UseVisualStyleBackColor = false;
            this.Sach.Click += new System.EventHandler(this.Sach_Click);
            // 
            // NV
            // 
            this.NV.BackColor = System.Drawing.Color.White;
            this.NV.FlatAppearance.BorderSize = 0;
            this.NV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NV.Location = new System.Drawing.Point(43, 49);
            this.NV.Name = "NV";
            this.NV.Size = new System.Drawing.Size(270, 75);
            this.NV.TabIndex = 5;
            this.NV.Text = "Nhân viên";
            this.NV.UseVisualStyleBackColor = false;
            this.NV.Click += new System.EventHandler(this.NV_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 75);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(363, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.Sach);
            this.Controls.Add(this.NV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chính";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MS;
        private System.Windows.Forms.Button DG;
        private System.Windows.Forms.Button Sach;
        private System.Windows.Forms.Button NV;
        private System.Windows.Forms.Button button1;
    }
}

