using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Transactions;
using System.Drawing;

namespace LapTrinhCoSoDuLieu
{
    class DAOvsBUSQuanLyMuonTra
    {
        DataClasses1DataContext DB = new DataClasses1DataContext();

        public IEnumerable<DOCGIA> trichDocGia()
        {
            return DB.DOCGIAs.ToList();
        }

        public IEnumerable<SACH> trichSach()
        {
            return DB.SACHes.ToList();
        }

        public IEnumerable<PHIEUMUONSACH> trichPhieuMuonSach()
        {
            return DB.PHIEUMUONSACHes.ToList();
        }

        public IEnumerable<CHITIETPHIEUMUON> trichDSSChuaTra(string mpm)
        {
            return DB.CHITIETPHIEUMUONs.Where(p => p.MaPhieuMuon == int.Parse(mpm) && p.NgayTra == null);
        }

        public void colorListViewLines(ListView lvSach)
        {
            foreach (ListViewItem lvw in lvSach.Items)
            {
                if (!KiemTraTinhTrangSach(lvw.SubItems[0].Text))
                    lvw.BackColor = Color.Red;
            }
        }

        #region txt Tìm kiếm
        private IEnumerable<SACH> timSach(string ts)
        {
            return DB.SACHes.Where(s => s.MaSach.Contains(ts) || s.TenSach.Contains(ts) || s.TacGia.Contains(ts) || s.NhaXuatBan.Contains(ts) || s.NamXuatBan.ToString().Contains(ts) || s.NgayNhap.ToString().Contains(ts) || s.TriGia.ToString().Contains(ts));
        }

        public void timKiemSach (string tk, ListView lvSach)
        {
            IEnumerable<SACH> sachs = timSach(tk);
            lvSach.Items.Clear();
            foreach (SACH sa in sachs)
            {
                ListViewItem lv = new ListViewItem(sa.MaSach.ToString());
                lv.SubItems.Add(sa.TenSach.ToString());
                lv.SubItems.Add(sa.TacGia.ToString());
                lv.SubItems.Add(sa.NamXuatBan.ToString());
                lv.SubItems.Add(sa.NhaXuatBan.ToString());
                lv.SubItems.Add(sa.TriGia.ToString());
                lv.SubItems.Add(sa.NgayNhap.Value.ToString());
                lvSach.Items.Add(lv);
            }
        }
        #endregion

        #region btn Giỏ hàng
        private bool KiemTraTinhTrangSach(string ms)
        {         
            var q = DB.CHITIETPHIEUMUONs.Where(s => s.MaSach == ms && s.NgayTra != null).SingleOrDefault();
            if (q != null)
                return true;
            else
                return false;
        }

        private bool KiemTraSachThemVaoGioHang(string ms, ListView lvGioHang)
        {
            int dem = 0; ;
            for (int i = 0; i < lvGioHang.Items.Count; i++)
            {
                if (ms == lvGioHang.Items[i].SubItems[0].Text)
                    dem++;
            }
            if (dem == 1)
                return false;
            return true;
        }

        public void themVaoGioHang(ListView lvSach, ListView lvGioHang)
        {
            for (int i = lvSach.Items.Count - 1; i >= 0; i--)
            {
                if (lvSach.Items[i].Selected)
                {
                    if (KiemTraTinhTrangSach(lvSach.Items[i].SubItems[0].Text))
                    {
                        if (KiemTraSachThemVaoGioHang(lvSach.Items[i].SubItems[0].Text, lvGioHang))
                        {
                            ListViewItem lv = new ListViewItem(lvSach.Items[i].SubItems[0].Text);
                            lv.SubItems.Add(lvSach.Items[i].SubItems[1].Text);
                            lv.SubItems.Add(lvSach.Items[i].SubItems[2].Text);
                            lv.SubItems.Add(lvSach.Items[i].SubItems[3].Text);
                            lv.SubItems.Add(lvSach.Items[i].SubItems[4].Text);
                            lv.SubItems.Add(lvSach.Items[i].SubItems[5].Text);
                            lv.SubItems.Add(lvSach.Items[i].SubItems[6].Text);
                            lvGioHang.Items.Add(lv);
                        }
                        else
                            MessageBox.Show("Sách bạn thêm đã có trong giỏ hàng!", "Thông báo");
                    }
                    else
                        MessageBox.Show("Sách bạn chọn đã được mượn bởi người khác!", "Thông báo");
                }
            }
        }
        #endregion

        #region btn Chốt
        private int themPhieuMuonSach(DateTime nm, string mdg)
        {
            PHIEUMUONSACH pms = new PHIEUMUONSACH();
            pms.NgayMuon = nm;
            pms.MaDocGia = mdg;

            try
            {
                DB.PHIEUMUONSACHes.InsertOnSubmit(pms);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Thêm thành công vào Phiếu Mượn Sách!", "Thông báo");
            return pms.MaPhieuMuon;
        }

        private bool kiemTraTrungMaPhieuMuonSach(string ms) // Để xóa (mã sách đang tồn tại trong CTPM có ngày trả) và tạo (mã sách mới trong CTPM với ngày trả null) - tránh sự  lưu trùng 1 mã sách vào CTPM.
        {
            var r = DB.CHITIETPHIEUMUONs.Where(s => s.MaSach == ms).ToList();

            if (r != null)
                return true;
            return false;
        }

        private void xoaChiTietPhieuMuonTrung(string ms)
        {
            CHITIETPHIEUMUON sa = DB.CHITIETPHIEUMUONs.FirstOrDefault(s => s.MaSach.Equals(ms));

            try
            {
                DB.CHITIETPHIEUMUONs.DeleteOnSubmit(sa);
                DB.SubmitChanges();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void themChiTietPhieuMuonSach(string ms, int mpm)
        {
            CHITIETPHIEUMUON ctpms = new CHITIETPHIEUMUON();
            ctpms.MaSach = ms;
            ctpms.MaPhieuMuon = mpm;
            ctpms.NgayTra = null;
            try
            {
                DB.CHITIETPHIEUMUONs.InsertOnSubmit(ctpms);
                DB.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      

        public void chotDonHang(DateTimePicker dtpNgayMuon, ComboBox cbDocGia, ListView lvGioHang)
        {
            using (TransactionScope t = new TransactionScope())
            {
                int MaPhieuMuon = themPhieuMuonSach(dtpNgayMuon.Value, cbDocGia.SelectedValue.ToString());

                for (int j = 0; j < lvGioHang.Items.Count; j++)
                    if (kiemTraTrungMaPhieuMuonSach(lvGioHang.Items[j].SubItems[0].Text))
                        xoaChiTietPhieuMuonTrung(lvGioHang.Items[j].SubItems[0].Text);

                for (int i = 0; i < lvGioHang.Items.Count; i++)
                    themChiTietPhieuMuonSach(lvGioHang.Items[i].SubItems[0].Text, MaPhieuMuon);

                t.Complete();
            }
        }
        #endregion

        #region btn Trả
        private void TraSachTrongChiTietPhieuMuonSach(string mS, DateTime nt)
        {
            CHITIETPHIEUMUON ctpms = DB.CHITIETPHIEUMUONs.FirstOrDefault(s => s.MaSach == mS);
            ctpms.NgayTra = nt;

            try
            {
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void traTungCuonSach(ListView lvSachDaDuocMuon, DateTimePicker dtpNgayTra)
        {
            for (int i = 0; i < lvSachDaDuocMuon.SelectedItems.Count; i++)
                TraSachTrongChiTietPhieuMuonSach(lvSachDaDuocMuon.SelectedItems[i].SubItems[1].Text, dtpNgayTra.Value);
        }

        public void traToanBoSachCua1Phieu(ListView lvSachDaDuocMuon, DateTimePicker dtpNgayTra)
        {
            for (int i = 0; i < lvSachDaDuocMuon.Items.Count; i++)
                TraSachTrongChiTietPhieuMuonSach(lvSachDaDuocMuon.Items[i].SubItems[1].Text, dtpNgayTra.Value);
        }
        #endregion

        #region btn Xóa
        public void xoaSachTuGioHang(ListView lvGioHang)
        {
            for (int i = lvGioHang.SelectedItems.Count - 1; i >= 0; i--)
            {
                if (lvGioHang.Items[i].Selected)
                    lvGioHang.Items[i].Remove();
            }
        }

        private void xoaPM(string maPM, string maDG)
        {
            PHIEUMUONSACH pm = DB.PHIEUMUONSACHes.FirstOrDefault(s => s.MaPhieuMuon.Equals(maPM) && s.MaDocGia.Equals(maDG));

            try
            {
                DB.PHIEUMUONSACHes.DeleteOnSubmit(pm);
                DB.SubmitChanges();
                MessageBox.Show("Xóa phiếu mượn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void xoaPhieuMuonTuDSPM(ListView lvDanhSachPhieuMuon)
        {
            for (int i = 0; i < lvDanhSachPhieuMuon.Items.Count; i++)
                if (lvDanhSachPhieuMuon.Items[i].Selected)
                    xoaPM(lvDanhSachPhieuMuon.Items[i].SubItems[0].Text, lvDanhSachPhieuMuon.Items[i].SubItems[2].Text);
        }
        #endregion

    }
}
