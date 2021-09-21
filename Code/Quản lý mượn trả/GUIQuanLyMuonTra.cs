using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;


namespace LapTrinhCoSoDuLieu
{
    public partial class GUIQuanLyMuonTra : Form
    {
        public GUIQuanLyMuonTra()
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

        DAOvsBUSQuanLyMuonTra qlmt = new DAOvsBUSQuanLyMuonTra();

        void Clear()
        {
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayTra.Value = DateTime.Now;
            cbDocGia.SelectedIndex = -1;
            txtTimKiem.Text = "";
        }

        void LoadlvSach()
        {
            lvSach.FullRowSelect = true;
            lvSach.View = View.Details;
            lvSach.Columns.Add("Mã sách", 80);
            lvSach.Columns.Add("Tên sách", 180);
            lvSach.Columns.Add("Tác giả", 130);
            lvSach.Columns.Add("Năm xuất bản", 80);
            lvSach.Columns.Add("Nhà xuất bản", 90);
            lvSach.Columns.Add("Trị giá", 70);
            lvSach.Columns.Add("Ngày nhập", 90);

            foreach (SACH sach in qlmt.trichSach())
            {
                ListViewItem lv = new ListViewItem(sach.MaSach.ToString());
                lv.SubItems.Add(sach.TenSach.ToString());
                lv.SubItems.Add(sach.TacGia.ToString());
                lv.SubItems.Add(sach.NamXuatBan.ToString());
                lv.SubItems.Add(sach.NhaXuatBan.ToString());
                lv.SubItems.Add(sach.TriGia.ToString());
                lv.SubItems.Add(sach.NgayNhap.Value.ToString());
                lvSach.Items.Add(lv);
            }

            qlmt.colorListViewLines(lvSach);
        }

        void LoadcbDocGia()
        {
            cbDocGia.DataSource = qlmt.trichDocGia();
            cbDocGia.DisplayMember = "HoTenDocGia";
            cbDocGia.ValueMember = "MaDocGia";
            cbDocGia.SelectedIndex = -1;
        }

        void LoadlvDanhSachPhieuMuon()
        {
            foreach (PHIEUMUONSACH pms in qlmt.trichPhieuMuonSach())
            {
                ListViewItem lv = new ListViewItem(pms.MaPhieuMuon.ToString());
                lv.SubItems.Add(pms.NgayMuon.Value.ToString());
                lv.SubItems.Add(pms.MaDocGia.ToString());
                lvDanhSachPhieuMuon.Items.Add(lv);
            }
        }

        private void QuanLyMuon_Load(object sender, EventArgs e)
        {
            lvGioHang.FullRowSelect = true;
            lvGioHang.View = View.Details;
            lvGioHang.Columns.Add("Mã sách", 80);
            lvGioHang.Columns.Add("Tên sách", 180);
            lvGioHang.Columns.Add("Tác giả", 130);
            lvGioHang.Columns.Add("Năm xuất bản", 80);
            lvGioHang.Columns.Add("Nhà xuất bản", 90);
            lvGioHang.Columns.Add("Trị giá", 70);
            lvGioHang.Columns.Add("Ngày nhập", 90);

            lvDanhSachPhieuMuon.FullRowSelect = true;
            lvDanhSachPhieuMuon.View = View.Details;
            lvDanhSachPhieuMuon.Columns.Add("Mã Phiếu mượn", 50);
            lvDanhSachPhieuMuon.Columns.Add("Ngày mượn", 100);
            lvDanhSachPhieuMuon.Columns.Add("Mã độc giả", 80);

            lvSachDaDuocMuon.FullRowSelect = true;
            lvSachDaDuocMuon.View = View.Details;
            lvSachDaDuocMuon.Columns.Add("Mã phiếu mượn", 90);
            lvSachDaDuocMuon.Columns.Add("Mã sách", 90);
            lvSachDaDuocMuon.Columns.Add("Tên sách", 180);

            txtTimKiem.Focus();
            LoadlvSach();
            LoadcbDocGia();
            LoadlvDanhSachPhieuMuon();
            Clear();
        }

        private void LvDanhSachPhieuMuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDanhSachPhieuMuon.SelectedItems.Count > 0)
            {
                string mpm = lvDanhSachPhieuMuon.SelectedItems[0].SubItems[0].Text;
                lvSachDaDuocMuon.Items.Clear();

                foreach (CHITIETPHIEUMUON ct in qlmt.trichDSSChuaTra(mpm))
                {
                    ListViewItem lv = new ListViewItem(ct.MaPhieuMuon.ToString());
                    lv.SubItems.Add(ct.MaSach.ToString());
                    lv.SubItems.Add(ct.SACH.TenSach.ToString());
                    lvSachDaDuocMuon.Items.Add(lv);
                }
            }
        }

        private void TxtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string tk = txtTimKiem.Text;
            if (tk != "")
                qlmt.timKiemSach(tk, lvSach);
            else
            {
                lvSach.Clear();
                LoadlvSach();
            }
        }      
        
        private void BtThemVaoGH_Click(object sender, EventArgs e)
        {
            if (lvSach.SelectedItems.Count > 0)
                qlmt.themVaoGioHang(lvSach, lvGioHang);
            else
                MessageBox.Show("Hãy chọn sách muốn mượn ở bên dưới!", "Thông báo");           
        }

        private void BtChotDonHang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbDocGia.Text))
                MessageBox.Show("Hãy chọn độc giả!", "Thông báo");
            else if (dtpNgayMuon.Value.Date < DateTime.Now.Date)
                MessageBox.Show("Ngày mượn không hợp lệ!", "Thông báo");
            else
            {
                qlmt.chotDonHang(dtpNgayMuon, cbDocGia, lvGioHang);

                MessageBox.Show("Thêm thành công vào Chi Tiết Phiếu Mượn!", "Thông báo");
                lvDanhSachPhieuMuon.Items.Clear();
                LoadlvDanhSachPhieuMuon();
                lvSachDaDuocMuon.Items.Clear();
                lvGioHang.Items.Clear();
                Clear();
            }
        }

        private void BtXoa_Click(object sender, EventArgs e)
        {
            if (lvGioHang.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa sách này chứ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    qlmt.xoaSachTuGioHang(lvGioHang);
                    MessageBox.Show("Xóa khỏi giỏ hàng thành công!", "Thông báo");
                }
            }
            else if (lvDanhSachPhieuMuon.SelectedItems.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa phiếu mượn này chứ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    qlmt.xoaPhieuMuonTuDSPM(lvDanhSachPhieuMuon);
                    lvDanhSachPhieuMuon.Items.Clear();
                    LoadlvDanhSachPhieuMuon();
                }
            }
            else
                MessageBox.Show("Hãy chọn sách muốn xóa khỏi giỏ hàng hoặc phiếu mượn từ danh sách phiếu mượn!", "Thông báo");
        }

        private void BtTraSach_Click(object sender, EventArgs e)
        {
            if (lvDanhSachPhieuMuon.SelectedItems.Count == 1)
            {
                if (lvSachDaDuocMuon.SelectedItems.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn thực sự muốn trả phiếu mượn này?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (dtpNgayTra.Value.Date < DateTime.Now.Date)
                            MessageBox.Show("Ngày trả không hợp lệ!", "Thông báo");
                        else
                        {
                            qlmt.traTungCuonSach(lvSachDaDuocMuon, dtpNgayTra);
                            lvSachDaDuocMuon.Items.Clear();
                            lvDanhSachPhieuMuon.Items.Clear();
                            LoadlvDanhSachPhieuMuon();
                            MessageBox.Show("Trả sách mượn thành công!", "Thông báo");
                        }
                    }
                }
                else if (lvDanhSachPhieuMuon.SelectedItems.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Bạn thực sự muốn trả toàn bộ sách từ phiếu mượn này?", "Thông báo", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        if (dtpNgayTra.Value.Date < DateTime.Now.Date)
                            MessageBox.Show("Ngày trả không hợp lệ!", "Thông báo");
                        else
                        {
                            qlmt.traToanBoSachCua1Phieu(lvSachDaDuocMuon, dtpNgayTra);
                            lvSachDaDuocMuon.Items.Clear();
                            lvDanhSachPhieuMuon.Items.Clear();
                            LoadlvDanhSachPhieuMuon();
                            MessageBox.Show("Trả phiếu mượn thành công!", "Thông báo");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Chỉ có thể thực hiện trả trên 1 phiếu!","Thông báo");
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát chứ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
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

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUISach s = new GUISach();
            s.Show();
            this.Close();
        }
    }
}
