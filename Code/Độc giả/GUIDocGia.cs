using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapTrinhCoSoDuLieu
{
    public partial class GUIDocGia : Form
    {
        public GUIDocGia()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.Gray; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.Gray; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.Gray; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.Gray; }
            }
        }

        DAOvsBUSDocGia dg = new DAOvsBUSDocGia();

        void loadLVDG()
        {
            lvDBDG.FullRowSelect = true;
            lvDBDG.View = View.Details;
            lvDBDG.Columns.Add("Mã đọc giả", 100);
            lvDBDG.Columns.Add("Họ và tên", 200);
            lvDBDG.Columns.Add("Ngày sinh", 100);
            lvDBDG.Columns.Add("Địa chỉ", 200);
            lvDBDG.Columns.Add("Email", 100);
            lvDBDG.Columns.Add("Ngày lập thẻ", 100);
            lvDBDG.Columns.Add("Ngày hết hạn", 100);
            lvDBDG.Columns.Add("Tiền nợ", 100);

            foreach (DOCGIA DG in dg.trichBangDocGiaTuDB())
            {
                ListViewItem lv = new ListViewItem(DG.MaDocGia.ToString());
                lv.SubItems.Add(DG.HoTenDocGia.ToString());
                lv.SubItems.Add(DG.NgaySinh.Value.ToString());
                lv.SubItems.Add(DG.DiaChi.ToString());
                lv.SubItems.Add(DG.Email.ToString());
                lv.SubItems.Add(DG.NgayLapThe.Value.ToString());
                lv.SubItems.Add(DG.NgayHetHan.Value.ToString());
                lv.SubItems.Add(DG.TienNo.ToString());
                lvDBDG.Items.Add(lv);
            }

            dtpNgaySinhDG.Value = DateTime.Now;
            dtpNgayLapThe.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now;
        }

        void Clear()
        {
            txtMaDocGia.Clear();
            txtHoTenDG.Clear();
            txtDiaChiDG.Clear();
            txtEmail.Clear();
            txtTienNoDG.Clear();
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            btThemDG.Enabled = false;
            btSuaDG.Enabled = false;
            btXoaDG.Enabled = false;
            loadLVDG();
        }

        private void LvDBDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDBDG.SelectedItems.Count > 0)
            {
                btThemDG.Enabled = false;
                btSuaDG.Enabled = true;
                btXoaDG.Enabled = true;
                txtMaDocGia.Enabled = false;

                txtMaDocGia.Text = lvDBDG.SelectedItems[0].SubItems[0].Text;
                txtHoTenDG.Text = lvDBDG.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinhDG.Text = lvDBDG.SelectedItems[0].SubItems[2].Text;
                txtDiaChiDG.Text = lvDBDG.SelectedItems[0].SubItems[3].Text;
                txtEmail.Text = lvDBDG.SelectedItems[0].SubItems[4].Text;
                dtpNgayLapThe.Text = lvDBDG.SelectedItems[0].SubItems[5].Text;
                dtpNgayHetHan.Text = lvDBDG.SelectedItems[0].SubItems[6].Text;
                txtTienNoDG.Text = lvDBDG.SelectedItems[0].SubItems[7].Text;
            }
            else
            {
                Clear();
                txtMaDocGia.Enabled = true;
                btThemDG.Enabled = false;
                btSuaDG.Enabled = false;
                btXoaDG.Enabled = false;
                dtpNgaySinhDG.Value = DateTime.Now;
                dtpNgayLapThe.Value = DateTime.Now;
                dtpNgayHetHan.Value = DateTime.Now;
            }
        }

        private void TxtTienNoDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BtThoatDG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void BtThemDG_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaDocGia.Text))
            {
                MessageBox.Show("Hãy nhập mã đọc giả!");
                txtMaDocGia.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtHoTenDG.Text))
            {
                MessageBox.Show("Hãy nhập họ tên!");
                txtHoTenDG.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDiaChiDG.Text))
            {
                MessageBox.Show("Hãy nhập địa chỉ!");
                txtDiaChiDG.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Hãy nhập Email!");
                txtEmail.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtTienNoDG.Text))
            {
                MessageBox.Show("Hãy nhập số tiền nợ!");
                txtTienNoDG.Focus();
                return;
            }
            else if (dtpNgaySinhDG.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Hãy nhập lại ngày sinh!");
                dtpNgayLapThe.Focus();
                return;
            }
            else if (dtpNgaySinhDG.Value.Date > dtpNgayLapThe.Value.Date)
            {
                MessageBox.Show("Hãy nhập lại ngày lập thẻ!");
                dtpNgayLapThe.Focus();
                return;
            }
            else if (dtpNgayHetHan.Value.Date <= dtpNgayLapThe.Value.Date)
            {
                MessageBox.Show("Hãy nhập lại ngày hết hạn!");
                dtpNgayHetHan.Focus();
                return;
            }
            else
            {
                dg.themDG(txtMaDocGia.Text, txtHoTenDG.Text, dtpNgaySinhDG.Value.ToShortDateString(), txtDiaChiDG.Text, txtEmail.Text, dtpNgayLapThe.Value.ToShortDateString(), dtpNgayHetHan.Value.ToShortDateString(), txtTienNoDG.Text);
                lvDBDG.Enabled = true;
                txtMaDocGia.Enabled = true;
                Clear();
                lvDBDG.Clear();
                loadLVDG();
                lvDBDG.Enabled = true;
            }
        }

        private void BtXoaDG_Click(object sender, EventArgs e)
        {
            if (lvDBDG.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa đọc giả này chứ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dg.xoaDG(lvDBDG);
                    Clear();
                    lvDBDG.Enabled = true;
                    txtMaDocGia.Enabled = true;
                }
            }
            else
                MessageBox.Show("Bạn phải chọn dòng cần xóa!");
            lvDBDG.Clear();
            loadLVDG();
        }

        private void BtSuaDG_Click(object sender, EventArgs e)
        {
            if (lvDBDG.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chỉ chọn dòng để sửa!");
                return;
            }
            if (lvDBDG.SelectedItems.Count > 1)
            {
                MessageBox.Show("Chỉ chọn 1 dòng để sửa!");
                return;
            }
            else if (string.IsNullOrEmpty(txtMaDocGia.Text))
            {
                MessageBox.Show("Hãy nhập mã đọc giả!");
                txtMaDocGia.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtHoTenDG.Text))
            {
                MessageBox.Show("Hãy nhập họ tên!");
                txtHoTenDG.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDiaChiDG.Text))
            {
                MessageBox.Show("Hãy nhập địa chỉ!");
                txtDiaChiDG.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Hãy nhập Email!");
                txtEmail.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtTienNoDG.Text))
            {
                MessageBox.Show("Hãy nhập số tiền nợ!");
                txtTienNo.Focus();
                return;
            }
            else if (dtpNgaySinhDG.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Hãy nhập lại ngày sinh!");
                dtpNgayLapThe.Focus();
                return;
            }
            else if (dtpNgaySinhDG.Value.Date > dtpNgayLapThe.Value.Date)
            {
                MessageBox.Show("Hãy nhập lại ngày lập thẻ!");
                dtpNgayLapThe.Focus();
                return;
            }
            else if (dtpNgayHetHan.Value.Date <= dtpNgayLapThe.Value.Date)
            {
                MessageBox.Show("Hãy nhập lại ngày hết hạn!");
                dtpNgayHetHan.Focus();
                return;
            }
            else
            {
                dg.suaDG(txtMaDocGia.Text, txtHoTenDG.Text, dtpNgaySinhDG.Value.ToShortDateString(), txtDiaChiDG.Text, txtEmail.Text, dtpNgayLapThe.Value.ToShortDateString(), dtpNgayHetHan.Value.ToShortDateString(), txtTienNoDG.Text);
                MessageBox.Show("Sửa thành công!");
                lvDBDG.Enabled = true;
                txtMaDocGia.Enabled = true;
                Clear();
                lvDBDG.Clear();
                loadLVDG();
            }
        }

        private void ĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUINhanVien nv = new GUINhanVien();
            nv.Show();
            this.Close();
        }

        private void MượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUISach s = new GUISach();
            s.Show();
            this.Close();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIQuanLyMuonTra qlm = new GUIQuanLyMuonTra();
            qlm.Show();
            this.Close();
        }

        private void TxtMaDocGia_KeyUp(object sender, KeyEventArgs e)
        {
            btThemDG.Enabled = true;
            lvDBDG.Enabled = false;
        }

        private void DtpNgaySinhDG_MouseUp(object sender, MouseEventArgs e)
        {
            btThemDG.Enabled = true;
            lvDBDG.Enabled = false;
        }

        private void FormDocGia_MouseUp(object sender, MouseEventArgs e)
        {
            Clear();
            txtMaDocGia.Enabled = true;
            dtpNgayHetHan.Value = dtpNgayLapThe.Value = dtpNgaySinhDG.Value = DateTime.Now;
            lvDBDG.Enabled = true;
            lvDBDG.Clear();
            loadLVDG();
        }
    }
}
