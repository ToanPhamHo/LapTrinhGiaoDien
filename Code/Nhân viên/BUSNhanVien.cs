     using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Transactions;

namespace LapTrinhCoSoDuLieu
{
    class BUSNhanVien
    {
        DAONhanVien daonv = new DAONhanVien();

        public void them(string hoTen, string ngaySinh, string diaChi, string sdt, string bangCap)
        {
            daonv.themNV(hoTen, ngaySinh, diaChi, sdt, bangCap);
        }

        public void sua(string maNV, string hoTen, string ngaySinh, string diaChi, string sdt, string bangCap)
        {
            daonv.suaNV(maNV, hoTen, ngaySinh, diaChi, sdt, bangCap);        
        }

        public void xoa(ListView lvDataBase)
        {
            using (TransactionScope t = new TransactionScope())
            {
                for (int i = 0; i < lvDataBase.Items.Count; i++)
                    if (lvDataBase.Items[i].Selected)
                        daonv.xoaNV(lvDataBase.Items[i].SubItems[0].Text);
                MessageBox.Show("Xóa thành công", "Thông báo");
                t.Complete();
            }
        }
    }
}
