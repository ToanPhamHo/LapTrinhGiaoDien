using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace LapTrinhCoSoDuLieu
{
    class DAOvsBUSDocGia
    {
        DataClasses1DataContext DB = new DataClasses1DataContext();

        public IEnumerable<DOCGIA> trichBangDocGiaTuDB()
        {
            return DB.DOCGIAs.ToList();
        }

        public void themDG(string maDG, string hoTen, string ngaySinh, string diaChi, string email, string ngayLapThe, string ngayHetHan, string tienNo)
        {
            DOCGIA dg = new DOCGIA();
            dg.MaDocGia = maDG;
            dg.HoTenDocGia = hoTen;
            dg.NgaySinh = DateTime.Parse(ngaySinh);
            dg.DiaChi = diaChi;
            dg.Email = email;
            dg.NgayLapThe = DateTime.Parse(ngayLapThe);
            dg.NgayHetHan = DateTime.Parse(ngayHetHan);
            dg.TienNo = float.Parse(tienNo);

            try
            {             
                DB.DOCGIAs.InsertOnSubmit(dg);
                DB.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Thêm thành công!");
        }

        public void suaDG(string maDG, string hoTen, string ngaySinh, string diaChi, string email, string ngayLapThe, string ngayHetHan, string tienNo)
        {
            DOCGIA dg = DB.DOCGIAs.FirstOrDefault(s => s.MaDocGia.Equals(maDG));
            dg.HoTenDocGia = hoTen;
            dg.NgaySinh = DateTime.Parse(ngaySinh);
            dg.DiaChi = diaChi;
            dg.Email = email;
            dg.NgayLapThe = DateTime.Parse(ngayLapThe);
            dg.NgayHetHan = DateTime.Parse(ngayHetHan);
            dg.TienNo = float.Parse(tienNo);

            try
            {
                DB.SubmitChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void xoaDG(ListView lvDBDG)
        {
            for (int i = 0; i < lvDBDG.Items.Count; i++)
            {
                if (lvDBDG.Items[i].Selected)
                {
                    DOCGIA dg = DB.DOCGIAs.FirstOrDefault(s => s.MaDocGia.Equals(lvDBDG.Items[i].SubItems[0].Text));

                    try
                    {
                        DB.DOCGIAs.DeleteOnSubmit(dg);
                        DB.SubmitChanges();
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
        }
    }
}
