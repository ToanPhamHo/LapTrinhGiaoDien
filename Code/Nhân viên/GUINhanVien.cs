using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace LapTrinhCoSoDuLieu
{
    public partial class GUINhanVien : Form
    {
        public GUINhanVien()
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

        BUSNhanVien bnv = new BUSNhanVien();

        void loadLV()
        {
            DAONhanVien dnv = new DAONhanVien();

            lvDataBase.FullRowSelect = true;
            lvDataBase.View = View.Details;
            lvDataBase.Columns.Add("Mã nhân viên", 50);
            lvDataBase.Columns.Add("Họ và tên", 160);
            lvDataBase.Columns.Add("Ngày sinh", 120);
            lvDataBase.Columns.Add("Địa chỉ", 200);
            lvDataBase.Columns.Add("Điện thoại", 100);
            lvDataBase.Columns.Add("Bằng cấp", 100);

            foreach (var NV in dnv.trichDSNhanVienTuDB())
            {
                ListViewItem lv = new ListViewItem(NV.MaNhanVien.ToString());
                lv.SubItems.Add(NV.HoTenNhanVien.ToString());
                lv.SubItems.Add(NV.NgaySinh.ToString());
                lv.SubItems.Add(NV.DiaChi.ToString());
                lv.SubItems.Add(NV.DienThoai.ToString());
                lv.SubItems.Add(NV.TenBangCap.ToString());
                lvDataBase.Items.Add(lv);
            }
            dtpNgaySinh.Value = DateTime.Now;
        }

        void loadCB()
        {
            DAONhanVien dnv = new DAONhanVien();
            cbBangCap.DataSource = dnv.trichDSBangCapTuDB();
            cbBangCap.DisplayMember = "TenBangCap";
            cbBangCap.ValueMember = "MaBangCap";
            cbBangCap.SelectedIndex = -1;
        }

        void Clear()
        {
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            cbBangCap.SelectedIndex = -1;
            lvDataBase.Enabled = true;
            dtpNgaySinh.Value = DateTime.Now;
        }

        private void LvDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDataBase.SelectedItems.Count > 0)
            {
                txtHoTen.Enabled = true;
                dtpNgaySinh.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
                cbBangCap.Enabled = true;
                btSua.Enabled = true;
                btXoa.Enabled = true;
                btThem.Enabled = false;

                txtHoTen.Text = lvDataBase.SelectedItems[0].SubItems[1].Text;
                dtpNgaySinh.Text = lvDataBase.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lvDataBase.SelectedItems[0].SubItems[3].Text;
                txtSDT.Text = lvDataBase.SelectedItems[0].SubItems[4].Text;
                cbBangCap.Text = lvDataBase.SelectedItems[0].SubItems[5].Text;
            }
            else
            {
                Clear();
                btThem.Enabled = true;
                btSua.Enabled = false;
                btXoa.Enabled = false;
                dtpNgaySinh.Value = DateTime.Now;
            }             
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadLV();
            loadCB();

            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = false;
        }

        #region events
        private void BtThem_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Hãy nhập họ tên!");
                txtHoTen.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Hãy nhập địa chỉ!");
                txtDiaChi.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Hãy nhập số diện thoại!");
                txtSDT.Focus();
                return;
            }
            else if (cbBangCap.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn bằng cấp!");
                return;
            }
            else if (dtpNgaySinh.Value.Date >= DateTime.Now)
            {
                MessageBox.Show("Hãy nhập lại ngày sinh!");
                return;
            }
            else
            {
                bnv.them(txtHoTen.Text, dtpNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, txtSDT.Text, cbBangCap.SelectedValue.ToString());
                Clear();
                lvDataBase.Clear();
                loadLV();
                lvDataBase.Enabled = true;
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void BtSua_Click(object sender, EventArgs e)
        {
            if (lvDataBase.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn nhân viên để sửa!");
                return;
            }
            else if (lvDataBase.SelectedItems.Count > 1)
            {
                MessageBox.Show("Chỉ chọn 1 nhân viên để sửa!");
                return;
            }
            else if (lvDataBase.SelectedItems.Count == 1)
            {
                if (string.IsNullOrEmpty(txtHoTen.Text))
                {
                    MessageBox.Show("Hãy nhập tên!");
                    txtHoTen.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtDiaChi.Text))
                {
                    MessageBox.Show("Hãy nhập địa chỉ!");
                    txtDiaChi.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtSDT.Text))
                {
                    MessageBox.Show("Hãy nhập số điện thoại!");
                    txtSDT.Focus();
                    return;
                }
                else if (cbBangCap.SelectedItem == null)
                {
                    MessageBox.Show("Hãy chọn bằng cấp!");
                    return;
                }
                else if (dtpNgaySinh.Value.Date >= DateTime.Now)
                {
                    MessageBox.Show("Hãy nhập lại ngày sinh!");
                    return;
                }
                else
                {
                    bnv.sua(lvDataBase.SelectedItems[0].SubItems[0].Text, txtHoTen.Text, dtpNgaySinh.Value.ToShortDateString(), txtDiaChi.Text, txtSDT.Text, cbBangCap.SelectedValue.ToString());
                    Clear();
                    lvDataBase.Clear();
                    loadLV();
                    lvDataBase.Enabled = true;
                }
            }
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            if (lvDataBase.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa chứ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    bnv.xoa(lvDataBase);
                    lvDataBase.Enabled = true;
                }
            }
            else
                MessageBox.Show("Bạn phải chọn dòng cần xóa!");
            lvDataBase.Clear();
            loadLV();
        }
        #endregion 
        private void TxtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        } // Không cho nhập kí tự khác ngoài số

        private void ĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIDocGia dg = new GUIDocGia();
            dg.Show();
            this.Close();
        }

        private void MượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUISach sachs = new GUISach();
            sachs.Show();
            this.Close();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIQuanLyMuonTra qlm = new GUIQuanLyMuonTra();
            qlm.Show();
            this.Close();
        }

        private void DtpNgaySinh_MouseUp(object sender, MouseEventArgs e)
        {
            btThem.Enabled = true;
            lvDataBase.Enabled = false;
        }

        private void TxtHoTen_KeyUp(object sender, KeyEventArgs e)
        {
            btThem.Enabled = true;
            lvDataBase.Enabled = false;
        }

        private void FormNhanVien_MouseUp(object sender, MouseEventArgs e)
        {
            Clear();
            dtpNgaySinh.Value = DateTime.Now;
            btXoa.Enabled = true;
            btSua.Enabled = true;
        }
    }
}
