using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace LapTrinhCoSoDuLieu
{
    class DAOvsBUSSach
    {
        DataClasses1DataContext DB = new DataClasses1DataContext();

        public IEnumerable<SACH> trichSachTuDB()
        {
            return DB.SACHes.ToList();
        }

        private IEnumerable<SACH> timSach(string ts)
        {
            return DB.SACHes.Where(s => s.MaSach.Contains(ts) || s.TenSach.Contains(ts) || s.TacGia.Contains(ts) || s.NhaXuatBan.Contains(ts) || s.NamXuatBan.ToString().Contains(ts) || s.NgayNhap.ToString().Contains(ts) || s.TriGia.ToString().Contains(ts));
        }

        public void timKiemSach(string tk, ListView lvS)
        {
            IEnumerable<SACH> sachs = timSach(tk);
            lvS.Items.Clear();
            foreach (SACH sa in sachs)
            {
                ListViewItem lv = new ListViewItem(sa.MaSach.ToString());
                lv.SubItems.Add(sa.TenSach.ToString());
                lv.SubItems.Add(sa.TacGia.ToString());
                lv.SubItems.Add(sa.NamXuatBan.ToString());
                lv.SubItems.Add(sa.NhaXuatBan.ToString());
                lv.SubItems.Add(sa.TriGia.ToString());
                lv.SubItems.Add(sa.NgayNhap.Value.ToString());
                lvS.Items.Add(lv);
            }
        }

        public void themS(string maS, string ten, string tacGia, string namXuatBan, string nhaXuatBan, string triGia, string ngayNhap)
        {
            SACH s = new SACH();
            s.MaSach = maS;
            s.TenSach = ten;
            s.NgayNhap = DateTime.Parse(ngayNhap);
            s.TacGia = tacGia;
            s.NhaXuatBan = nhaXuatBan;
            s.NamXuatBan = int.Parse(namXuatBan);
            s.TriGia = float.Parse(triGia);

            try
            {
                DB.SACHes.InsertOnSubmit(s);
                DB.SubmitChanges();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void suaS(string maS, string ten, string tacGia, string namXuatBan, string nhaXuatBan, string triGia, string ngayNhap)
        {
            SACH sachs = DB.SACHes.FirstOrDefault(s => s.MaSach.Equals(maS));
            sachs.TenSach = ten;
            sachs.TacGia = tacGia;
            sachs.NamXuatBan = int.Parse(namXuatBan);
            sachs.NhaXuatBan = nhaXuatBan;
            sachs.TriGia = float.Parse(triGia);
            sachs.NgayNhap = DateTime.Parse(ngayNhap);

            try
            {
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Sửa thành công!", "Thông báo");
        }

        public void xoaS(ListView lvS)
        {

            using (TransactionScope t = new TransactionScope())
            {
                for (int i = 0; i < lvS.SelectedIndices.Count; i++)
                {
                    SACH sachs = DB.SACHes.FirstOrDefault(s => s.MaSach.Equals(lvS.SelectedItems[i].SubItems[0].Text));

                    try
                    {
                        DB.SACHes.DeleteOnSubmit(sachs);
                        DB.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Xóa thành công!", "Thông báo");
                t.Complete();
            }
        }
    }
}
