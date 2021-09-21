using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LapTrinhCoSoDuLieu
{
    public partial class GUIMain : Form
    {
        public GUIMain()
        {
            InitializeComponent();
        }

        private void NV_Click(object sender, EventArgs e)
        {
            GUINhanVien nv = new GUINhanVien();
            nv.Show();
        }

        private void DG_Click(object sender, EventArgs e)
        {
            GUIDocGia dg = new GUIDocGia();
            dg.Show();
        }

        private void Sach_Click(object sender, EventArgs e)
        {
            GUISach s = new GUISach();
            s.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void MS_Click(object sender, EventArgs e)
        {
            GUIQuanLyMuonTra qlm = new GUIQuanLyMuonTra();
            qlm.Show();
        }
    }
}
