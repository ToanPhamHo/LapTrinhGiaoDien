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
    public partial class GUISach : Form
    {
        public GUISach()
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

        DAOvsBUSSach sach = new DAOvsBUSSach();

        void loadSach()
        {
            lvS.FullRowSelect = true;
            lvS.View = View.Details;
            lvS.Columns.Add("Mã sách", 80);
            lvS.Columns.Add("Tên sách", 170);
            lvS.Columns.Add("Tác giả", 100);
            lvS.Columns.Add("Năm xuất bản", 50);
            lvS.Columns.Add("Nhà xuất bản", 100);
            lvS.Columns.Add("Trị giá", 100);
            lvS.Columns.Add("Ngày nhập", 150);

            foreach (SACH Sach in sach.trichSachTuDB())
            {
                ListViewItem lv = new ListViewItem(Sach.MaSach.ToString());
                lv.SubItems.Add(Sach.TenSach.ToString());
                lv.SubItems.Add(Sach.TacGia.ToString());
                lv.SubItems.Add(Sach.NamXuatBan.ToString());
                lv.SubItems.Add(Sach.NhaXuatBan.ToString());
                lv.SubItems.Add(Sach.TriGia.ToString());
                lv.SubItems.Add(Sach.NgayNhap.Value.ToString());
                lvS.Items.Add(lv);
            }
            dtpNgayNhap.Value = DateTime.Now;
        }

        void setEmpty()
        {
            txtTimKiem.Clear();
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtNamXuatBan.Clear();
            txtNhaXuatBan.Clear();
            txtGia.Clear();
            dtpNgayNhap.Value = DateTime.Now;
        }

        private void FormSach_Load(object sender, EventArgs e)
        {

            btThemS.Enabled = false;
            btSuaS.Enabled = false;
            btXoaS.Enabled = false;
            loadSach();
        }

        private void LvS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvS.SelectedItems.Count > 0)
            {
                btThemS.Enabled = false;
                btSuaS.Enabled = true;
                btXoaS.Enabled = true;
                txtMaSach.Enabled = false;
                txtTimKiem.Enabled = false;

                txtMaSach.Text = lvS.SelectedItems[0].SubItems[0].Text;
                txtTenSach.Text = lvS.SelectedItems[0].SubItems[1].Text;
                txtTacGia.Text = lvS.SelectedItems[0].SubItems[2].Text;
                txtNamXuatBan.Text = lvS.SelectedItems[0].SubItems[3].Text;
                txtNhaXuatBan.Text = lvS.SelectedItems[0].SubItems[4].Text;
                dtpNgayNhap.Text = lvS.SelectedItems[0].SubItems[6].Text;
                txtGia.Text = lvS.SelectedItems[0].SubItems[5].Text;

                txtTenSach.Enabled = true;
                txtTacGia.Enabled = true;
                txtNhaXuatBan.Enabled = true;
                txtNamXuatBan.Enabled = true;
                dtpNgayNhap.Enabled = true;
                txtGia.Enabled = true;
                txtTimKiem.Text = null;
            }
            else
            {
                setEmpty();
                txtMaSach.Enabled = true;
                btThemS.Enabled = false;
                btSuaS.Enabled = false;
                btXoaS.Enabled = false;
            }
        }

        private void TxtNamXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        } 

        private void BtThemS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Hãy nhập mã sách!");
                txtMaSach.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                MessageBox.Show("Hãy nhập tên sách!");
                txtTenSach.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtTacGia.Text))
            {
                MessageBox.Show("Hãy nhập tên tác giả!");
                txtTacGia.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNamXuatBan.Text))
            {
                MessageBox.Show("Hãy nhập năm xuất bản!");
                txtNamXuatBan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNhaXuatBan.Text))
            {
                MessageBox.Show("Hãy nhập nhà xuất bản!");
                txtNhaXuatBan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Hãy nhập trị giá!");
                txtGia.Focus();
                return;
            }
            else if (int.Parse(txtNamXuatBan.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Hãy nhập lại năm xuất bản!");
                txtNamXuatBan.Focus();
                return;
            }
            else if (dtpNgayNhap.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Hãy nhập lại ngày nhập sách!");
                dtpNgayNhap.Focus();
                return;
            }
            else
            {
                sach.themS(txtMaSach.Text, txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatBan.Text, txtGia.Text, dtpNgayNhap.Value.ToShortDateString());
                setEmpty();
                lvS.Clear();
                loadSach();
                lvS.Enabled = true;
            }
        }

        private void BtXoaS_Click(object sender, EventArgs e)
        {
            if (lvS.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa sách này?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    sach.xoaS(lvS);
                lvS.Enabled = true;
            }
            else
                MessageBox.Show("Hãy chọn dòng cần xóa!");

            lvS.Clear();
            loadSach();
            setEmpty();
        }

        private void BtSuaS_Click(object sender, EventArgs e)
        {
            if (lvS.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn dòng muốn sửa!");
                return;
            }
            else if (lvS.SelectedItems.Count > 1)
            {
                MessageBox.Show("Chỉ chọn 1 dòng muốn sửa!");
                return;
            }
            else if (string.IsNullOrEmpty(txtMaSach.Text))
            {
                MessageBox.Show("Hãy nhập mã sách!");
                txtMaSach.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                MessageBox.Show("Hãy nhập tên sách!");
                txtTenSach.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtTacGia.Text))
            {
                MessageBox.Show("Hãy nhập tên tác giả!");
                txtTacGia.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNamXuatBan.Text))
            {
                MessageBox.Show("Hãy nhập năm xuất bản!");
                txtNamXuatBan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNhaXuatBan.Text))
            {
                MessageBox.Show("Hãy nhập nhà xuất bản!");
                txtNhaXuatBan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Hãy nhập trị giá!");
                txtGia.Focus();
                return;
            }
            else if (int.Parse(txtNamXuatBan.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Hãy nhập lại năm xuất bản!");
                txtNamXuatBan.Focus();
                return;
            }
            else if (dtpNgayNhap.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Hãy nhập lại ngày nhập sách!");
                dtpNgayNhap.Focus();
                return;
            }
            else
            {
                sach.suaS(txtMaSach.Text, txtTenSach.Text, txtTacGia.Text, txtNamXuatBan.Text, txtNhaXuatBan.Text, txtGia.Text, dtpNgayNhap.Value.ToString());
                setEmpty();
                lvS.Clear();
                loadSach();
                lvS.Enabled = true;
            }
        }

        private void TxtMaSach_KeyUp(object sender, KeyEventArgs e)
        {
            btThemS.Enabled = true;
        }

        private void ĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUINhanVien nv = new GUINhanVien();
            nv.Show();
            this.Close();
        }

        private void MượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIDocGia dg = new GUIDocGia();
            dg.Show();
            this.Close();         
        }

        private void QuảnLýMượnTrảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIQuanLyMuonTra qlm = new GUIQuanLyMuonTra();
            qlm.Show();
            this.Close();
        }

        private void TxtTimKiem_KeyUp_1(object sender, KeyEventArgs e)
        {
            btThemS.Enabled = true;
            txtTimKiem.Enabled = false;
        }

        private void DtpNgayNhap_MouseUp(object sender, MouseEventArgs e)
        {
            btThemS.Enabled = true;
        }

        private void FormSach_MouseUp(object sender, MouseEventArgs e)
        {
            setEmpty();
            lvS.Enabled = true;
            txtTimKiem.Enabled = true;

            txtMaSach.Enabled = true;
            txtTenSach.Enabled = true;
            txtTacGia.Enabled = true;
            txtNhaXuatBan.Enabled = true;
            txtNamXuatBan.Enabled = true;
            txtGia.Enabled = true;
            dtpNgayNhap.Enabled = true;

            lvS.Clear();
            loadSach();
        }

        private void TxtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            txtNhaXuatBan.Enabled = false;
            txtNamXuatBan.Enabled = false;
            txtGia.Enabled = false;
            dtpNgayNhap.Enabled = false;
        }

        private void TxtTimKiem_KeyUp_2(object sender, KeyEventArgs e)
        {
            string tk = txtTimKiem.Text;
            if (tk != "")         
                sach.timKiemSach(tk, lvS);          
            else
            {
                lvS.Clear();
                loadSach();
            }
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
    }
}
